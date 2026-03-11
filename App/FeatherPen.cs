using System.ComponentModel;
using intro_cs.App.Utils;

namespace intro_cs.App;

// Sealed est l'équivalent de final en PHP
public sealed class FeatherPen : Pen
{
    private FontStyle _style;
    
    public FeatherPen(Color256 color, FontStyle style) : base(color)
    {
        // : base(color) en PHP => parent::__construct($color)
        this._style = style;
    }

    public override void Write(string message)
    {
        message = string.Concat(ColorFormat.GetStyleCode(this._style), message);
        base.Write(message);
    }
}