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
            string obsahTxt = File.ReadAllText("plocha/spellform.txt");
            string obsahTxt2 = File.ReadAllText("plocha/spelltypes.txt");
            int delka1 = obsahTxt.Length;
            int delka2 = obsahTxt2.Length;
            string[] poleForma = obsahTxt.Split(";");
            string[] poleTypy = obsahTxt.Split(";");

        }
        public string VygenerujemeSpellName(string[] poleForma, string[] poleTypy)
        {
            int indexForma = VygenerujCisloMax(poleForma.Length - 1);
            int indexTypy = generator.Next(0, poleTypy.Length - 1);
            string spojene = (indexForma + indexTypy).ToString();
            return spojene;

        }
        public int VygenerujCisloMax(int max)
        {
            int cislo = generator.Next(0, max);
            return cislo;
        }



    }
}
