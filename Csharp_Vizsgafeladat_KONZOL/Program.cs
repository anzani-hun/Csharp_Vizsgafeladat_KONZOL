using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//csv eléréséhez kell
using System.IO;

namespace Csharp_Vizsgafeladat_KONZOL
{
    class Program
    {

        //dinamikus lista létrehozása (epuletek) néven: 
        static List<Epulet> epuletek = new List<Epulet>();

    static void Main(string[] args)
        {
            beolvasas();


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Az adatbázis beolvasása!");
            Console.ForegroundColor = ConsoleColor.White;

            foreach (Epulet adat in epuletek)
            {
                Console.WriteLine(adat.nev);
            }


            
            
            Console.WriteLine();

            Console.ReadKey();
        }

        private static void beolvasas()
        {
            using (StreamReader sr = new StreamReader("100_tallest_javitott4.csv"))
            {
                //olvassa amíg nincs vége a fájlnak
                while (!sr.EndOfStream)
                {
                    //a sorokból vesszőnél elválasztva feldaraboljuk
                    string[] line = sr.ReadLine().Split(';');

                    //Epulet példányosítása     
                    // adatbázis első sora: 1;Burj Khalifa;Dubai (AE);828;2717;163;2010;steel/concrete;office / residential / hotel
                    Epulet epulet = new Epulet(int.Parse(line[0]), line[1], line[2], decimal.Parse(line[3]), int.Parse(line[4]), int.Parse(line[5]), int.Parse(line[6]));

                    //epuletek hozzáadása soronként
                    epuletek.Add(epulet);
                }
            }
        }
    }
}