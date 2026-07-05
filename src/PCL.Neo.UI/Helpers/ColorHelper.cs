using Avalonia.Media;

namespace PCL.Neo.UI.Helpers;

public static class ColorHelper
{
    public static NeoColorPalette GenerateColorPalette(Color color)
    {
        return new NeoColorPalette
        {
            Accent = color,
            AccentLight1 = Lighten(color, 0.2),
            AccentLight2 = Lighten(color, 0.4),
            AccentLight3 = Lighten(color, 0.6),
            AccentDark1 = Darken(color, 0.2),
            AccentDark2 = Darken(color, 0.4),
            AccentDark3 = Darken(color, 0.6)
        };
    }
    
    /// <summary>
    /// 变亮颜色。
    /// </summary>
    /// <param name="color">要变亮的颜色。</param>
    /// <param name="amount">变亮的程度，范围应在 0.0 到 1.0 之间。</param>
    /// <returns>变亮后的颜色。</returns>
    public static Color Lighten(Color color, double amount)
    {
        // 转换为 HSL 空间
        var hsl = color.ToHsl();

        // 线性相加
        var newL = Math.Clamp(hsl.L + amount, 0.0, 1.0);

        // 转回 RGB
        return new HslColor(hsl.A, hsl.H, hsl.S, newL).ToRgb();
    }
    
    /// <summary>
    /// 变暗颜色。
    /// </summary>
    /// <param name="color">要变暗的颜色。</param>
    /// <param name="amount">变暗的程度，范围应在 0.0 到 1.0 之间。</param>
    /// <returns>变暗后的颜色。</returns>
    public static Color Darken(Color color, double amount)
    {
        return Lighten(color, -amount);
    }
}