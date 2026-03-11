namespace JapaneseCharacters.Tests;

public class JapaneseCharactersTests
{
    private readonly JapaneseCharacters _japaneseCharacters;

    public JapaneseCharactersTests()
    {
        _japaneseCharacters = new JapaneseCharacters();
    }

    #region HankakuToZenkaku Tests

    [Fact]
    public void HankakuToZenkaku_WithHalfWidthCharacters_ReturnsFullWidthCharacters()
    {
        // Arrange
        string sourceText = "ABC123";

        // Act
        string result = _japaneseCharacters.HankakuToZenkaku(sourceText);

        // Assert
        Assert.Equal("ＡＢＣ１２３", result);
    }

    [Fact]
    public void HankakuToZenkaku_WithEmptyString_ReturnsEmptyString()
    {
        // Arrange
        string sourceText = "";

        // Act
        string result = _japaneseCharacters.HankakuToZenkaku(sourceText);

        // Assert
        Assert.Equal("", result);
    }

    [Fact]
    public void HankakuToZenkaku_WithNull_ReturnsNull()
    {
        // Arrange
        string? sourceText = null;

        // Act
        string? result = _japaneseCharacters.HankakuToZenkaku(sourceText!);

        // Assert
        Assert.Null(result);
    }

    [Fact]
    public void HankakuToZenkaku_WithMixedCharacters_ReturnsConvertedString()
    {
        // Arrange
        string sourceText = "Hello123";

        // Act
        string result = _japaneseCharacters.HankakuToZenkaku(sourceText);

        // Assert
        Assert.Equal("Ｈｅｌｌｏ１２３", result);
    }

    #endregion

    #region HankakuToZenkakuBatch Tests

    [Fact]
    public void HankakuToZenkakuBatch_WithMultipleTexts_ReturnsConvertedList()
    {
        // Arrange
        var sourceTexts = new List<string> { "ABC", "123", "xyz" };

        // Act
        var result = _japaneseCharacters.HankakuToZenkakuBatch(sourceTexts);

        // Assert
        Assert.Equal(3, result.Count);
        Assert.Equal("ＡＢＣ", result[0]);
        Assert.Equal("１２３", result[1]);
        Assert.Equal("ｘｙｚ", result[2]);
    }

    [Fact]
    public void HankakuToZenkakuBatch_WithEmptyList_ReturnsEmptyList()
    {
        // Arrange
        var sourceTexts = new List<string>();

        // Act
        var result = _japaneseCharacters.HankakuToZenkakuBatch(sourceTexts);

        // Assert
        Assert.Empty(result);
    }

    [Fact]
    public void HankakuToZenkakuBatch_WithNull_ReturnsEmptyList()
    {
        // Arrange
        List<string>? sourceTexts = null;

        // Act
        var result = _japaneseCharacters.HankakuToZenkakuBatch(sourceTexts!);

        // Assert
        Assert.Empty(result);
    }

    #endregion

    #region ZenkakuToHankaku Tests

    [Fact]
    public void ZenkakuToHankaku_WithFullWidthCharacters_ReturnsHalfWidthCharacters()
    {
        // Arrange
        string sourceText = "ＡＢＣ１２３";

        // Act
        string result = _japaneseCharacters.ZenkakuToHankaku(sourceText);

        // Assert
        Assert.Equal("ABC123", result);
    }

    [Fact]
    public void ZenkakuToHankaku_WithEmptyString_ReturnsEmptyString()
    {
        // Arrange
        string sourceText = "";

        // Act
        string result = _japaneseCharacters.ZenkakuToHankaku(sourceText);

        // Assert
        Assert.Equal("", result);
    }

    [Fact]
    public void ZenkakuToHankaku_WithNull_ReturnsNull()
    {
        // Arrange
        string? sourceText = null;

        // Act
        string? result = _japaneseCharacters.ZenkakuToHankaku(sourceText!);

        // Assert
        Assert.Null(result);
    }

    [Fact]
    public void ZenkakuToHankaku_WithMixedCharacters_ReturnsConvertedString()
    {
        // Arrange
        string sourceText = "Ｈｅｌｌｏ１２３";

        // Act
        string result = _japaneseCharacters.ZenkakuToHankaku(sourceText);

        // Assert
        Assert.Equal("Hello123", result);
    }

