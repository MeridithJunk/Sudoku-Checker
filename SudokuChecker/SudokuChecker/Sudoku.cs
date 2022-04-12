namespace SudokuChecker;

public class Sudoku
{
    public bool Checker(int[,] sudoku)
    {
        var verticalResult = VerticalRowChecker(sudoku);
        var horizontalResult = HorizontalRowChecker(sudoku);

        return verticalResult && horizontalResult;
    }

    private bool VerticalRowChecker(int[,] sudoku)
    {
        var result = true;
        for (var column = 0; column <= 8; column++)
        {
            var verticalRowChecker = new HashSet<int>(); 
            for(var row = 0; row <= 8; row++)
            {
                var number = sudoku[row, column];
                verticalRowChecker.Add(number);
            }
            
            if (verticalRowChecker.Count != 9)
            {
                result = false;
            }
        }

        return result;
    }

    private static bool HorizontalRowChecker(int[,] sudoku)
    {
        var result = true;
        for (var row = 0; row <= 8; row++)
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