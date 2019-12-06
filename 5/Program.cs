using System;
using System.Collections.Generic;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "tMlsioaplnKlflgiruKanliaebeLlkslikkpnerikTasatamkDpsdakeraBeIdaegptnuaKtmteorpuTaTtbtsesOHXxonibmksekaaoaKtrssegnveinRedlkkkroeekVtkekymmlooLnanoKtlstoepHrpeutdynfSneloietbol";
            List<string> strList = new List<string>();
            for (int i = 0; i <= str.Length - 2; i += 3)
            {
                strList.Add(str.Substring(i, 3));
            }
            for (int i = 0; i < strList.Count/2; i++)
            {
                string s = strList[i];
                strList[i] = strList[strList.Count - i - 1];
                strList[strList.Count - i - 1] = s;
            }
            str = string.Join("", strList);
            string newString = "";
            for (int i = 0; i < str.Length - 1; i +=2)
            {
                newString += str[i + 1];
                newString += str[i];
            }
            Console.WriteLine(newString);
            strList.Clear();
            strList.Add(newString.Substring(0, newString.Length / 2));
            strList.Add(newString.Substring(newString.Length / 2, newString.Length / 2));
            string tmp = strList[0];
            strList[0] = strList[1];
            strList[1] = tmp;
            Console.WriteLine(string.Join("", strList));
        }
    }
}
