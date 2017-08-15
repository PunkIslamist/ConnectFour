namespace ConnectFour.Test
{
  using System;
  using System.Linq;
  using ConnectFour.Extensions.Array;
  using Xunit;

  public class BoardTest
  {
    [Fact]
    public void Constructor_Default_ReturnsEmptyBoard()
    {
      var board = new Board();

      Assert.True(board.Count() == 42);
    }
  }
}
