using System;
using System.Collections.Generic;
using System.Text;

namespace MarRover2
{
	public class MarsRover
	{
		public int Y { get; set; }
		public char Z { get; set; }
		public int X { get; set; }
		public void GetInfo(string info)
		{
			if (info[0] >= '0' && info[0] <= '9')
			{
				var coord = info;
				var str = coord.Split(" ");
				X = Convert.ToInt32(str[0]);
				Y = Convert.ToInt32(str[1]);
				Z = str[2][0];

			}
			else if (info[0] >= 'A' && info[0] <= 'Z')
			{ 	
				var instructions = info;
				Move(instructions);
			}
		}
		public void Move(string instructions)
		{
			var k = 0;

			while(k < instructions.Length)
			{
				if (instructions[k] == 'L')
				{
					TurnLeft();
				}
				else if (instructions[k] == 'R')
				{
					TurnRight();
				}
				else if (instructions[k] == 'M')
				{
					MoveForward();
				}
				k++;
			}
			Console.WriteLine(X + " " + Y + " " + Z);
		}
		public void TurnLeft()
        {
			if (Z == 'N')
				Z = 'W';
			else if (Z == 'E')
				Z = 'N';
			else if (Z == 'S')
				Z = 'E';
			else if (Z == 'W')
				Z = 'S';
        }
		public void TurnRight()
		{
			if (Z == 'N')
				Z = 'E';
			else if (Z == 'E')
				Z = 'S';
			else if (Z == 'S')
				Z = 'W';
			else if (Z == 'W')
				Z = 'N';
		}
		public void MoveForward()
		{
			if (Z == 'N')
				Y++;
			else if (Z == 'E')
				X++;
			else if (Z == 'S')
				Y--;
			else if (Z == 'W')
				X--;
		}
	}

}
