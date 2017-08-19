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

      Assert.True(actual.All(it => it == board.EmptyField));
    }
  }
}
