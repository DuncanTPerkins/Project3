//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:	    Project 3
//	File Name:		BaseConverter.cs
//	Description:    Converts between base numerical systems
//	Course:			CSCI 2210-001 - Data Structures
//	Author:			Duncan Perkins, perkinsdt@goldmail.etsu.edu, Department of Computing, East Tennessee State University
//	Created:	    April 7, 2015
//	Copyright:		Duncan Perkins, 2015
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseConverter
{
    /// <summary>
    /// Class for converting From and To different number bases 
    /// </summary>
    class BaseConverter
    {
        //Stack for converting from decimal
        static Stack<int> FromDecimalStack = new Stack<int>();

        //Stack for converting to decimal
        static Stack<int> ToDecimalStack = new Stack<int>();
        
        //Final string to be returned 
        static string FinalReturnString = "";

        /// <summary>
        /// Method for converting Decimal (Base 10) numbers to other bases
        /// </summary>
        /// <param name="ConvertTo">Base to convert to</param>
        /// <param name="num">Number for conversion</param>
        /// <param name="NumPlaces">Number of places wanted in output</param>
        /// <returns></returns>
        public static string FromDecimal(int ConvertTo, int num, int NumPlaces)
        {
            FinalReturnString = "";
            while(num != 0) {
                int remainder = num % ConvertTo;
                FromDecimalStack.Push(remainder);
                num /= ConvertTo; 
            }

            //run forever
            while (1==1)
            {
                //If the stack isn't empty, pop the top off of the stack, 
                //convert the number to a hex character if it's greater than 10,
                //and append it to the Final String
                try
                {
                    string CheckForHex = ""; 
                    CheckForHex = FromDecimalStack.Pop().ToString();
                    FinalReturnString+=StringToHex(CheckForHex);

                }

                //this exception is thrown if the stack is empty,
                //so break out of the loop when this happens
                catch (InvalidOperationException e) { 
                    break;
                }
            }

            //prepend zeroes if we're short on number places
            if (FinalReturnString.Length < NumPlaces)
            {
                FinalReturnString = ZeroPrepender(FinalReturnString, NumPlaces - FinalReturnString.Length);
            }

            return FinalReturnString;
            
        }

        /// <summary>
        /// Method for converting other Bases to Decimal (Base 10)
        /// </summary>
        /// <returns></returns>
        public static int toDecimal(int ConvertFrom, string num )
        {
            int integer = 0;
            int result = 0;
            char[] ar = num.ToString().ToCharArray();
            List<int> intList = new List<int>();
            List<string> StringList = new List<string>();
            foreach(char c in ar) { 
                StringList.Add(c.ToString());
            }

            for (int i = 0; i < StringList.Count; i++)
            {
                int n;
                 bool isNumeric = int.TryParse(StringList[i], out n);

                if (isNumeric)
                {

                }

                else {
                    switch (StringList[i])
                    {
                        case "F":
                        StringList[i] = "15";
                        break;

                        case "E":
                        StringList[i] = "14";
                        break;

                        case "D":
                        StringList[i] = "13";
                        break;

                        case "C":
                        StringList[i] = "12";
                        break;

                        case "B":
                        StringList[i] = "11";
                        break;

                        case "A":
                        StringList[i] = "10";
                        break;
                        

                    }
                }
            }

            foreach (string s in StringList)
            {
                intList.Add(int.Parse(s));
            }

            for (int i = 0; i < intList.Count; i++)
            {
                result *= ConvertFrom;
                result += intList[i];
            }


            return result;
        }

        /// <summary>
        /// supporting method for prepending Zeroes to a string 
        /// </summary>
        /// <param name="str"></param>
        /// <param name="NumZeroes"></param>
        /// <returns></returns>
        public static string ZeroPrepender(string str, int NumZeroes)
        {
            string localstr = "";
            for (int i = 0; i < NumZeroes; i++)
            {
                localstr += "0";
            }
            localstr += str;
            return localstr;
        }

        /// <summary>
        /// Converts a decimal value to its hexadecimal equivalent
        /// </summary>
        /// <param name="str">string to be converted</param>
        /// <returns>converted string</returns>
        public static string StringToHex(string str) 
        {
            if(int.Parse(str) < 10) {
            }
            else { 
            switch (str)
            {
                case "10":
                str = "A";
                break;

                case "11": 
                str = "B";
                break;

                case "12": 
                str = "C";
                break;

                case "13": 
                str = "D";
                break;

                case "14": 
                str = "E";
                break;

                case "15": 
                str = "F";
                break;

                 }
            }
            return str;
            }
        }
    }



