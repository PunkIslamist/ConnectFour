using System.Collections.Generic;

namespace ConnectFour.Model
{
  public class Row : BoardLine
  {
    protected override int Size => 7;
    public Row(int number) : base(number) { }
    public Row(int number, IEnumerable<Player> fields) : base(number, fields) { }
  }
}