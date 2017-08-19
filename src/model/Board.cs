namespace ConnectFour.Model
{
  using System;
  using System.Collections.Generic;
  using System.Linq;

  public class Board
  {
    private const int rows = 6;
    private const int columns = 7;
    private char[,] fields = new char[columns, rows];

    public Board()
    {
      for (int col = 0; col < columns; ++col)
      {
        for (int row = 0; row < rows; ++row)
        {
          this.fields[col, row] = this.EmptyField;
        }
      }
    }

    public IEnumerable<IEnumerable<char>> Columns => this.GetColumns();

    public char EmptyField { get; } = '_';

    private IEnumerable<IEnumerable<char>> GetColumns()
    {
      for (int col = 0; col < columns; ++col)
      {
        var column = new char[rows];

        for (int row = 0; row < rows; ++row)
        {
          column[row] = this.fields[col, row];
        }
        yield return column;
      }
    }
  }
}