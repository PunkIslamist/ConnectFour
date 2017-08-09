namespace ConnectFour.Test
{
  using System;
  using System.Linq;
  using Xunit;

  public class BoardTest
  {
    private const int defaultRows = 6;
    private const int defaultColumns = 7;

    [Fact]
    public void Test1()
    {
      var board = this.CreateDefaultBoard();

      Field[,] expected = new Field[defaultColumns, defaultRows];
      var actual = board.Fields;

      Assert.Equal(expected, actual);
    }

    private Board CreateDefaultBoard()
    {
      return new Board(defaultRows, defaultColumns);
    }
  }
}
