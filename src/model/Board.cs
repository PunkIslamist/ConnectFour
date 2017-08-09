namespace ConnectFour
{
  using System.Collections.Generic;

  public class Board
  {
    public Board(uint rows, uint columns)
    {

    }

    public IEnumerable<Field> Fields { get; }
  }
}