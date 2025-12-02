using Umayadia.Kana;

namespace JapaneseCharacters;

public class JapaneseCharacters : IJapaneseCharacters
{
    public string HankakuToZenkaku(string SourceText)
    {
        if (string.IsNullOrEmpty(SourceText))
            return SourceText;

        return KanaConverter.ToWide(SourceText);
    }

    public List<string> HankakuToZenkaku_Bulk(List<string> SourceTexts)
    {
        if (SourceTexts == null || SourceTexts.Count == 0)
            return [];

        return [.. SourceTexts.Select(sourceText => KanaConverter.ToWide(sourceText))];
    }

    public string ZenkakuToHankaku(string SourceText)
    {
        if (string.IsNullOrEmpty(SourceText))
            return SourceText;

        return KanaConverter.ToNarrow(SourceText);
    }

    public List<string> ZenkakuToHankaku_Bulk(List<string> SourceTexts)
    {
        if (SourceTexts == null || SourceTexts.Count == 0)
            return [];

        return [.. SourceTexts.Select(sourceText => KanaConverter.ToNarrow(sourceText))];
    }

    public string HiraganaToKatakana(string SourceText)
    {
        if (string.IsNullOrEmpty(SourceText))
            return SourceText;

        return KanaConverter.ToKatakana(SourceText);
    }

    public string KatakanaToHiragana(string SourceText)
    {
        if (string.IsNullOrEmpty(SourceText))
            return SourceText;

        return KanaConverter.ToHiragana(SourceText);
    }
}
