//проверку на валидацию не добавил за ненадобностью в данном задании

int[,] matrix1 = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
int[] result1 = SpiralTraverse.SpiralOrder(matrix1);
Console.WriteLine(string.Join(", ", result1));

int[,] matrix2 = new int[3, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
int[] result2 = SpiralTraverse.SpiralOrder(matrix2);
Console.WriteLine(string.Join(", ", result2));