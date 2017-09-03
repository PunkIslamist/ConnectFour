namespace ConnectFour.Model
{
  using System;
  using System.Collections.Generic;
  using System.Linq;

  public class Board
  {
    private const int rows = 6;
    private const int columns = 7;
    private Player[,] fields = new Player[columns, rows];

    public Board()
    {
      for (int col = 0; col < columns; ++col)
      {
        for (int row = 0; row < rows; ++row)
        {
          this.fields[col, row] = Board.EmptyField;
        }
      }
    }

    public IEnumerable<IEnumerable<Player>> Columns => this.GetColumns();
    public static Player EmptyField { get; } = new Player('_');
    public static Player Player1 { get; } = new Player('X');
    public static Player Player2 { get; } = new Player('O');

    private IEnumerable<IEnumerable<Player>> GetColumns()
    {
      for (int col = 0; col < columns; ++col)
      {
        var column = new Player[rows];

        for (int row = 0; row < rows; ++row)
        {
          column[row] = this.fields[col, row];
        }
        yield return column;
      }
    }

    public void MakeMove(Player player, int column)
    {
      var freeField = 0;

      while (this.fields[column, freeField] != Board.EmptyField)
      {
        ++freeField;
      }

      this.fields[column, freeField] = player;
    }
  }
}