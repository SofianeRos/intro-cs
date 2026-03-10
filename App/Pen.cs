using System.Text;
using intro_cs.App.Utils;

namespace intro_cs.App;

public class Pen
{
    private string? _color;
    public string Color
    {
        get => _color ?? "black";
        protected set => _color = value.ToLowerInvariant();
    }
    
    // "old fashion"
    // public string Color
    // {
    //     get { return _color; }
    //     protected set
    //     {
    //         _color = value.ToLowerInvariant();
    //     }
    // }
    //
    
    public readonly int UnChamp;

    public Pen(string color)
    {
        this.Color = color;
        this.UnChamp = 4;
    }
    
    // Polymorphisme sur le constructeur
    public Pen(string color, int unChamp)
    {
        this.Color = color;
        this.UnChamp = unChamp;
    }

    public void Toto()
    {
        // On n'a pas le droit de toucher à une readonly ailleurs que dans le constructeur
        // this.UnChamp = 5;
        this.Color = "red";
    }

    public void Write(string message)
    {
        // \x = Préfixe pour écrire un code en hexadécimal
        // 1B = code héxadécimal de l'emplacement du caractère "Echap(ESC)" dans la table de caractère ANSI
        // [38 = Indique le formatage du texte
        // [48 = Indique le formatage du fond
        // :5 = Indique qu'on utilise le mode 256 couleurs
        // :code = Code de la couleur souhaitée
        // m = Indicateur de fin d'instruction (la suite sera le texte écrit)
        // \x1B[0m = Commande de remise à zéro du style
        
        // Concaténation de texte basique
        // Console.WriteLine("\x1B[38:5:196m\x1B[48:5:213m" + message + "\x1B[0m");
        
        // Concaténation par templating ("string interpolation")
        // Console.WriteLine($"\x1B[38:5:196m\x1B[48:5:213m{message}\x1B[0m");
        
        // String.Format (version du templating)
        // var result = string.Format(
        //     "\x1B[38:5:196m\x1B[48:5:213m{0}\x1B[0m",
        //     message
        // );
        // Console.WriteLine(result);
        
        // StringBuilder : Artillerie lourde, sert pour construire des grosse de chaînes
        // StringBuilder builder = new();
        // builder
        //     .Append("\x1B[38:5:196m") // On ajoute le code de la couleur du texte
        //     .Append("\x1B[48:5:213m") // Puis celui de la couleur du fond
        //     .Append(message) // Puis le message
        //     .Append("\x1B[0m"); // Puis le code  de reset du format
        // Console.WriteLine(builder.ToString()); // On envoie dans la console le builder converti en string
        Console.WriteLine(ColorFormat.GetColoredString(message, Color256.Red, Color256.DarkRed));
    }

    // Surcharge de méthode qui s'appuie sur la méthode d'origine
    public void Write()
    {
        this.Write("Mon message par défault");
    }
    
    
    
}