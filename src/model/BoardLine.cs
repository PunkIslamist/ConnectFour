using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConnectFour.Model
{
  public abstract class BoardLine : IEnumerable<Player>
  {
    protected abstract int Size { get; }
    public int Number { get; }
    public IEnumerable<Player> Fields { get; }
    public bool IsEmpty => this.All(it => it.Equals(Player.EmptyField));

    public Player this[int i]
    {
      get { return Player.EmptyField; }
    }

    public BoardLine(int number)
    {
      this.Number = number;
      this.Fields = Enumerable.Repeat(Player.EmptyField, this.Size);
    }

    public BoardLine(int number, IEnumerable<Player> fields)
    {
      this.Number = number;
      this.Fields = fields;
    }

    public IEnumerator<Player> GetEnumerator()
    {
      return this.Fields.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return this.GetEnumerator();
    }
  }
}