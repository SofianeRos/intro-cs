using System.Text;
using intro_cs.App.Utils;

namespace intro_cs.App;

public class Pen
{
    protected Color256 Color;
    
    public Pen(Color256 color)
    {
        this.Color = color;
    }
    
    public virtual void Write(string message)
    {
        Console.WriteLine(ColorFormat.GetColoredString(message, Color256.Red, Color256.DarkRed));
    }

    // Surcharge de méthode qui s'appuie sur la méthode d'origine
    public void Write()
    {
        this.Write("Mon message par défault");
    }
    
}