namespace SudokuChecker;

public class Sudoku
{
    public bool Checker(int[,] sudoku)
    {
        var result = true;
        for(var row = 0; row <= 8; row++)
        {
            var horizontalRowChecker = new HashSet<int>();
            for (var column = 0; column <= 8; column++)
            {
                var number = sudoku[row, column];
                horizontalRowChecker.Add(number);
            }

            if (horizontalRowChecker.Count != 9)
            {
                result = false;
            }
        }

        return result;
    }
}