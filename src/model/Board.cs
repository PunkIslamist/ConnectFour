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
          this.fields[col, row] = Player.EmptyField;
        }
      }
    }

    public IEnumerable<Column> Columns => this.GetColumns();
    public IEnumerable<Move> PossibleMoves => this.CalculatePossibleMoves();

    public IEnumerable<Row> Rows => this.GetRows();

    private IEnumerable<Row> GetRows()
    {
      for (int nr = 0; nr < rows; ++nr)
      {
        var row = new Row(nr);

        yield return row;
      }
    }

    private IEnumerable<Move> CalculatePossibleMoves()
    {
      throw new NotImplementedException();
    }

    private IEnumerable<Column> GetColumns()
    {
      for (int col = 0; col < columns; ++col)
      {
        var column = new Column(col);

        yield return column;
      }
    }

    public void Make(Move move)
    {
      var freeField = 0;

      while (this.fields[move.PlayedColumn, freeField] != Player.EmptyField)
      {
        ++freeField;
      }

      this.fields[move.PlayedColumn, freeField] = move.MovingPlayer;
    }
  }
}