using System;

namespace Text
{
    class Player
    {
        //player name
        public string playerName;

        //player score
        public int score = 0;

        //players location
        public int playerLocation = 0;

    }

    public class Room
    {
        //room name
        string name;

        //room description
        string des;

        //room coordinate
        int number;

        public Room(string roomName, string roomDes, int roomNumber)
        {
            name = roomName;
            des = roomDes;
            number = roomNumber;
        }

    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Player player1 = new Player();

            int roomChoice = 0;

            string intro = "You wake up sprawled on the floor, your mind hazy. You find yourself in: ";

            //rooms
            Room room0 = new Room("Lobby", "A hotel lobby, the floors are covered with a faded red carpet and the off white paint on the walls is peeling. To the West are 2 Elevators. To the North is a heavy Wooden Door. On the East wall is a generic Painting of a sailboat.", 0);
            Room room1 = new Room("Cafe", "The Cafe", 1);

            //getting player name
            Console.WriteLine("Enter your name: ");
            player1.playerName = Console.ReadLine();
            //welcome
            Console.WriteLine("Welcome to the Game!" + player1.playerName);

            //select room
            switch (roomChoice)
            {
                case 0:
                    player1.playerLocation = 0;
                    Console.WriteLine(intro + room0.des);
                    break;

                case 1:
                    player1.playerLocation = 1;
                    break;

            }



        }
    }
}
