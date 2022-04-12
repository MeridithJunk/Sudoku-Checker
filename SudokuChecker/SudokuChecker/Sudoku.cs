namespace SudokuChecker;

public class Sudoku
{
    public bool Checker(int[,] sudoku)
    {
        var result = true;
        for(var row = 0; row <= 8; row++)
        {
            var rowChecker = new HashSet<int>();
            for (var column = 0; column <= 8; column++)
            {
                var number = sudoku[row, column];
                rowChecker.Add(number);
            }

            if (rowChecker.Count != 9)
            {
                result = false;
            }
        }

        return result;
    }
}