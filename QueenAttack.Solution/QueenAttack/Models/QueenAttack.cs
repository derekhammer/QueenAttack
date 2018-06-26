namespace QueenAttack
{
  public class Queen
  {
    public bool QueenPlace(int inputQueenX, int inputQueenY)
    {
      return true;
    }
    public bool QueenPlace(char inputQueenX, char inputQueenY)
    {
      if(!char.IsNumber(inputQueenX) == true || !char.IsNumber(inputQueenY) == true)
      {
        return false;
      }
      else
      {
        return true;
      }
    }
    public bool UserPlace()
    {
      return false;
    }
    public bool CanAttack()
    {
      return false;
    }
  }
}
