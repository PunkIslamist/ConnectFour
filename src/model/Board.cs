namespace ConnectFour
{
  using System;
  using System.Collections.Generic;
  using System.Linq;

  public class Board
  {
    private const int rowCount = 6;
    private const int columnCount = 7;

    public Board()
    {
      this.Fields = Enumerable.Range(0, rowCount * columnCount)
          .Select(it => 'O');
    }

    public Board(IEnumerable<char> fields)
    {
      this.Fields = fields;
    }

    public static char EmptyField { get => 'O'; }
    public IEnumerable<char> Fields { get; }
    public IEnumerable<IEnumerable<char>> Rows { get; }
    public IEnumerable<IEnumerable<char>> Columns { get; }

    public Board MakeMove(int column, char symbol)
    {
      var firstColumn = Enumerable.Range(0, rowCount - 1)
        .Select(it => EmptyField)
        .Append(symbol);
      var remainingColumns = this.Columns.Skip(1);

      var allFields = remainingColumns.Prepend(firstColumn)
        .SelectMany(it => it);

      return new Board(allFields);
    }
  }
}