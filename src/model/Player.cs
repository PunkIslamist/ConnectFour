using System;

namespace ConnectFour.Model
{
  public class Player : IEquatable<Player>
  {
    public char Sign { get; }

    public Player(char sign)
    {
      this.Sign = sign;
    }

    public bool Equals(Player other)
    {
      return this.Sign == other.Sign;
    }
  }
}