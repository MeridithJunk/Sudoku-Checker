namespace SudokuCheckerTests;
using NUnit.Framework;
using SudokuChecker;

public class Tests
{
    private Sudoku _sut;
    
    [SetUp]
    public void Setup()
    {
        _sut = new Sudoku();
    }

    [Test]
    public void GivenChecker_WhenIInitialize_ThenIReceiveTrue()
    {
        var actual = _sut.Checker();
        Assert.AreEqual(true, actual);
    }
}