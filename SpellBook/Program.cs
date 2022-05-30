global using SpellBook;


Console.WriteLine("Generátor náhodných spellů");

List<Spell> seznamSpellu = new List<Spell>();
HelperClass pomocneMetody = new HelperClass();  

string[] poleForma = pomocneMetody.PoleZTextu("plocha/spellform.txt");
string[] poleTypy = pomocneMetody.PoleZTextu("plocha/spelltypes.txt");

while (true)
{
    Console.WriteLine("1. vygenerovat nový spell a přidat do Spellbooku");
    Console.WriteLine("2. zobrazit Spellbook");
    Console.WriteLine("3. smazat poslední záznam ve Spellbooku");
    Console.WriteLine("4. smazat celý Spellbook");
    Console.WriteLine("*. ukončit aplikaci");


    string input = Console.ReadLine();

    if (input == "1")
    {
        Spell newspell = new Spell();
        newspell.Name = pomocneMetody.VygenerujemeSpellName(poleForma, poleTypy);
        newspell.ManaCost = pomocneMetody.VygenerujCisloMax(500);
        seznamSpellu.Add(newspell);
    }
    else if (input == "2")
    {

    }
    else if (input == "3")
    {

    }
    else if (input == "4")
    {

    }
    else if (input == "*")
    {

    }
}