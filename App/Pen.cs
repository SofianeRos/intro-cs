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
        // \x = prefixe pour ecrire un code en hexadecimal
        // 1B = code hexadecimale de l'emplacement du caractere "echap (esc)" dans la table de caractere 
        // [38 = indique le formatage du texte 
        // [48= Indique le formatage du fond 
        // :5 indique qu'on utilise le mode 256 couleurs 
        // :code = code de la couleur souhaiter 
        // m = Indicateur de fin de l'instruction 
        Console.WriteLine("\x1B[38;5;175m" + message);
    }

    // Surcharge de méthode qui s'appuie sur la méthode d'origine
    public void Write()
    {
        this.Write("Mon message par défault");
        
    }
    
    
    
}