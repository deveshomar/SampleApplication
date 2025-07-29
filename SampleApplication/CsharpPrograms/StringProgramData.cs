using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SampleApplication.CsharpPrograms
{
    internal class StringProgramData
    {
        string stringData = "Hello this is devesh";
        // devesh is this hello



        public string printreverse( string str)
        {
            //str = "Ramkumar";
            // ramukmar 
            StringBuilder sb = new StringBuilder();
            char[] strdata = str.ToCharArray();
            for (int i = strdata.Length; i-- >= 0;)
            {
                sb.Append(strdata[i]);
                sb.Append(" ");
                if (i == 0)
                    break;
            }
            return sb.ToString();

        }
        public string ReverseTheString(string inputString)
        {
            string[] array = inputString.Split(" ");
            StringBuilder sb = new StringBuilder(); 


            for (int i = array.Length ; i-- >=0;) {
                sb.Append(array[i]);
                sb.Append(" ");
                if (i == 0)
                    break;
            }


            return sb.ToString();

        }
        // Name->Devesh,  Address , City->India, State, Country
        public string ReverseTheStringWithSpecialSybmbol(string inputString, char csplit)
        {
            string[] array = inputString.Split(csplit);
            StringBuilder sb = new StringBuilder();


            for (int i = array.Length; i-- >= 0;)
            {
                sb.Append(array[i]);
                sb.Append(" ");
                if (i == 0)
                    break;
            }


            return sb.ToString();

        }
    }
}
