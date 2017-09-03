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

    public IEnumerable<Column> Columns => this.GetColumns();
    public IEnumerable<Row> Rows => this.GetRows();
    public IEnumerable<Move> PossibleMoves => this.CalculatePossibleMoves();

    public Board()
    {
      for (int col = 0; col < Board.columns; ++col)
      {
        for (int row = 0; row < Board.rows; ++row)
        {
          this.fields[col, row] = Player.EmptyField;
        }
      }
    }

    public void Make(Move move)
    {
      throw new NotImplementedException();
    }

    private IEnumerable<Row> GetRows()
    {
      for (int nr = 0; nr < Board.rows; ++nr)
      {
        var row = new Row(nr);

        yield return row;
      }
    }

    private IEnumerable<Column> GetColumns()
    {
      for (int col = 0; col < columns; ++col)
      {
        var column = new Column(col);

        yield return column;
      }
    }

    private IEnumerable<Move> CalculatePossibleMoves()
    {
      return this.Columns
       .Where(it => it.IsEmpty)
       .Select(it => new Move(Player.Player1, it));
    }
  }
}