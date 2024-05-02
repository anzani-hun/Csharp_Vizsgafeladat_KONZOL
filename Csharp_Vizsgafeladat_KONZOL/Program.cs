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
            adatbazisBeolvasas();


            Console.WriteLine("");


            Console.ForegroundColor = ConsoleColor.White;
            /*AZ EGÉSZ LISTA KIIRATÁSA: PRÓBÁBÓL */
            /*
            foreach (Epulet adat in epuletek)
            {
                Console.WriteLine(adat.nev);
            }
            */



            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Az adatbázis beolvasása KÉSZ!\n");

            /*1. feladat:*/
            /*mennyi épület adata lett beolvasva?   /segítség: adatok.count */
            feladat001();

            /*2. feladat:*/
            /* mennyi olyan élület van, amelyik neve nem tartalmazza a "Tower" szót?*/
            feladat002();


            /*3. feladat: */
            /* Készítsetek egy új metódust TutiEpulet() néven az Epulet osztályban,
             * amely egy logikai értékkel tér vissza attól függően, hogy az épület 500 m-nél
             * magasabb és 100 emelettel többel rendelkezik-e?
             */
            // el lett készítve az Epulet.cs osztály és abban a kód kész! 
            
            
            
            
            /*4. feladat: */
            feladat004();

            Console.ReadKey();
        }


        private static void feladat004()
        {
            Console.Write("Kérek egy évszámot: ");
            int adatBekeres = int.Parse(Console.ReadLine());
            decimal osszMagassag = 0;

            foreach (Epulet adat in epuletek)
            {
                if (adatBekeres > adat.epitesEve)
                {
                    osszMagassag = osszMagassag + adat.epitesEve;
                }
            }
            Console.WriteLine($"A megadott évszámunk: {adatBekeres}");
            Console.WriteLine($"Az épületek összmagassága: {osszMagassag}");
        }




        private static void feladat002()
        {
            int towerSzo = 0;

            foreach(Epulet adat in epuletek)
            {
                if (!adat.nev.Contains("Tower"))
                {
                    towerSzo++;
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"Az épületek száma, ami NEM tartalmazza a TOWER szót!: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{towerSzo}");
        }



        private static void feladat001()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"A beolvasott épületek száma: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{epuletek.Count}");
        }





        private static void adatbazisBeolvasas()
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