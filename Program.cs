using intro_cs.App;
using intro_cs.App.Utils;

namespace intro_cs;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var unStylo = new Pen(Color256.Black);
        
        unStylo.Write("Bonjour");
        Console.WriteLine("---------");
        ConsoleHelper.Pause("Oups, freeze...");
        ConsoleHelper.ErrorMessage();
        ConsoleHelper.Title("Bienvenue sur mon programme", Color256.Yellow, Color256.DarkGreen);
        unStylo.Write();
        var unePlume = new FeatherPen(Color256.Blue, FontStyle.Italic);
        unePlume.Write("Hello, World!");
        unePlume.Write();
    }
}