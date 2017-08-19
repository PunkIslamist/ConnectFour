namespace ConnectFour.Model
{
  using System;
  using System.Collections.Generic;
  using System.Linq;

  public class Board
  {
    private const int rowCount = 6;
    private const int columnCount = 7;
    private char[,] fields = new char[columnCount, rowCount];

    public Board()
    {
      for (int col = 0; col < columnCount; ++col)
      {
        for (int row = 0; row < rowCount; ++row)
        {
          this.fields[col, row] = this.EmptyField;
        }
      }
    }

    public IEnumerable<IEnumerable<char>> Columns
    {
      get
      {
        for (int col = 0; col < columnCount; ++col)
        {
          var column = new char[rowCount];

          for (int row = 0; row < rowCount; ++row)
          {
            column[row] = this.fields[col, row];
          }
          yield return column;
        }
      }
    }

    public char EmptyField { get; } = '_';
  }
}