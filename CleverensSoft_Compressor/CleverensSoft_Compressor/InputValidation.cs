static class InputValidation
{
    // 0. Нет смысла в экземплярах, поэтому класс статический
    // 1. Добавил проверку введенных данных для каждой операции
    // 2. Использовал LINQ и перебор foreach 
    static public bool IsValidCompressedString(string? str)
    {
        if (string.IsNullOrEmpty(str) || !IsLowerLatin(str))
            return false;
        return true;
    }

    public static bool IsValidDecompressedString(string str)
    {
        if (string.IsNullOrEmpty(str) || !IsLowerLatinOrDigit(str))
            return false;

        for (int i = 0; i < str.Length; i++)
        {
            var isNotLetterAfterDigit = i < str.Length - 1 && char.IsDigit(str[i]) && !char.IsLetter(str[i + 1]);
            var isNextCharSame = (i < str.Length - 1 && str[i] == str[i + 1]);

            if (isNotLetterAfterDigit || isNextCharSame)
                return false;
        }
        return true;
    }

    private static bool IsLatin(char c) => 
        (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z');

    private static bool IsLowerLatin(string str) =>
        str.All(c => char.IsLower(c) && IsLatin(c));

    private static bool IsLowerLatinOrDigit(string str)
    {
        if (char.IsDigit(str[0]))
            return false;
        foreach (char c in str)
        {
            if (!char.IsLower(c) && !char.IsDigit(c) || char.IsLetter(c) && !IsLatin(c))
                return false;
        }
        return true;
    }
}