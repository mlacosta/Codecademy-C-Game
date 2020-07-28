using System;

namespace ConsoleGame
{
  class Game : SuperGame
  {
    public new static void UpdatePosition(string key,out int xChange, out int yChange)
        {
            switch (key)
            {
                case "DownArrow":
                    yChange = 1;
                    xChange = 0;
                    break;
                case "LeftArrow":
                    yChange = 0;
                    xChange = -1;
                    break;
                case "UpArrow":
                    yChange = -1;
                    xChange = 0;
                    break;
                case "RightArrow":
                    yChange = 0;
                    xChange = 1;
                    break;
                default:
                    yChange = 0;
                    xChange = 0;
                    break;

            }


        }
    public new static char UpdateCursor(string key)
        {
            switch (key)
            {
                case "DownArrow":
                    return 'v';
                    break;
                case "LeftArrow":
                    return '<';
                    break;
                case "UpArrow":
                    return '^';
                    break;
                case "RightArrow":
                    return '>';
                    break;
                default:
                    return '<';
                    break;

            }
        }
    public new static int KeepInBounds(int coor, int maxValue)
        {
            if (coor < 0)
            {
                return 0;
            }else if (coor >= maxValue) 
            {
                return maxValue - 1;
            }
            else
            {
                return coor;
            }
            
        }

    public new static bool DidScore(int xChar, int yChar, int xFruit ,int yFruit)
        {
            if (xChar == xFruit && yChar == yFruit)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
  }
}