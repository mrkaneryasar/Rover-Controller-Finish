using System;

public class RoverManager
{
    public static void MoveRover(ref int x, ref int y, ref char direction, int platoX, int platoY, string commands)
    {
        foreach (char command in commands)
        {
            try
            {
                if (command == 'L')
                {
                    //  sola döndür
                    direction = TurnLeft(direction);
                }
                else if (command == 'R')
                {
                    //  sağa döndür
                    direction = TurnRight(direction);
                }
                else if (command == 'M')
                {
                    ActionRover(ref x, ref y, direction, platoX, platoY);
                    // Rover'ı ileri hareket ettir
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
            }
        }
    }



    static char TurnLeft(char direction)
    {
        switch (direction)
        {
            case 'N':
                return 'W';
            case 'W':
                return 'S';
            case 'S':
                return 'E';
            case 'E':
                return 'N';
            default:
                return direction;
        }
    }

    static char TurnRight(char direction)
    {
        switch (direction)
        {
            case 'N':
                return 'E';
            case 'E':
                return 'S';
            case 'S':
                return 'W';
            case 'W':
                return 'N';
            default:
                return direction;
        }
    }

    static void ActionRover(ref int x, ref int y, char direction, int platoX, int platoY)
    {
        switch (direction)
        {
            case 'N':
                if (y < platoY)
                    y++;
                break;
            case 'E':
                if (x < platoX)
                    x++;
                break;
            case 'S':
                if (y > 0)
                    y--;
                break;
            case 'W':
                if (x > 0)
                    x--;
                break;
        }
    }


    // Diğer yardımcı methodları da bu sınıfa taşıyabilirsiniz.
}
