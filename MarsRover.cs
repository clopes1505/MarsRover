using System;

namespace MarRover2
{
    public class MarsRover
    {
        public MarsRover(string info)
        {
            GetInfo(info);
        }

        public int Y { get; set; }
        public Directions Z { get; set; }
        public int X { get; set; }

        private void GetInfo(string info)
        {
            var coord = info;
            var str = coord.Split(" ");
            X = Convert.ToInt32(str[0]);
            Y = Convert.ToInt32(str[1]);
            Z = (Directions)Enum.Parse(typeof(Directions), str[2][0].ToString());
        }
        public void Move(string instructions)
        {
            foreach (var instruction in instructions)
            {
                switch (instruction)
                {
                    case 'L':
                        TurnLeft();
                        break;
                    case 'R':
                        TurnRight();
                        break;
                    case 'M':
                        MoveForward();
                        break;
                }
            }
        }
        public void TurnLeft()
        {
            switch (Z)
            {
                case Directions.N:
                    Z--;
                    break;
                case Directions.E:
                    Z--;
                    break;
                case Directions.S:
                    Z--;
                    break;
                case Directions.W:
                    Z = Directions.S;
                    break;
            }
        }
        public void TurnRight()
        {
            switch (Z)
            {
                case Directions.N:
                    Z++;
                    break;
                case Directions.E:
                    Z++;
                    break;
                case Directions.S:
                    Z = Directions.W;
                    break;
                case Directions.W:
                    Z++;
                    break;
            }
        }
        public void MoveForward()
        {
            if (Z == Directions.N)
                Y++;
            else if (Z == Directions.E)
                X++;
            else if (Z == Directions.S)
                Y--;
            else if (Z == Directions.W)
                X--;
        }
    }

}
