namespace ConnectFour.Model
{
  public class Move
  {
    public Move(Player movingPlayer, Column playedColumn)
    {
      this.MovingPlayer = movingPlayer;
      this.PlayedColumn = playedColumn;
    }

    public Player MovingPlayer { get; }
    public Column PlayedColumn { get; }
  }
}