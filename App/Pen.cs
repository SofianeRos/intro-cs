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
        Console.WriteLine(message);
    }

    // Surcharge de méthode qui s'appuie sur la méthode d'origine
    public void Write()
    {
        this.Write("Mon message par défault");
    }
    
    
    
}