using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MarRover2
{
    class Program
    {
        static void Main()
        {
            var rovers = new List<MarsRover>();
            var content = File.ReadAllLines("Content.txt");
            var platue = new Platue(content[0]);
            foreach(var line in content.Skip(1))
            {
                if (line[0] >= '0' && line[0] <= '9')
                {
                    rovers.Add(new MarsRover(line));

                }
                else if (line[0] >= 'A' && line[0] <= 'Z')
                {
                    var rover = rovers.Last();
                    rover.Move(line);

                    Console.WriteLine(rover.X + " " + rover.Y + " " + rover.Z);
                }
            }
        }
    }
}
