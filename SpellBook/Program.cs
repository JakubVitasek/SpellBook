global using SpellBook;

List<Spell> seznamSpellu = new List<Spell>();
HelperClass pomocneMetody = new HelperClass();  

string[] poleForma = pomocneMetody.PoleZTextu("txt/spellform.txt");
string[] poleTypy = pomocneMetody.PoleZTextu("txt/spelltypes.txt");

while (true)
{
    Console.WriteLine("___________________");
    Console.WriteLine("1. vygenerovat nový spell a přidat do Spellbooku");
    Console.WriteLine("2. zobrazit Spellbook");
    Console.WriteLine("3. smazat poslední záznam ve Spellbooku");
    Console.WriteLine("4. smazat celý Spellbook");
    Console.WriteLine("*. ukončit aplikaci");
    Console.WriteLine("___________________");


    string input = Console.ReadLine();

    if (input == "1")
    {
        Spell newspell = new Spell();
        newspell.Name = pomocneMetody.VygenerujemeSpellName(poleForma, poleTypy);
        newspell.ManaCost = pomocneMetody.VygenerujCisloMax(500);
        seznamSpellu.Add(newspell);
        Console.Clear();
    }
    else if (input == "2")
    {
        Console.Clear();
        foreach (Spell spell in seznamSpellu)
        {
            Console.WriteLine($" {spell.Name}---{(spell.ManaCost)}MP");
        }    
    }
    else if (input == "3")
    {
        if (seznamSpellu.Any()) 
        {
            seznamSpellu.RemoveAt(seznamSpellu.Count - 1);
        }
        Console.Clear();
    }
    else if (input == "4")
    {
        seznamSpellu.Clear();
        Console.Clear();
    }
    else if (input == "*")
    {
        break;
    }
    
}
