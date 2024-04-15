using System.Text;

static class Compression
{
    // 0. Нет смысла в экземплярах, поэтому класс статический
    // 1. Разделил логику для операций
    // 2. Compress и Decompress используют StringBuilder для построения строк,
    // что делает их более эффективными по сравнению с использованием операции конкатенации строк.
    // 3. При некорректном вводе ловим ошибку

    public static string Compress(string? input)
    {
        if (!InputValidation.IsValidCompressedString(input))
            throw new ArgumentException("Invalid compressed string format!", nameof(input));

        var compressed = new StringBuilder();
        var currentChar = input[0];
        var count = 1;

        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] == currentChar)
            {
                count++;
            }
            else
            {
                compressed.Append(count > 1 ? $"{currentChar}{count}" : $"{currentChar}");
                currentChar = input[i];
                count = 1;
            }
        }

        compressed.Append(count > 1 ? $"{currentChar}{count}" : $"{currentChar}");
        return compressed.ToString();
    }

    public static string Decompress(string? input)
    {
        if (!InputValidation.IsValidDecompressedString(input))
            throw new ArgumentException("Invalid decompressed string format!", nameof(input));

        var decompressed = new StringBuilder();
        var index = 0;

        while (index < input.Length)
        {
            var currentChar = input[index];
            index++;

            if (index < input.Length && char.IsDigit(input[index]))
            {
                var count = int.Parse(input[index].ToString());
                index++;

                for (int i = 0; i < count; i++)
                {
                    decompressed.Append(currentChar);
                }
            }
            else
            {
                decompressed.Append(currentChar);
            }
        }
        return decompressed.ToString();
    }
}
