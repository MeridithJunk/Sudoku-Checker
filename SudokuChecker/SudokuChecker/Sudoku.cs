namespace SudokuChecker;

public class Sudoku
{
    public bool Checker(int[] sudoku)
    {
        var set = new HashSet<int>(sudoku);
        return set.Count == 9;
    }
}