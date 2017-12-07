using System;
using DeepPrototype.Extension;
using ReflectionClonePrototype.Models;

namespace PrototypeTests
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("100 objects");
            Test(100);
            Console.WriteLine("10000 objects");
            Test(10000);
            Console.WriteLine("1000000 objects");
            Test(1000000);
            Console.ReadLine();
        }

        public static void Test(int count)
        {
            var reflection = new Player
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

            var timer = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < count; i++)
            {
                var test = reflection.Clone();
            }
            timer.Stop();
            var reflectionTimer = timer.ElapsedMilliseconds;

            var iCloneablePlayer = new ICloneablePrototype.Models.Player
            {
                Team = new ICloneablePrototype.Models.Team
                {
                    Name = "Team1",
                    ClubColors = "Red"
                },
                Lastname = "Lastname",
                Age = 18,
                Firstname = "Firstname"
            };

            timer = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < count; i++)
            {
                var test = iCloneablePlayer.Clone();
            }
            timer.Stop();
            var iCloneableTimer = timer.ElapsedMilliseconds;

            var deepPlayer = new DeepPrototype.Model.Player
            {
                Team = new DeepPrototype.Model.Team
                {
                    Name = "Team1",
                    ClubColors = "Red"
                },
                Lastname = "Lastname",
                Age = 18,
                Firstname = "Firstname"
            };

            timer = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < count; i++)
            {
                var test = deepPlayer.DeepClone();
            }
            timer.Stop();
            var deepTimer = timer.ElapsedMilliseconds;

             Console.WriteLine($"Reflection: {reflectionTimer}");
             Console.WriteLine($"iCloneableTimer: {iCloneableTimer}");
             Console.WriteLine($"deep: {deepTimer}");
        }
    }
}
