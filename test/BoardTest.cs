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

      var actual = board.Columns.All(it => it.IsEmpty);

      Assert.True(actual);
    }

    [Fact]
    public void PossibleMoves_EmptyBoard_AllColumnsForPlayer1()
    {
      var board = new Board();
      var expectedNumbers = Enumerable.Range(1, board.Columns.Count());

      var actual = board.PossibleMoves
        .Select(it => it.PlayedColumn.Number);

      Assert.True(
        actual.All(
          it => expectedNumbers.Contains(it)));
    }

    [Fact]
    public void MakeMove_EmptyBoard_FirstRowOfColumnIsSet()
    {
      var board = new Board();
      var move = new Move(Player.Player1, board.Columns.First());
      board.Make(move);

      Assert.True(board.Columns.First()[0] == Player.Player1);
    }

    [Fact]
    public void MakeMove_Repeatedly_ColumnIsFilledWithNPlayers()
    {
      throw new NotImplementedException();
    }
  }
}