    #endregion

    #region ZenkakuToHankakuBatch Tests

    [Fact]
    public void ZenkakuToHankakuBatch_WithMultipleTexts_ReturnsConvertedList()
    {
        // Arrange
        var sourceTexts = new List<string> { "ＡＢＣ", "１２３", "ｘｙｚ" };

        // Act
        var result = _japaneseCharacters.ZenkakuToHankakuBatch(sourceTexts);

        // Assert
        Assert.Equal(3, result.Count);
        Assert.Equal("ABC", result[0]);
        Assert.Equal("123", result[1]);
        Assert.Equal("xyz", result[2]);
    }

    [Fact]
    public void ZenkakuToHankakuBatch_WithEmptyList_ReturnsEmptyList()
    {
        // Arrange
        var sourceTexts = new List<string>();

        // Act
        var result = _japaneseCharacters.ZenkakuToHankakuBatch(sourceTexts);

        // Assert
        Assert.Empty(result);
    }

    [Fact]
    public void ZenkakuToHankakuBatch_WithNull_ReturnsEmptyList()
    {
        // Arrange
        List<string>? sourceTexts = null;

        // Act
        var result = _japaneseCharacters.ZenkakuToHankakuBatch(sourceTexts!);

        // Assert
        Assert.Empty(result);
    }

    #endregion

    #region HiraganaToKatakana Tests

    [Fact]
    public void HiraganaToKatakana_WithHiraganaCharacters_ReturnsKatakanaCharacters()
    {
        // Arrange
        string sourceText = "ひらがな";

        // Act
        string result = _japaneseCharacters.HiraganaToKatakana(sourceText, []);

        // Assert
        Assert.Equal("ヒラガナ", result);
    }

    [Fact]
    public void HiraganaToKatakana_WithEmptyString_ReturnsEmptyString()
    {
        // Arrange
        string sourceText = "";

        // Act
        string result = _japaneseCharacters.HiraganaToKatakana(sourceText, []);

        // Assert
        Assert.Equal("", result);
    }

    [Fact]
    public void HiraganaToKatakana_WithNull_ReturnsNull()
    {
        // Arrange
        string? sourceText = null;

        // Act
        string? result = _japaneseCharacters.HiraganaToKatakana(sourceText!, []);

        // Assert
        Assert.Null(result);
    }

    [Fact]
    public void HiraganaToKatakana_WithMixedCharacters_ReturnsConvertedString()
    {
        // Arrange
        string sourceText = "こんにちは123";

        // Act
        string result = _japaneseCharacters.HiraganaToKatakana(sourceText, []);

        // Assert
        Assert.Equal("コンニチハ123", result);
    }

    [Fact]
    public void HiraganaToKatakana_WithCustomMappings_OverridesSpecifiedCharactersOnly()
    {
        // Arrange
        string sourceText = "ひらがな";
        var customMappings = new List<CustomMapping>
        {
            new() { SourceCharacter = "ひ", MappedCharacter = "X" }
        };

        // Act
        string result = _japaneseCharacters.HiraganaToKatakana(sourceText, customMappings);

        // Assert
        Assert.Equal("Xラガナ", result);
    }

    [Fact]
    public void HiraganaToKatakana_WithCustomMappings_ResetsMapAfterCall()
    {
        // Arrange
        var customMappings = new List<CustomMapping>
        {
            new() { SourceCharacter = "ひ", MappedCharacter = "X" }
        };

        // Act
        var first = _japaneseCharacters.HiraganaToKatakana("ひらがな", customMappings);
        var second = _japaneseCharacters.HiraganaToKatakana("ひらがな", []);

        // Assert
        Assert.Equal("Xラガナ", first);
        Assert.Equal("ヒラガナ", second);
    }

    [Fact]
    public void HiraganaToKatakana_WithInvalidCustomMappings_IgnoresInvalidItems()
    {
        // Arrange
        string sourceText = "ひら";
        var customMappings = new List<CustomMapping>
        {
            new() { SourceCharacter = "", MappedCharacter = "X" },
            new() { SourceCharacter = "ひら", MappedCharacter = "Y" },
            new() { SourceCharacter = "ひ", MappedCharacter = "X" }
        };

        // Act
        string result = _japaneseCharacters.HiraganaToKatakana(sourceText, customMappings);

        // Assert
        Assert.Equal("Xラ", result);
    }

