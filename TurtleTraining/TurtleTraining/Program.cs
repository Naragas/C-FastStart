using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace TurtleTraining
{
    class Program
    {
        

        public static void pentagon()
        {
            int i = 0;
            while (i < 6)
            {
                turnSixty();
                i++;
            }
        }

        public static void snake()
        {
            int i = 0;
            while (i < 6)
            {
                if (i % 2 == 0)
                {
                    doubleTurnRight();
                    i++;
                }
                else
                {
                    doubleTurnLeft();
                    i++;
                }
            }
        }


        public static void turnSixty()
            {
                Turtle.Move(50);
                Turtle.Turn(60);
            }
        public static void doubleTurnRight()
            {
                Turtle.Move(25);
                Turtle.TurnRight();
                Turtle.Move(25);
                Turtle.TurnRight();
            }

        public static void doubleTurnLeft()
        {
            Turtle.Move(25);
            Turtle.TurnLeft();
            Turtle.Move(25);
            Turtle.TurnLeft();
        }

        public static void WriteT()
        {
            Turtle.Angle = 0;
            Turtle.Move(60);
            Turtle.TurnLeft();
            Turtle.Move(20);
            Turtle.Angle = 90;
            Turtle.Move(40);


        }

        static void Main(string[] args)
        {
            Turtle.Speed = 9;
            Turtle.X = 100;
            Turtle.Y = 100;

            snake();
            pentagon();


        }
    }
}
