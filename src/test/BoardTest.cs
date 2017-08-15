namespace ConnectFour.Test
{
  using System;
  using System.Linq;
  using ConnectFour.Extensions.Array;
  using Xunit;

  public class BoardTest
  {
    private const char p1 = 'X';
    private const char p2 = 'T';
    private const int rowCount = 6;
    private const int columnCount = 7;

    [Fact]
    public void Constructor_Default_ReturnsEmptyBoard()
    {
      var board = this.CreateBoard();
      var expected = Enumerable.Range(0, rowCount * columnCount)
        .Select(it => Board.EmptyField);

      var actual = board.Fields;

      Assert.Equal(expected, actual);
    }

    [Fact]
    public void MakeMove_XInFirstColumn_FieldBottomLeftIsX()
    {
      var board = this.CreateBoard();

      var actual = board.MakeMove(column: 0, symbol: p1);

      Assert.Equal(actual.Columns.First().Last(), p1);
      Assert.Equal(columnCount * rowCount - 1, actual.Fields.Count());
    }

    private Board CreateBoard()
    {
      return new Board();
    }
  }
}
