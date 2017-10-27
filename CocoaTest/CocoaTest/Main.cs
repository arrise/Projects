using AppKit;
using System;

namespace CocoaTest
{
    class Player
    {
        //player name
        public string playerName;

        //player score
        public int score = 0;

        //players X and Y coordinates
        public int playerX = 0;
        public int playerY = 0;

    }

    public class Room
    {
        //room name
        private string name;

        //room description
        private string des;

        //room X and Y coordinates
        private int X;
        private int Y;

        public Room(string roomName, string roomDes, int roomX, int roomY)
        {
            name = roomName;
            des = roomDes;
            X = roomX;
            Y = roomY;
        }

    }

    class Program
    {

        public static void Main(string[] args)
        {
            Player player1 = new Player();
            Room room1 = new Room("Lobby", "A Hotel Lobby", 0, 0);

            Console.Write("Enter your name: ");
            player1.playerName = Console.ReadLine();

            Console.WriteLine("Welcome " + player1.playerName);

            player1.score = 1;

            while (player1.score < 10)
            {

                if (player1.playerX == room1.roomX && player1.playerY == room1.roomY)
                {
                    Console.WriteLine("test success");
                }

                Console.ReadKey();
            }
        }
    }
}
