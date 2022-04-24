using System;
using System.IO;

namespace MarRover2
{
    class Program
    {
        static void Main()
        {
            var Rover = new MarsRover();
            var Platue = new Platue();
            var content = File.ReadAllLines("Content.txt");
            int k = 1;
            Platue.Boundaries = content[0];
            Platue.StrSplit();
            while (k < content.Length)
            {
                Rover.GetInfo(content[k]);
                k++;
            }
        }
    }
}
