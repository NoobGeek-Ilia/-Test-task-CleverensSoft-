class SpiralTraverse
{
    public static int[] SpiralOrder(int[,] matrix)
    {
        var rows = matrix.GetLength(0);
        var cols = matrix.GetLength(1);
        var totalElements = rows * cols;
        int[] result = new int[totalElements];

        var index = 0;
        int top = 0, bottom = rows - 1, left = 0, right = cols - 1;

        while (index < totalElements)
        {
            for (int i = top; i <= bottom && index < totalElements; i++)
                result[index++] = matrix[i, left];
            left++;

            for (int i = left; i <= right && index < totalElements; i++)
                result[index++] = matrix[bottom, i];
            bottom--;

            for (int i = bottom; i >= top && index < totalElements; i--)
                result[index++] = matrix[i, right];
            right--;

            for (int i = right; i >= left && index < totalElements; i--)
                result[index++] = matrix[top, i];
            top++;
        }

        return result;
    }
}