using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICloneablePrototype.Models;

namespace ICloneablePrototype
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

            var clonedPlayer = player.Clone();

        }
    }
}
