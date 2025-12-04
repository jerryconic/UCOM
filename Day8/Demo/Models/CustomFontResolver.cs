using PdfSharp.Fonts;
using System.IO;
using ClosedXML.Excel;

public class CustomFontResolver : IFontResolver
{
    private readonly string _fontPath;
    public CustomFontResolver(string fontPath)
    {
        _fontPath = fontPath;
    }

    public byte[] GetFont(string faceName)
    {
        // 只處理一種字型
        return File.ReadAllBytes(_fontPath);
    }

    public FontResolverInfo ResolveTypeface(string familyName, bool isBold, bool isItalic)
    {
        // 只要 familyName 包含 "NotoSansTC" 就回傳自訂名稱
        if (familyName.Contains("NotoSansTC", StringComparison.OrdinalIgnoreCase))
        {
            return new FontResolverInfo("NotoSansTC#");
        }
        // 可加上 fallback
        return PlatformFontResolver.ResolveTypeface("Arial", isBold, isItalic);
    }
}