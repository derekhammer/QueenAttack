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

    public bool UserPlace(int inputUserX, int inputUserY)
    {
      return true;
    }

    public bool UserPlace(char inputUserX, char inputUserY)
    {
      if(!char.IsNumber(inputUserX) == true || !char.IsNumber(inputUserY) == true)
      {
        return false;
      }
      else
      {
        return true;
      }
    }

    public bool PlacementCheckRange(int inputX, int inputY)
    {
      if(inputX > 8 || inputX < 1)
      {
        return false;
      }
      else if(inputY > 8 || inputY < 1)
      {
        return false;
      }
      else
      {
        return true;
      }
    }
    public bool PlacementCheckStack(int queenX, int queenY, int userX, int userY)
    {
        if(queenX == userX && queenY == userY)
        {
            return false;
        }
        else
        {
          return true;
        }
    }
    public bool CanAttack(int queenX, int queenY, int userX, int userY)
    {
      
      return false;
    }
  }
}
