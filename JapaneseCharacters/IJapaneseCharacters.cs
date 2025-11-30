using OutSystems.ExternalLibraries.SDK;

namespace JapaneseCharacters;

[OSInterface(
    Name = "JapaneseCharacters",
    Description = "Japanese character conversion utilities",
    IconResourceName = "JapaneseCharacters.Resources.JapaneseCharacters.icon.png")]
public interface IJapaneseCharacters
{
    [OSAction(
        Description = "Converts half-width (Hankaku) characters to full-width (Zenkaku) characters",
        ReturnName = "ResultText",
        ReturnDescription = "A Text with its original half-width characters converted into full-width characters",
        ReturnType = OSDataType.Text)]
    string HankakuToZenkaku(
        [OSParameter(
            Description = "A Text to convert",
            DataType = OSDataType.Text)]
        string SourceText);

    [OSAction(
        Description = "Converts full-width (Zenkaku) characters to half-width (Hankaku) characters",
        ReturnName = "ResultText",
        ReturnDescription = "A Text with its original full-width characters converted into half-width characters",
        ReturnType = OSDataType.Text)]
    string ZenkakuToHankaku(
        [OSParameter(
            Description = "A Text to convert",
            DataType = OSDataType.Text)]
        string SourceText);

    [OSAction(
        Description = "Converts Hiragana characters to Katakana characters",
        ReturnName = "ResultText",
        ReturnDescription = "A Text with its original Hiragana characters converted into Katakana characters",
        ReturnType = OSDataType.Text)]
    string HiraganaToKatakana(
        [OSParameter(
            Description = "A Text to convert",
            DataType = OSDataType.Text)]
        string SourceText);

    [OSAction(
        Description = "Converts Katakana characters to Hiragana characters",
        ReturnName = "ResultText",
        ReturnDescription = "A Text with its original Katakana characters converted into Hiragana characters",
        ReturnType = OSDataType.Text)]
    string KatakanaToHiragana(
        [OSParameter(
            Description = "A Text to convert",
            DataType = OSDataType.Text)]
        string SourceText);
}
