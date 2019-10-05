using System;

namespace SquaresOfFigures
{
    public class Squares
    {
        public double RoundSquare(int radius)
        {
            double square = Math.Round(Math.PI * Math.Pow(radius, 2), 2);
            Console.Write("Square of round with radius = " + radius + " is equal to " + square + "\n");
            return square;
        }

        public double TriangleSquare(int a, int b, int c)
        {
            if (a == b && a == c)
            {
                Console.Write("Your triangle is regular! \n");
            }

            double perimetr = (a + b + c) / 2;
            double square = Math.Sqrt(perimetr * (perimetr - a) * (perimetr - b) * (perimetr - c));
            square = Math.Round(square, 2);
            Console.Write("Square of triangle is equal to " + square + "\n");
            return square;

        }
    }
}

