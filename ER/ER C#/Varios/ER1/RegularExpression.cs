/*
*	<copyright file="ER1.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/22/2021 9:18:46 PM</date>
*	<description>
*	Regular Expressions in C#
*	Adptado de https://www.geeksforgeeks.org/what-is-regular-expression-in-c-sharp/
*	</description>
**/
using System;
using System.Text.RegularExpressions;

namespace ER1
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 10/22/2021 9:18:46 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class RegularExpression
    {
        
        #region Methods

        /// <summary>
        ///  Method to check the Email ID
        /// </summary>
        /// <param name="inputEmail"></param>
        /// <returns></returns>
        public static bool isValidEmail(string inputEmail)
        {

            // This Pattern is use to verify the email
            string strRegex = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";

            Regex re = new Regex(strRegex, RegexOptions.IgnoreCase);

            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }

        /// <summary>
        /// Analisa um número de telefone
        /// </summary>
        /// <param name="inputMobileNumber"></param>
        /// <returns></returns>
        public static bool isValidMobileNumber(string inputMobileNumber)
        {
            string strRegex = @"(^[0-9]{10}$)|(^\+[0-9]{2}\s+[0-9]
                {2}[0-9]{8}$)|(^[0-9]{3}-[0-9]{4}-[0-9]{4}$)";

            // Class Regex Represents an
            // immutable regular expression.
            //   Format                Pattern
            // xxxxxxxxxx           ^[0 - 9]{ 10}$
            // +xx xx xxxxxxxx     ^\+[0 - 9]{ 2}\s +[0 - 9]{ 2}\s +[0 - 9]{ 8}$
            // xxx - xxxx - xxxx   ^[0 - 9]{ 3} -[0 - 9]{ 4}-[0 - 9]{ 4}$
            Regex re = new Regex(strRegex);

            // The IsMatch method is used to validate
            // a string or to ensure that a string
            // conforms to a particular pattern.
            if (re.IsMatch(inputMobileNumber))
                return (true);
            else
                return (false);
        }

        #endregion
    }
}
