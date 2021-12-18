/*
 * Manipular Expressões Regulares
 * 
 * Find & Replace
 * lufer & Oscar Ribeiro
 * ISI
 * 
 * Adaptado de:
 * http://towardsnext.wordpress.com/2009/02/02/replace-data-in-file-c/
 * */
using System;
using System.Text;
using System.IO;

namespace findReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            FileFindReplace ffr = new FileFindReplace();
            ffr.ReplaceByChunk(@"..\..\..\index.txt", "Benfica", "Porto;", 10);
        }
    }


    public class FileFindReplace
    {
        /// <summary>
        /// Replace the data in the Huge files searching and replacing chunk
        /// by chunk. It will create new file as filepath + ".tmp" file with
        /// replaced data
        /// </summary>
        /// <param name="filePath">Path of the file</param>
        /// <param name="replaceText">Text to be replaced</param>
        /// <param name="withText">Text with which it is replaced</param>
        public void ReplaceLineByLine(string filePath, string replaceText, string withText)
        {
            StreamReader streamReader = new StreamReader(filePath);
            StreamWriter streamWriter = new StreamWriter(filePath + ".tmp");

            while (!streamReader.EndOfStream) 
            {
                string data = streamReader.ReadLine();
                data = data.Replace(replaceText, withText);
                streamWriter.WriteLine(data);
            }

            streamReader.Close();
            streamWriter.Close();
        }

        /// <summary>
        /// Replace the data in the Huge files searching and replacing chunk
        /// by chunk. It will create new file as filepath + ".tmp" file with
        /// replaced data
        /// </summary>
        /// <param name="filePath">Path of the file</param>
        /// <param name="replaceText">Text to be replaced</param>
        /// <param name="withText">Text with which it is replaced</param>
        /// <param name="chunkLength">Length of the data to be loaded at one go</param>
        public void ReplaceByChunk(string filePath, string replaceText, string withText, int chunkLength)
        {
            int loadLength = chunkLength + replaceText.Length;
            char[] buffer = new char[loadLength];
            int index = 0;
            int replaceLength = replaceText.Length;

            StreamReader streamReader = new StreamReader(filePath);
            StreamWriter streamWriter = new StreamWriter(filePath + ".tmp");

            //Load the data according to the chunk length specified
            //also load the extra data according to the length of 
            //the replace text so that chunk end and start text break
            //can be handled
            while(true)
            {
                //Seek to the position from where we want to start and
                //load the data in to the memory
                streamReader.DiscardBufferedData();
                streamReader.BaseStream.Seek(index, SeekOrigin.Begin);
                int count = streamReader.ReadBlock(buffer,0,loadLength);
                if (count == 0) break;

                //Get the data and check whether the extra loaded data 
                //is replaceable if yes then set end replaced flag
                string data = ConvertToString(buffer, count);
                bool isEndReplaced = false;
                if(count >= chunkLength)
                    isEndReplaced = (data.LastIndexOf(withText, chunkLength) > 0);
                
                //Replace the data with the specified data and save the 
                //new data in the new file
                data = data.Replace(replaceText, withText);
                if(isEndReplaced)
                {
                    streamWriter.Write(data);
                    index += count;
                }
                else
                {
                    if (count >= chunkLength)
                    {
                        streamWriter.Write(data.Substring(0, data.Length - replaceLength));
                        index += chunkLength;
                    }
                    else
                    {
                        streamWriter.Write(data);
                        index += chunkLength;
                    }
                }
            }

            streamReader.Close();
            streamWriter.Close();
        }

        private string ConvertToString(char[] buffer, int count)
        {
            StringBuilder data = new StringBuilder(buffer.Length);

            for (int i = 0; i < count; i++)
            {
                data.Append(buffer[i]);
            }

            return data.ToString();
        }
    }
}
