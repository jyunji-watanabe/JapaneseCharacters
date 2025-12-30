# JapaneseCharacters
This is a C# ClassLib project for ODC External Logic to handle Japanese Characters.

# Features
- Zenkaku to Hankaku conversion
- Hankaku to Zenkaku conversion
- Hiragana to Katakana conversion
- Katakana to Hiragana conversion

If you want to handle many set of inputs at once, you can use the batch methods provided, for example ZenkakuToHankakuBatch instead of ZenkakuToHankaku.
This is important for performance, as each method call is done through ODC External Logic, meaning there is overhead for each call.

# Dependencies
This project uses the following open source library:
- [Kana.NET](https://github.com/rucio-rucio/Kana.NET)