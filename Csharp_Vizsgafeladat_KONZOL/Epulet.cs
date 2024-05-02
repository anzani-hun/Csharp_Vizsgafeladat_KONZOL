using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Vizsgafeladat_KONZOL
{
    class Epulet
    {
        // adatbázis első sora: 1;Burj Khalifa;Dubai (AE);828;2717;163;2010;steel/concrete;office / residential / hotel
        //int string string decimal int int int
        public int rang;
        public string nev;
        public string varos_orszag;
        public decimal magassag_meter;
        public int magassag_lab;
        public int emeletekSzama;
        public int epitesEve;


        //konstruktor generálása
        public Epulet(int rang, string nev, string varos_orszag, decimal magassag_meter, int magassag_lab, int emeletekSzama, int epitesEve)
        {
            this.rang = rang;
            this.nev = nev;
            this.varos_orszag = varos_orszag;
            this.magassag_meter = magassag_meter;
            this.magassag_lab = magassag_lab;
            this.emeletekSzama = emeletekSzama;
            this.epitesEve = epitesEve;
        }
    }
}
