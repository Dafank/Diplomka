using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Text;

namespace Diplomka.Models
{
    public static class TranslateModel
    {
        public static string Translater(string s)
        {
            FileStream filer = new FileStream(@"D:\MVC\LanguageFeatures\Test-translater\uk-ua.txt", FileMode.Open);
            string[] ft = new string[200];
            StreamReader re = new StreamReader(filer, Encoding.Default);
            int l = 0;
            while ((ft[l] = re.ReadLine()) != null)
            {
                l++;
            }
            re.Close();
            filer.Close();

            string[] lf = null;
            char sign = ' ';
            string[] asd = new string[l * 2];
            int g = 0;
            for (int i = 0; i < l; i++)
            {
                lf = ft[i].Split(sign);
                for (int j = 0; j < 2; j++)
                {
                    asd[g] = lf[j];
                    g++;
                }
            }
            g = 0;

            string str = null;
            foreach (string es in asd)
            {
                if (es == s)
                {
                    ++g;
                    str = asd[g];
                }

                g++;
            }


            return str;
        }
    }
}
