using NUnit.Framework;

[TestFixture]
public class StringInverterTests
{
    private StringInverter _stringInverter;

    [SetUp]
    public void Setup()
    {
        _stringInverter = new StringInverter();
    }

    [Test]
    public void Invert_ShouldInvertString_WhenGivenValidString()
    {
        // Arrange
        string input = "hello";
        string expected = "olleh";

        // Act
        string result = _stringInverter.Invert(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Invert_ShouldReturnEmptyString_WhenGivenEmptyString()
    {
        // Arrange
        string input = "";
        string expected = "";

        // Act
        string result = _stringInverter.Invert(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Invert_ShouldInvertString_WhenGivenSingleCharacter()
    {
        // Arrange
        string input = "a";
        string expected = "a";

        // Act
        string result = _stringInverter.Invert(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Invert_ShouldInvertString_WhenGivenStringWithSpaces()
    {
        // Arrange
        string input = "hello world";
        string expected = "dlrow olleh";

        // Act
        string result = _stringInverter.Invert(input);

        // Assert
        Assert.AreEqual(expected, result);
    }
}