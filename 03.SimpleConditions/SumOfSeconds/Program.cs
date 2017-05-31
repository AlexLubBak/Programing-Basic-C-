using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfSeconds
{
    class Program
    {
        static void Main(string[] args)
        {

            int playerOne = int.Parse(Console.ReadLine());
            int playerTwo = int.Parse(Console.ReadLine());
            int playerThree = int.Parse(Console.ReadLine());

            int secondsOfPlayers = playerOne + playerTwo + playerThree;

            if (secondsOfPlayers<10)
            {
                Console.WriteLine($"0:0{secondsOfPlayers}");
            }
            else if (secondsOfPlayers>=10&&secondsOfPlayers<60)
            {
                Console.WriteLine($"0:{secondsOfPlayers}");
            }
            else if (secondsOfPlayers>=60&&secondsOfPlayers<70)
            {
                int secondOfPlayersTemp = secondsOfPlayers % 60;
                Console.WriteLine($"1:0{secondOfPlayersTemp}");
            }
            else if (secondsOfPlayers>=60&&secondsOfPlayers<120)
            {
                int secondOfPlayersTemp = secondsOfPlayers % 60;
                Console.WriteLine($"1:{secondOfPlayersTemp}");
            }
            else if (secondsOfPlayers>=120&&secondsOfPlayers<130)
            {
                int secondOfPlayersTemp = secondsOfPlayers % 60;
                Console.WriteLine($"2:0{secondOfPlayersTemp}");
            }
            else if (secondsOfPlayers>=130)
            {
                int secondOfPlayersTemp = secondsOfPlayers % 60;
                Console.WriteLine($"2:{secondOfPlayersTemp}");
            }


        }
    }
}
