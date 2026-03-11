using intro_cs.App.Utils;

namespace intro_cs.App;

public class VocalWriter : IWriterDevice
{
    public string VoiceTranscript()
    {
        // imaginons que cette methode traite un signal audio ...
        return "Le micro";
    }
    public void Write(string message)
    {
        message = ColorFormat.GetColoredString(message, foreground: Color256.White, background: Color256.Magenta);
        Console.WriteLine(message);
        
    }
}