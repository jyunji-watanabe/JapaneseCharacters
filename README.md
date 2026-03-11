# JapaneseCharacters
This is a C# ClassLib project for ODC External Logic to handle Japanese Characters.

# Features
- Zenkaku to Hankaku conversion
- Hankaku to Zenkaku conversion
- Hiragana to Katakana conversion
- Katakana to Hiragana conversion
- Custom override mappings for Hiragana to Katakana conversion (single and batch)
- Custom override mappings for Katakana to Hiragana conversion (single and batch)

If you want to handle many set of inputs at once, you can use the batch methods provided, for example ZenkakuToHankakuBatch instead of ZenkakuToHankaku.
This is important for performance, as each method call is done through ODC External Logic, meaning there is overhead for each call.

## HiraganaToKatakana custom mappings
`HiraganaToKatakana` and `HiraganaToKatakanaBatch` accept a `List<CustomMapping>` parameter.

- If one or more mappings are provided, the specified Hiragana characters are overridden with your custom mapped text.
- Characters not specified in `CustomMappings` keep the default `KanaConverter.ToKatakana` behavior.
- If `CustomMappings` is empty, default conversion is used.
- Internal use of `KanaConverter.MapToKatakana` is reset after each call to avoid impacting subsequent processing.

## KatakanaToHiragana custom mappings
`KatakanaToHiragana` and `KatakanaToHiraganaBatch` accept a `List<CustomMapping>` parameter.

- If one or more mappings are provided, the specified Katakana characters are overridden with your custom mapped text.
- Characters not specified in `CustomMappings` keep the default `KanaConverter.ToHiragana` behavior.
- If `CustomMappings` is empty, default conversion is used.
- Internal use of `KanaConverter.MapToHiragana` is reset after each call to avoid impacting subsequent processing.

# Dependencies
This project uses the following open source library:
- [Kana.NET](https://github.com/rucio-rucio/Kana.NET)