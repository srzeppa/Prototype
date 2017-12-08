using System;
using DeepPrototype.Extension;
using DeepPrototype.Model;

namespace DeepPrototype
{
    class Program
    {
        static void Main()
        {

            var player = new Player
            {
                Team = new Team
                {
                    ClubColors = "Red",
                    Name = "Team1"
                },
                Age = 18,
                Firstname = "Marcin",
                Lastname = "Hallman"
            };

            var clonedPlayer1 = player.Clone();
            var clonedPlayer2 = player.DeepClone();

            Console.WriteLine("PLAYER1");
            if (ReferenceEquals(clonedPlayer1, player))
            {
                Console.WriteLine("Object reference to the same object");
            }
            else
            {
                Console.WriteLine("Object not reference to the same object");
            }

            Console.WriteLine("PLAYER2");
            if (ReferenceEquals(clonedPlayer2, player))
            {
                Console.WriteLine("Object reference to the same object");
            }
            else
            {
                Console.WriteLine("Object not reference to the same object");
            }

            Console.ReadLine();
        }
    }
}
