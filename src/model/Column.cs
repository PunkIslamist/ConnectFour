using System;
using System.Collections;
using System.Collections.Generic;

namespace ConnectFour.Model
{
  public class Column : IEnumerable<Player>
  {
    public int Number { get; }
    public IEnumerable<Player> Fields { get; }


    public Player this[int i]
    {
      get { return Player.EmptyField; }
    }

    public Column(int number)
    {
      this.Number = number;
    }

    public Column(int number, IEnumerable<Player> fields)
    {
      this.Number = number;
      this.Fields = fields;
    }

    public IEnumerator<Player> GetEnumerator()
    {
      return this.Fields.GetEnumerator();
      throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return this.GetEnumerator();
    }
  }
}