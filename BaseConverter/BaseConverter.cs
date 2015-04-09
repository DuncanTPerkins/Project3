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
        static Stack<int> FromDecimalStack = new Stack<int>();
        static Stack<int> ToDecimalStack = new Stack<int>();
        static int CounterLength = 0;
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

            while (1==1)
            {
                try
                {
                    if (NumPlaces > 10)
                    {

                    }
                    FinalReturnString += FromDecimalStack.Pop().ToString();
                    CounterLength++;
                }

                catch (InvalidOperationException e) { 
                    break;
                }
            }

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
        public static int toDecimal()
        {
            int integer = 0;

            return integer;
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

        public static string StringToHex(string str) )
        {

        }
    }


}
