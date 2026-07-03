using Avalonia.Controls;
using Avalonia.Styling;

namespace PCL.Neo.UI;

public class NeoColorPaletteResourceProvider : ResourceProvider
{
    public const string AccentKey = "NeoSystemAccentColor";
    public const string AccentDark1Key = "NeoSystemAccentColorDark1";
    public const string AccentDark2Key = "NeoSystemAccentColorDark2";
    public const string AccentDark3Key = "NeoSystemAccentColorDark3";
    public const string AccentLight1Key = "NeoSystemAccentColorLight1";
    public const string AccentLight2Key = "NeoSystemAccentColorLight2";
    public const string AccentLight3Key = "NeoSystemAccentColorLight3";
    
    private NeoColorPalette _palette;
    
    public override bool HasResources => true;
    
    public override bool TryGetResource(object key, ThemeVariant? theme, out object? value)
    {
        if (key is string strKey)
        {
            value = strKey switch
            {
                AccentKey => _palette.Accent,
                AccentDark1Key => _palette.AccentDark1,
                AccentDark2Key => _palette.AccentDark2,
                AccentDark3Key => _palette.AccentDark3,
                AccentLight1Key => _palette.AccentLight1,
                AccentLight2Key => _palette.AccentLight2,
                AccentLight3Key => _palette.AccentLight3,
                _ => null
            };
        }
        else
        {
            value = null;
        }

        return value != null;
    }
}