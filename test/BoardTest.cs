namespace ConnectFour.Test
{
  using System;
  using System.Linq;
  using ConnectFour.Model;
  using Xunit;

  public class BoardTest
  {
    [Fact]
    public void CreateBoard_DefaultConstructor_6Rows7Columns()
    {
      var board = new Board();

      var rowCount = board.Rows.Count();
      var columnCount = board.Columns.Count();

      Assert.True(rowCount == 6);
      Assert.True(columnCount == 7);
    }

    [Fact]
    public void CreateBoard_DefaultConstructor_AllColumnsEmpty()
    {
      var board = new Board();

      var actual = board.Columns.All(it => !it.Any());
      Assert.True(actual);
    }

    [Fact]
    public void PossibleMoves_EmptyBoard_AllColumnsForPlayer1()
    {
      var board = new Board();

      var actual = board.PossibleMoves;

      var expectedColumns = Enumerable.Range(1, board.Columns.Count());
      Assert.True(
        expectedColumns.All(
          column => actual.Any(move => move.PlayedColumn == column)));
    }

    [Fact]
    public void MakeMove_EmptyBoard_FirstRowOfColumnIsSet()
    {
      var board = new Board();
      var move = new Move(Player.Player1, playedColumn: 0);
      board.Make(move);

      Assert.True(board.Columns.First()[0] == Player.Player1);
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
        move = new Move(Player.Player1, columnAndCount);
        board.Make(move);
      }

      Assert.True(
        board.Columns
         .ElementAt(columnAndCount)
         .Take(columnAndCount)
         .All(it => it == Player.Player1));
    }
  }
}