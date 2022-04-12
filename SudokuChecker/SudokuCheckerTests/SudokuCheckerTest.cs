using NUnit.Framework;
using SudokuChecker;

namespace SudokuCheckerTests;

public class Tests
{
    private Sudoku _sut;

    private int[,] validSudoku =   {
        {1, 2, 3, 4, 5, 6, 7, 8, 9}, 
        {1, 2, 3, 4, 5, 6, 7, 8, 9},
        {1, 2, 3, 4, 5, 6, 7, 8, 9},
        {1, 2, 3, 4, 5, 6, 7, 8, 9},
        {1, 2, 3, 4, 5, 6, 7, 8, 9},
        {1, 2, 3, 4, 5, 6, 7, 8, 9},
        {1, 2, 3, 4, 5, 6, 7, 8, 9},
        {1, 2, 3, 4, 5, 6, 7, 8, 9},
        {1, 2, 3, 4, 5, 6, 7, 8, 9},
    };
    private int[,] invalidSudoku =
    {
        {1, 2, 3, 4, 9, 9, 9, 9, 9},
        {1, 2, 3, 4, 9, 9, 9, 9, 9},
        {1, 2, 3, 4, 9, 9, 9, 9, 9},
        {1, 2, 3, 4, 9, 9, 9, 9, 9},
        {1, 2, 3, 4, 9, 9, 9, 9, 9},
        {1, 2, 3, 4, 9, 9, 9, 9, 9},
        {1, 2, 3, 4, 9, 9, 9, 9, 9},
        {1, 2, 3, 4, 9, 9, 9, 9, 9},
        {1, 2, 3, 4, 9, 9, 9, 9, 9},
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
