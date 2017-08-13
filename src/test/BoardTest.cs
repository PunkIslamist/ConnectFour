namespace ConnectFour.Test
{
  using System;
  using System.Linq;
  using ConnectFour.Extensions.Array;
  using Xunit;

  public class BoardTest
  {
    private const int rowCount = 6;
    private const int columnCount = 7;

    [Fact]
    public void Constructor_DefaultValues_ReturnsEmptyBoard()
    {
      var board = this.CreateDefaultBoard();
      var emptyRow = Enumerable.Range(0, columnCount)
        .Select(it => 'O');
      var expected = Enumerable.Range(0, rowCount)
        .Select(it => emptyRow);

      var actual = board.Fields;

      Assert.Equal(expected, actual);
    }

    private Board CreateDefaultBoard()
    {
      return new Board(rowCount, columnCount);
    }
  }
}
