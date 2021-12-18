using System;
using System.Collections;
using System.Windows.Forms;

namespace ClientWCF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {  

        }

        /// <summary>
        /// Callback ou Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ws_SomaCompleted(object sender, WsExtWCF.SomaCompletedEventArgs e)
        {
            MessageBox.Show("Soma = " + e.Result.ToString());
        }

        /// <summary>
        /// Chamada Assincrona de Serviços
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            //using assynchronous WCF Services

            WsExtWCF.CalcClient ws = new WsExtWCF.CalcClient(); //proxy local!!!
            ws.GetPessoasCompleted += Ws_GetPessoasCompleted;   //Callback
            ws.GetPessoasAsync();                               //Invocar metodo assincrono
            MessageBox.Show("Esperando...");
            ws.Close();

        }

        private void Ws_GetPessoasCompleted(object sender, WsExtWCF.GetPessoasCompletedEventArgs e)
        {
 
            System.Threading.Thread.Sleep(2000);        //simular espera de 2 segundos
            WsExtWCF.Pessoa[] pes = e.Result;
            ArrayList myArrayList = new ArrayList();
            myArrayList.AddRange(pes);
            dataGridView1.DataSource = myArrayList;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WsExtWCF.CalcClient ws = new WsExtWCF.CalcClient();
            WsExtWCF.Pessoa[] pes = ws.GetPessoas();
            ArrayList myArrayList = new ArrayList();
            myArrayList.AddRange(pes);
            dataGridView1.DataSource = myArrayList;
            ws.Close();
        }
    }
}
