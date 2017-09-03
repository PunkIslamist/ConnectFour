using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConnectFour.Model
{
  public class Column : BoardLine
  {
    public Column(int number) : base(number) { }
    public Column(int number, IEnumerable<Player> fields) : base(number, fields) { }

    protected override int Size { get { return 7; } }
  }
}