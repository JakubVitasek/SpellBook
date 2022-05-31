using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellBook
{
    internal class HelperClass
    {
        public Random generator = new Random();
        public string[] PoleZTextu(string adresaSouboru)
        {
            string ObsahTXT = File.ReadAllText(adresaSouboru);
            string[] obsah = ObsahTXT.Split(";");
            return obsah;
        }
        public string VygenerujemeSpellName(string[] poleForma, string[] poleTypy)
        {
            int indexForma = VygenerujCisloMax(poleForma.Length - 1);
            int indexTypy = generator.Next(poleTypy.Length - 1);
            string spojene = $"{poleTypy[indexTypy]} {poleForma[indexForma]}";
            return spojene;

        }
        public int VygenerujCisloMax(int max)
        {
            int cislo = generator.Next(0, max);
            return cislo;
        }



    }
}
