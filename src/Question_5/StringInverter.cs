public class StringInverter
{
    public string Invert(string input)
    {
        char[] charArray = input.ToCharArray();
        string invertedString = "";

        for (int i = charArray.Length - 1; i >= 0; i--)
        {
            invertedString += charArray[i];
        }

        return invertedString;
    }
}