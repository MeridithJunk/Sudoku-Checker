using NUnit.Framework;
using SudokuChecker;

namespace SudokuCheckerTests;

public class Tests
{
    private Sudoku _sut;

    private int[,] validSudoku =   {
        {1, 3, 2, 5, 4, 6, 8, 7, 9},
        {4, 5, 9, 7, 1, 8, 3, 2, 6},
        {7, 8, 6, 9, 2, 3, 4, 1, 5},
        {9, 4, 8, 6, 7, 1, 2, 5, 3},
        {3, 6, 1, 8, 5, 2, 7, 9, 4},
        {2, 7, 5, 4, 3, 9, 1, 6, 8},
        {8, 9, 4, 2, 6, 7, 5, 3, 1},
        {6, 1, 7, 3, 8, 5, 9, 4, 2},
        {5, 2, 3, 1, 9, 4, 6, 8, 7}
    };
    private int[,] invalidSudoku =
    {
        {1, 2, 3, 4, 5, 6, 7, 8, 9},
        {1, 3, 4, 5, 6, 7, 8, 9, 2},
        {3, 4, 5, 6, 7, 8, 9, 1, 2},
        {4, 5, 6, 7, 8, 9, 1, 2, 3},
        {5, 6, 7, 8, 9, 1, 2, 3, 4},
        {6, 7, 8, 9, 1, 2, 3, 4, 5},
        {7, 8, 9, 1, 2, 3, 4, 5, 6},
        {8, 9, 1, 2, 3, 4, 5, 6, 7},
        {9, 1, 2, 3, 4, 5, 6, 7, 8},
    };

[SetUp]
    public void Setup()
    {
        _sut = new Sudoku();
    }

    [Test]
    public void GivenChecker_WhenIPassValidSudoku_ThenIReceiveTrue()
    {
        var actual = _sut.Checker(validSudoku);
        Assert.AreEqual(true, actual);
    }
    
    [Test]
    public void GivenChecker_WhenIPassInvalidSudoku_ThenIReceiveFalse()
    {
        var actual = _sut.Checker(invalidSudoku);
        Assert.AreEqual(false, actual);
    }
}
