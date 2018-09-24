using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib_Registo
//namespace RegistoAppCode
{
    public static class Registo
    {
        private static Random rnd = new Random();

        // This method returns a pseudo-random uppercase letter (A-Z)

        private static char GetPseudoRandomUpperCaseLetter(Random rnd)
        {
            return (char)('A' + rnd.Next(0, 26));
        }

        private static int EncryptTwoDigitNumber(int num)
        {
            return (num / 10) * 100 + (num % 10);
        }

        public static string NumeroEntrada(DateTime dt, string inicial = "RNE")
        {
            string nbe = inicial;
            nbe += dt.Year.ToString() + dt.Month.ToString("00") + dt.Day.ToString("00");
            nbe += EncryptTwoDigitNumber(dt.Second).ToString("000");
            nbe += EncryptTwoDigitNumber(dt.Minute).ToString("000");
            nbe += EncryptTwoDigitNumber(dt.Hour).ToString("000");
            nbe += GetPseudoRandomUpperCaseLetter(rnd);

            return nbe;
        }



    }
}
