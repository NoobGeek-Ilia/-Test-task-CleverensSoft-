// Также можно было бы добавить возмжность ввода с разных утсройств
// в таком случае я бы создал абстрактный слой в виде интерфейса IInput (можно манипулировать в дальнейшем)
// и классы ввода для разных типов

var original = "aaabbcccdde";
var compressResult = Compression.Compress(original);
var decompressResult = Compression.Decompress(compressResult);
Console.WriteLine(compressResult);
Console.WriteLine(decompressResult);