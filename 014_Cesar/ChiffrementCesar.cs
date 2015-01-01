using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiffrementCesar
{
    class Cesar
    {
        private int Clef;
        public Cesar(int Clef)
        {
            this.Clef = Clef;
        }
        public string Chiffrer(string m)
        {
            int i;
            char c;
            string Résultat = "";
            for (i = 0; i < m.Length; i++)
            {
                c = m[i];
                c = (char)(c + Clef);
                if (c > 'Z') c = (char)(c - 26);
                Résultat = Résultat + c;
            }
            return Résultat;
        }
        public string DéChiffrer(string m)
        {
            int i;
            char c;
            string Résultat = "";
            for (i = 0; i < m.Length; i++)
            {
                c = m[i];
                c = (char)(c - Clef);
                if (c < 'A') c = (char)(c + 26);
                Résultat = Résultat + c;
            }
            return Résultat;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cesar c = new Cesar(3);
            string Msg = "ALEAJACTAEST";
            string MsgSecret = c.Chiffrer(Msg);
            string MsgDéchiffré = c.DéChiffrer(MsgSecret);
            Console.WriteLine(Msg);
            Console.WriteLine(MsgSecret);
            Console.WriteLine(MsgDéchiffré);
        }
    }
}
