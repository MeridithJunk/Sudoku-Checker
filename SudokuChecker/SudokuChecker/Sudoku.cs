namespace SudokuChecker;

public class Sudoku
{
    public bool Checker(int[,] sudoku)
    {
        return HorizontalRowChecker(sudoku);
    }

    private static bool HorizontalRowChecker(int[,] sudoku)
    {
        var result = true;
        for (var row = 0; row <= 8; row++)
        {
            var verticalRowChecker = new HashSet<int>();
            var horizontalRowChecker = new HashSet<int>();
            for (var column = 0; column <= 8; column++)
            {
                var number = sudoku[row, column];
                horizontalRowChecker.Add(number);
                
                var verticalNumber = sudoku[column, row];
                verticalRowChecker.Add(verticalNumber);
            }

            if (horizontalRowChecker.Count != 9 || verticalRowChecker.Count != 9)
            {
                result = false;
            }
        }

        return result;
    }
}