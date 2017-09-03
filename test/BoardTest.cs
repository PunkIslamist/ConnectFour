namespace ConnectFour.Test
{
  using System;
  using System.Linq;
  using ConnectFour.Model;
  using Xunit;

  public class BoardTest
  {
    [Fact]
    public void CreateBoard_DefaultConstructor_CountIs42()
    {
      var board = new Board();

      var actual = board.Columns.SelectMany(it => it);

      Assert.True(actual.Count() == 6 * 7);
    }

    [Fact]
    public void CreateBoard_DefaultConstructor_AllColumnsEmpty()
    {
      var board = new Board();

      var actual = board.Columns.SelectMany(it => it);

      Assert.True(actual.All(it => it == Board.EmptyField));
    }

    [Fact]
    public void MakeMove_EmptyBoard_FirstRowOfColumnIsSet()
    {
      var board = new Board();

      board.MakeMove(Board.Player1, column: 0);

      Assert.True(board.Columns.First().First() == Board.Player1);
    }

    [Theory,
    InlineData(1),
    InlineData(2),
    InlineData(3),
    InlineData(4),
    InlineData(5),
    InlineData(6)]
    public void MakeMove_Repeatedly_ColumnIsFilledWithNPlayers(int columnAndCount)
    {
      var board = new Board();

      for (int i = 0; i < columnAndCount; ++i)
      {
        board.MakeMove(Board.Player1, column: columnAndCount);
      }

      Assert.True(board.Columns
      .ElementAt(columnAndCount)
      .Take(columnAndCount)
      .All(it => it == Board.Player1));
    }
  }
}