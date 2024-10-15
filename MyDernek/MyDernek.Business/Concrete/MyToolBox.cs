using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDernek.Business.Concrete
{
    public static class MyToolBox
    {
        //TC Kimlik Doğrulama
        public static bool ControlTcKimlik(string TcKimlik)
        {
            bool returnvalue = true;
            //Tc Doğruluk Kontrolü,  gerçek tc kimlik için yorumdan kurtarılmalı
            /*if (TcKimlik.Length == 11)
            {
                Int64 ATCNO, BTCNO, TcNo;
                long C1, C2, C3, C4, C5, C6, C7, C8, C9, Q1, Q2;
                TcNo = Int64.Parse(TcKimlik);
                ATCNO = TcNo / 100;
                BTCNO = TcNo / 100;
                C1 = ATCNO % 10;
                ATCNO = ATCNO / 10;
                C2 = ATCNO % 10;
                ATCNO = ATCNO / 10;
                C3 = ATCNO % 10;
                ATCNO = ATCNO / 10;
                C4 = ATCNO % 10;
                ATCNO = ATCNO / 10;
                C5 = ATCNO % 10;
                ATCNO = ATCNO / 10;
                C6 = ATCNO % 10;
                ATCNO = ATCNO / 10;
                C7 = ATCNO % 10;
                ATCNO = ATCNO / 10;
                C8 = ATCNO % 10;
                ATCNO = ATCNO / 10;
                C9 = ATCNO % 10;
                ATCNO = ATCNO / 10;
                Q1 = ((10 - ((((C1 + C3 + C5 + C7 + C9) * 3) + (C2 + C4 + C6 + C8)) % 10)) % 10);
                Q2 = ((10 - (((((C2 + C4 + C6 + C8) + Q1) * 3) + (C1 + C3 + C5 + C7 + C9)) % 10)) % 10);
                returnvalue = ((BTCNO * 100) + (Q1 * 10) + Q2 == TcNo);
            }*/

            return returnvalue;
        }

        // Boş parametre kontrolü
        public static bool CheckStringParameters(params string[] parameters)
        {
            foreach (string parameter in parameters)
            {
                if (string.IsNullOrEmpty(parameter))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
