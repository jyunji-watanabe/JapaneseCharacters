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

    public string ZenkakuToHankaku(string SourceText)
    {
        if (string.IsNullOrEmpty(SourceText))
            return SourceText;

        return KanaConverter.ToNarrow(SourceText);
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
