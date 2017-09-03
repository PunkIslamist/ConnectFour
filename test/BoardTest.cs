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
      var move = new Move(Board.Player1, playedColumn: 0);
      board.Make(move);

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
      Move move;

      for (int i = 0; i < columnAndCount; ++i)
      {
        move = new Move(Board.Player1, columnAndCount);
        board.Make(move);
      }

      Assert.True(board.Columns
      .ElementAt(columnAndCount)
      .Take(columnAndCount)
      .All(it => it == Board.Player1));
    }
  }
}