    #endregion

    #region HiraganaToKatakanaBatch Tests

    [Fact]
    public void HiraganaToKatakanaBatch_WithMultipleTexts_ReturnsConvertedList()
    {
        // Arrange
        var sourceTexts = new List<string> { "ひらがな", "かたかな", "もじ" };

        // Act
        var result = _japaneseCharacters.HiraganaToKatakanaBatch(sourceTexts, []);

        // Assert
        Assert.Equal(3, result.Count);
        Assert.Equal("ヒラガナ", result[0]);
        Assert.Equal("カタカナ", result[1]);
        Assert.Equal("モジ", result[2]);
    }

    [Fact]
    public void HiraganaToKatakanaBatch_WithEmptyList_ReturnsEmptyList()
    {
        // Arrange
        var sourceTexts = new List<string>();

        // Act
        var result = _japaneseCharacters.HiraganaToKatakanaBatch(sourceTexts, []);

        // Assert
        Assert.Empty(result);
    }

    [Fact]
    public void HiraganaToKatakanaBatch_WithNull_ReturnsEmptyList()
    {
        // Arrange
        List<string>? sourceTexts = null;

        // Act
        var result = _japaneseCharacters.HiraganaToKatakanaBatch(sourceTexts!, []);

        // Assert
        Assert.Empty(result);
    }

    [Fact]
    public void HiraganaToKatakanaBatch_WithCustomMappings_AppliesOverrides()
    {
        // Arrange
        var sourceTexts = new List<string> { "ひら", "なひ" };
        var customMappings = new List<CustomMapping>
        {
            new() { SourceCharacter = "ひ", MappedCharacter = "X" }
        };

        // Act
        var result = _japaneseCharacters.HiraganaToKatakanaBatch(sourceTexts, customMappings);

        // Assert
        Assert.Equal(2, result.Count);
        Assert.Equal("Xラ", result[0]);
        Assert.Equal("ナX", result[1]);
    }

    [Fact]
    public void HiraganaToKatakanaBatch_WithCustomMappings_ResetsMapAfterCall()
    {
        // Arrange
        var sourceTexts = new List<string> { "ひらがな" };
        var customMappings = new List<CustomMapping>
        {
            new() { SourceCharacter = "ひ", MappedCharacter = "X" }
        };

        // Act
        var first = _japaneseCharacters.HiraganaToKatakanaBatch(sourceTexts, customMappings);
        var second = _japaneseCharacters.HiraganaToKatakanaBatch(sourceTexts, []);

        // Assert
        Assert.Single(first);
        Assert.Single(second);
        Assert.Equal("Xラガナ", first[0]);
        Assert.Equal("ヒラガナ", second[0]);
    }

    #endregion

    #region KatakanaToHiragana Tests

    [Fact]
    public void KatakanaToHiragana_WithKatakanaCharacters_ReturnsHiraganaCharacters()
    {
        // Arrange
        string sourceText = "カタカナ";

        // Act
        string result = _japaneseCharacters.KatakanaToHiragana(sourceText, []);

        // Assert
        Assert.Equal("かたかな", result);
    }

    [Fact]
    public void KatakanaToHiragana_WithEmptyString_ReturnsEmptyString()
    {
        // Arrange
        string sourceText = "";

        // Act
        string result = _japaneseCharacters.KatakanaToHiragana(sourceText, []);

        // Assert
        Assert.Equal("", result);
    }

    [Fact]
    public void KatakanaToHiragana_WithNull_ReturnsNull()
    {
        // Arrange
        string? sourceText = null;

        // Act
        string? result = _japaneseCharacters.KatakanaToHiragana(sourceText!, []);

        // Assert
        Assert.Null(result);
    }

    [Fact]
    public void KatakanaToHiragana_WithMixedCharacters_ReturnsConvertedString()
    {
        // Arrange
        string sourceText = "コンニチハ123";

        // Act
        string result = _japaneseCharacters.KatakanaToHiragana(sourceText, []);

        // Assert
        Assert.Equal("こんにちは123", result);
    }

