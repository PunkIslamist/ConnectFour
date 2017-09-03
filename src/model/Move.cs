namespace ConnectFour.Model
{
  public class Move
  {
    public Move(Player movingPlayer, int playedColumn)
    {
      this.MovingPlayer = movingPlayer;
      this.PlayedColumn = playedColumn;
    }

    public Player MovingPlayer { get; }
    public int PlayedColumn { get; }
  }
}