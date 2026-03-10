using intro_cs.App;

namespace intro_cs;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var unStylo = new Pen("BlAcK");
        Console.WriteLine(unStylo.Color);
        // Le set étant protected, on n'y a pas accès d'ici
        // unStylo.Color = "red";
        
        unStylo.Write("bonjour");
        Console.WriteLine("----------------");
        unStylo.Write();
    }
}