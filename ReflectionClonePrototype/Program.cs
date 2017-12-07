using System;
using ReflectionClonePrototype.Models;

namespace ReflectionClonePrototype
{
    class Program
    {
        static void Main()
        {
            var player = new Player
            {
                Team = new Team
                {
                    Name = "Team1",
                    ClubColors = "Red"
                },
                Lastname = "Lastname",
                Age = 18,
                Firstname = "Firstname"
            };

            var newPlayer = player.Clone();
            if (ReferenceEquals(newPlayer, player))
            {
                Console.WriteLine("References are the same");
            }
            else
            {
                Console.WriteLine("References are not the same");
            }
            Console.ReadLine();
        }
    }
}
