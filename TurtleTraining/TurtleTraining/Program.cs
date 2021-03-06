﻿using System;
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


        public static void WriteT(int longLine, int shortLine)
        {
            Turtle.Angle = 0;
            Turtle.Move(longLine);
            Turtle.TurnLeft();
            Turtle.Move(shortLine);
            Turtle.Angle = 90;
            Turtle.Move(shortLine * 2);
        }

        public static void WriteA(int longLine, int shortLine)
        {
            Turtle.Angle = 0;
            Turtle.Turn(25);
            Turtle.Move(longLine);
            Turtle.Turn(130);
            Turtle.Move(longLine);
            Turtle.Turn(180);
            Turtle.Move(longLine / 2);
            Turtle.Turn(-65);
            Turtle.Move(shortLine);
        }

        public static void WriteL(int longLine)
        {
            Turtle.Angle = 0;
            Turtle.Turn(25);
            Turtle.Move(longLine);
            Turtle.Turn(130);
            Turtle.Move(longLine);
        }


        public static void WriteG(int longLine, int shortLine)
        {
            Turtle.Angle = 0;
            Turtle.Move(longLine);
            Turtle.TurnRight();
            Turtle.Move(shortLine);
        }

        public static void WriteO(int way)
        {
            for(int i = 0; i < 4; i++)
            {
                Turtle.Move(way);
                Turtle.TurnRight();
            } 
        }

        public static void WriteP(int longLine, int shortLine)
        {
            Turtle.Angle = 0;
            Turtle.Move(longLine);
            Turtle.TurnRight();
            for (int i = 0; i < 3; i++)
            {
                
                Turtle.Move(shortLine);
                Turtle.TurnRight();
            }


        }

        public static void WriteYa(int longLine, int shortLine)
        {
            Turtle.Angle = 0;
            Turtle.Move(longLine);
            Turtle.TurnLeft();
            for (int i = 0; i < 3; i++)
            {

                Turtle.Move(shortLine);
                Turtle.TurnLeft();
            }
            Turtle.Turn(-135);
            Turtle.Move(shortLine);




        }


        static void Main(string[] args)
        {
            Turtle.Speed = 9;
            Turtle.X = 120;
            Turtle.Y = 200;

            WriteT(60, 20);

            Turtle.X = 150;
            Turtle.Y = 170;

            WriteO(30);

            Turtle.X = 200;
            Turtle.Y = 230;

            WriteP(60, 30);

            Turtle.X = 260;
            Turtle.Y = 200;

            WriteT(30, 15);

            Turtle.X = 250;
            Turtle.Y = 300;

            WriteG(55, 30);

            Turtle.X = 280;
            Turtle.Y = 300;

            WriteA(60, 25);

            Turtle.X = 340;
            Turtle.Y = 300;

            WriteL(60);

            Turtle.X = 450;
            Turtle.Y = 300;

            WriteYa(55, 30);

        }
    }
}
