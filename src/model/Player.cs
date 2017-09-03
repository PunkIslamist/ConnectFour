using System;

namespace ConnectFour.Model
{
  public class Player : IEquatable<Player>
  {
    public static Player EmptyField => new Player('_');
    public static Player Player1 => new Player('x');
    public static Player Player2 => new Player('o');

    public char Sign { get; }

    private Player(char sign)
    {
      this.Sign = sign;
    }

    public bool Equals(Player other)
    {
      return this.Sign == other.Sign;
    }
  }
}