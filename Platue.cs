using System;
using System.Collections.Generic;
using System.Text;

namespace MarRover2
{
    class Platue
    {
        public int YBoundary { get; set; }
        public int XBoundary { get; set; }
        public string Boundaries { get; set; }
        public void StrSplit()
        {
            var Bound = Boundaries.Split(" ");
            YBoundary = Convert.ToInt32(Bound[1]);
            XBoundary = Convert.ToInt32(Bound[0]);
        }

        public Platue(string boundries)
        {

            var bound = boundries.Split(" ");
            YBoundary = Convert.ToInt32(bound[1]);
            XBoundary = Convert.ToInt32(bound[0]);
        }
    }
}