    [Fact]
    public void KatakanaToHiragana_WithCustomMappings_OverridesSpecifiedCharactersOnly()
    {
        // Arrange
        string sourceText = "カタカナ";
        var customMappings = new List<CustomMapping>
        {
            new() { SourceCharacter = "カ", MappedCharacter = "X" }
        };

        // Act
        string result = _japaneseCharacters.KatakanaToHiragana(sourceText, customMappings);

        // Assert
        Assert.Equal("XたXな", result);
    }

    [Fact]
    public void KatakanaToHiragana_WithCustomMappings_ResetsMapAfterCall()
    {
        // Arrange
        var customMappings = new List<CustomMapping>
        {
            new() { SourceCharacter = "カ", MappedCharacter = "X" }
        };

        // Act
        var first = _japaneseCharacters.KatakanaToHiragana("カタカナ", customMappings);
        var second = _japaneseCharacters.KatakanaToHiragana("カタカナ", []);

        // Assert
        Assert.Equal("XたXな", first);
        Assert.Equal("かたかな", second);
    }

    [Fact]
    public void KatakanaToHiragana_WithInvalidCustomMappings_IgnoresInvalidItems()
    {
        // Arrange
        string sourceText = "カタ";
        var customMappings = new List<CustomMapping>
        {
            new() { SourceCharacter = "", MappedCharacter = "X" },
            new() { SourceCharacter = "カタ", MappedCharacter = "Y" },
            new() { SourceCharacter = "カ", MappedCharacter = "X" }
        };

        // Act
        string result = _japaneseCharacters.KatakanaToHiragana(sourceText, customMappings);

        // Assert
        Assert.Equal("Xた", result);
    }

    #endregion

    #region KatakanaToHiraganaBatch Tests

    [Fact]
    public void KatakanaToHiraganaBatch_WithMultipleTexts_ReturnsConvertedList()
    {
        // Arrange
        var sourceTexts = new List<string> { "カタカナ", "ヒラガナ", "モジ" };

        // Act
        var result = _japaneseCharacters.KatakanaToHiraganaBatch(sourceTexts, []);

        // Assert
        Assert.Equal(3, result.Count);
        Assert.Equal("かたかな", result[0]);
        Assert.Equal("ひらがな", result[1]);
        Assert.Equal("もじ", result[2]);
    }

    [Fact]
    public void KatakanaToHiraganaBatch_WithEmptyList_ReturnsEmptyList()
    {
        // Arrange
        var sourceTexts = new List<string>();

        // Act
        var result = _japaneseCharacters.KatakanaToHiraganaBatch(sourceTexts, []);

        // Assert
        Assert.Empty(result);
    }

    [Fact]
    public void KatakanaToHiraganaBatch_WithNull_ReturnsEmptyList()
    {
        // Arrange
        List<string>? sourceTexts = null;

        // Act
        var result = _japaneseCharacters.KatakanaToHiraganaBatch(sourceTexts!, []);

        // Assert
        Assert.Empty(result);
    }

    [Fact]
    public void KatakanaToHiraganaBatch_WithCustomMappings_AppliesOverrides()
    {
        // Arrange
        var sourceTexts = new List<string> { "カタ", "ナカ" };
        var customMappings = new List<CustomMapping>
        {
            new() { SourceCharacter = "カ", MappedCharacter = "X" }
        };

        // Act
        var result = _japaneseCharacters.KatakanaToHiraganaBatch(sourceTexts, customMappings);

        // Assert
        Assert.Equal(2, result.Count);
        Assert.Equal("Xた", result[0]);
        Assert.Equal("なX", result[1]);
    }

    [Fact]
    public void KatakanaToHiraganaBatch_WithCustomMappings_ResetsMapAfterCall()
    {
        // Arrange
        var sourceTexts = new List<string> { "カタカナ" };
        var customMappings = new List<CustomMapping>
        {
            new() { SourceCharacter = "カ", MappedCharacter = "X" }
        };

        // Act
        var first = _japaneseCharacters.KatakanaToHiraganaBatch(sourceTexts, customMappings);
        var second = _japaneseCharacters.KatakanaToHiraganaBatch(sourceTexts, []);

        // Assert
        Assert.Single(first);
        Assert.Single(second);
        Assert.Equal("XたXな", first[0]);
        Assert.Equal("かたかな", second[0]);
    }

    #endregion
}
