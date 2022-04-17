namespace SudokuChecker;

public class Sudoku
{
    public bool Checker(int[,] sudoku)
    {
        return blockChecker(sudoku) && RowChecker(sudoku);
    }

    private bool blockChecker(int[,] sudoku)
    {
        var boxOne = IndividualBlockChecker(sudoku, 0,2,0,2);
        var boxTwo = IndividualBlockChecker(sudoku, 0,2,3,5);
        var boxThree = IndividualBlockChecker(sudoku, 0,2,6,8);
        var boxFour = IndividualBlockChecker(sudoku, 3,5,0,2);
        var boxFive = IndividualBlockChecker(sudoku, 3,5,3,5);
        var boxSix = IndividualBlockChecker(sudoku, 3,5,6,8);
        var boxSeven = IndividualBlockChecker(sudoku, 6,8,0,2);
        var boxEight = IndividualBlockChecker(sudoku, 6,8,3,5);
        var boxNine = IndividualBlockChecker(sudoku, 6,8,6,8);
        return boxOne && boxTwo && boxThree 
               && boxFour && boxFive && boxSix
               && boxSeven && boxEight && boxNine;
    }

    private static bool IndividualBlockChecker(int[,] sudoku, int rowsStart, int rowEnd, int colStart, int colEnd)
    {
        var result = true;
        var blockChecker = new HashSet<int>();
        for (var row = rowsStart; row <= rowEnd; row++)
        {
            for (var column = colStart; column <= colEnd; column++)
            {
                var number = sudoku[row, column];
                blockChecker.Add(number);
            }
        }

        if (blockChecker.Count != 9)
        {
            result = false;
        }

        return result;
    }

    private static bool RowChecker(int[,] sudoku)
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