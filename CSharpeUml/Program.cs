using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CSharpeUml
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, j = 2;

            List<int> MaListe = new List<int>();

            MaListe.Add(15);
            MaListe.Add(5);
            MaListe.Add(3);
            MaListe.Add(10);
            MaListe.Add(20);
            MaListe.Add(1);
            MaListe.Add(21);
            MaListe.Add(16);
            MaListe.Add(16);
            MaListe.Add(32);
            MaListe.Add(13);
            MaListe.Add(3);

            MaListe.Sort();

            foreach(int nombre in MaListe)
            {
                WriteLine(nombre);
            }

            //WriteLine(i.CompareTo(j));
            ReadKey();
        }
    }
}
