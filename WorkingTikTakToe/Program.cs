using System.Diagnostics.Metrics;
using System.Reflection;

internal class TicTacToe
{
    public static char[] fieldArray = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };

    static int counter = 1;
    static void Main(string[] args)
    {
        Console.WriteLine("START GAME");
        DrawField();

        Console.WriteLine();
        EnterYourPosition();


        SetOption();

        Console.WriteLine();

        Console.ReadKey();
    }

    static void DrawField()
    {
        Console.WriteLine("\t");
        Console.WriteLine("\t     |     |     ");
        Console.WriteLine("\t  {0}  |  {1}  |  {2}  ", fieldArray[0], fieldArray[1], fieldArray[2]);
        Console.WriteLine("\t_____|_____|_____");
        Console.WriteLine("\t     |     |     ");
        Console.WriteLine("\t  {0}  |  {1}  |  {2}  ", fieldArray[3], fieldArray[4], fieldArray[5]);
        Console.WriteLine("\t_____|_____|_____");
        Console.WriteLine("\t     |     |     ");
        Console.WriteLine("\t  {0}  |  {1}  |  {2}  ", fieldArray[6], fieldArray[7], fieldArray[8]);
        Console.WriteLine("\t     |     |     ");
    }

    static void EnterYourPosition()
    {
        int getPositionNumber;

        do
        {
            Console.WriteLine("Please Enter Number from 0 to 9");

            getPositionNumber = Int32.Parse(Console.ReadLine());

            if (getPositionNumber >= 0 && getPositionNumber <= 9)
            {
                fieldArray[getPositionNumber] = 'O';
                counter++;
            }
            else
            {
                fieldArray[getPositionNumber] = 'O';
                counter++;
            };

            Console.Clear();

            DrawField();

        } while (counter <= 9);
    }
    static void SetOption()
    {
        switch (CheckWin())
        {
            case 1:
                Console.WriteLine("P1 Winning Combination");

                break;
            case 2:
                Console.WriteLine("P2 Winning Combination");

                break;

            default:

                Console.WriteLine("Draw Combination");
                break;
        }

        static int CheckWin()
        {
            //Horzontal
            if ((fieldArray[0] == 'X' && fieldArray[1] == 'X' && fieldArray[2] == 'X') ||
                (fieldArray[3] == 'X' && fieldArray[4] == 'X' && fieldArray[5] == 'X') ||
                (fieldArray[6] == 'X' && fieldArray[7] == 'X' && fieldArray[8] == 'X'))
            {
                return 1;
            }

            else if ((fieldArray[0] == 'O' && fieldArray[1] == 'O' && fieldArray[2] == 'O') ||
                     (fieldArray[3] == 'O' && fieldArray[4] == 'O' && fieldArray[5] == 'O') ||
                     (fieldArray[6] == 'O' && fieldArray[7] == 'O' && fieldArray[8] == 'O'))
            {
                return 2;
            }

            //Vertical

            else if ((fieldArray[0] == 'X' && fieldArray[3] == 'X' && fieldArray[6] == 'X') ||
                     (fieldArray[1] == 'X' && fieldArray[4] == 'X' && fieldArray[7] == 'X') ||
                     (fieldArray[2] == 'X' && fieldArray[5] == 'X' && fieldArray[8] == 'X'))
            {
                return 1;
            }
            else if ((fieldArray[0] == 'O' && fieldArray[3] == 'O' && fieldArray[6] == 'O') ||
                     (fieldArray[1] == 'O' && fieldArray[4] == 'O' && fieldArray[7] == 'O') ||
                     (fieldArray[2] == 'O' && fieldArray[5] == 'O' && fieldArray[8] == 'O'))
            {
                return 2;
            }

            //Diagonal
            else if ((fieldArray[0] == 'X' && fieldArray[4] == 'X' && fieldArray[8] == 'X') ||
                     (fieldArray[2] == 'X' && fieldArray[4] == 'X' && fieldArray[6] == 'X'))
            {
                return 1;
            }
            else if ((fieldArray[0] == 'O' && fieldArray[4] == 'O' && fieldArray[8] == 'O') ||
                     (fieldArray[2] == 'O' && fieldArray[4] == 'O' && fieldArray[6] == 'O'))
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }
    }

}
