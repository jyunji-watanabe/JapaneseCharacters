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

    public List<string> HankakuToZenkakuBatch(List<string> SourceTexts)
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

    public List<string> ZenkakuToHankakuBatch(List<string> SourceTexts)
    {
        if (SourceTexts == null || SourceTexts.Count == 0)
            return [];

        return [.. SourceTexts.Select(sourceText => KanaConverter.ToNarrow(sourceText))];
    }

    public string HiraganaToKatakana(string SourceText, List<CustomMapping> CustomMappings)
    {
        if (string.IsNullOrEmpty(SourceText))
            return SourceText;

        if (CustomMappings == null || CustomMappings.Count == 0)
            return KanaConverter.ToKatakana(SourceText);

        var customMappings = BuildCustomMappings(CustomMappings);
        if (customMappings.Count == 0)
            return KanaConverter.ToKatakana(SourceText);

        var previousMapToKatakana = KanaConverter.MapToKatakana;

        try
        {
            KanaConverter.MapToKatakana = (stringBuilder, sourceKana, defaultConverted, sourceText) =>
            {
                if (customMappings.TryGetValue(sourceKana, out var customMapped))
                {
                    stringBuilder.Append(customMapped);
                    return;
                }

                stringBuilder.Append(defaultConverted);
            };

            return KanaConverter.ToKatakana(SourceText);
        }
        finally
        {
            KanaConverter.MapToKatakana = previousMapToKatakana;
        }
    }

    public List<string> HiraganaToKatakanaBatch(List<string> SourceTexts, List<CustomMapping> CustomMappings)
    {
        if (SourceTexts == null || SourceTexts.Count == 0)
            return [];

        if (CustomMappings == null || CustomMappings.Count == 0)
            return [.. SourceTexts.Select(sourceText => KanaConverter.ToKatakana(sourceText))];

        var customMappings = BuildCustomMappings(CustomMappings);
        if (customMappings.Count == 0)
            return [.. SourceTexts.Select(sourceText => KanaConverter.ToKatakana(sourceText))];

        var previousMapToKatakana = KanaConverter.MapToKatakana;

        try
        {
            KanaConverter.MapToKatakana = (stringBuilder, sourceKana, defaultConverted, sourceText) =>
            {
                if (customMappings.TryGetValue(sourceKana, out var customMapped))
                {
                    stringBuilder.Append(customMapped);
                    return;
                }

                stringBuilder.Append(defaultConverted);
            };

            return [.. SourceTexts.Select(sourceText => KanaConverter.ToKatakana(sourceText))];
        }
        finally
        {
            KanaConverter.MapToKatakana = previousMapToKatakana;
        }
    }

    public string KatakanaToHiragana(string SourceText, List<CustomMapping> CustomMappings)
    {
        if (string.IsNullOrEmpty(SourceText))
            return SourceText;

        if (CustomMappings == null || CustomMappings.Count == 0)
            return KanaConverter.ToHiragana(SourceText);

        var customMappings = BuildCustomMappings(CustomMappings);
        if (customMappings.Count == 0)
            return KanaConverter.ToHiragana(SourceText);

        var previousMapToHiragana = KanaConverter.MapToHiragana;

        try
        {
            KanaConverter.MapToHiragana = (stringBuilder, sourceKana, defaultConverted, sourceText) =>
            {
                if (customMappings.TryGetValue(sourceKana, out var customMapped))
                {
                    stringBuilder.Append(customMapped);
                    return;
                }

                stringBuilder.Append(defaultConverted);
            };

            return KanaConverter.ToHiragana(SourceText);
        }
        finally
        {
            KanaConverter.MapToHiragana = previousMapToHiragana;
        }
    }

    public List<string> KatakanaToHiraganaBatch(List<string> SourceTexts, List<CustomMapping> CustomMappings)
    {
        if (SourceTexts == null || SourceTexts.Count == 0)
            return [];

        if (CustomMappings == null || CustomMappings.Count == 0)
            return [.. SourceTexts.Select(sourceText => KanaConverter.ToHiragana(sourceText))];

        var customMappings = BuildCustomMappings(CustomMappings);
        if (customMappings.Count == 0)
            return [.. SourceTexts.Select(sourceText => KanaConverter.ToHiragana(sourceText))];

        var previousMapToHiragana = KanaConverter.MapToHiragana;

        try
        {
            KanaConverter.MapToHiragana = (stringBuilder, sourceKana, defaultConverted, sourceText) =>
            {
                if (customMappings.TryGetValue(sourceKana, out var customMapped))
                {
                    stringBuilder.Append(customMapped);
                    return;
                }

                stringBuilder.Append(defaultConverted);
            };

            return [.. SourceTexts.Select(sourceText => KanaConverter.ToHiragana(sourceText))];
        }
        finally
        {
            KanaConverter.MapToHiragana = previousMapToHiragana;
        }
    }

    private static Dictionary<string, string> BuildCustomMappings(List<CustomMapping> customMappings)
    {
        var result = new Dictionary<string, string>();

        foreach (var customMapping in customMappings)
        {
            if (string.IsNullOrWhiteSpace(customMapping.SourceCharacter) ||
                string.IsNullOrEmpty(customMapping.MappedCharacter) ||
                customMapping.SourceCharacter.Length != 1)
            {
                continue;
            }

            result.TryAdd(customMapping.SourceCharacter, customMapping.MappedCharacter);
        }

        return result;
    }
}
