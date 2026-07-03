namespace PCL.Neo.UI;

public class RefreshedEventArgs(NeoColorPalette palette) : EventArgs
{
    public NeoColorPalette Palette { get; } = palette;
}