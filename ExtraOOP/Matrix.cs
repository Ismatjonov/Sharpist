namespace ExtraOOP;

public class Matrix
{
    int[,] numbers = new int[,] { { 1, 2, 4 }, { 2, 3, 6 }, { 3, 4, 8 } };

    public int this[int row, int col]
    {
        get => numbers[row, col];
        private set => numbers[row, col] = value;
    }
}