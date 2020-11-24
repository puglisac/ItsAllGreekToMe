using System;

namespace ItsAllGreek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter ending X value");
            float point1x = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter ending Y value");
            float point1y = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter starting X value");
            float point2x = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter starting Y value");
            float point2y = float.Parse(Console.ReadLine());
            float deltaX = delta(point2x, point1x);
            float deltaY = delta(point2y, point1y);
            Console.WriteLine($"You moved {distance(deltaX,deltaY)} units along {getAngle(deltaX, deltaY)} degrees");

        }

        // calculate change between two x or y coordinates
        static float delta(float x, float y)
        {
            return x - y;
        }

        // calculates the distance between two points given the change in coordinates
        static float distance(float deltaX, float deltaY)
        {
            return MathF.Sqrt((deltaX*deltaX) + (deltaY*deltaY));
        }

        //returns the angle of rotation needed to move from on point to another given the change in coordinates
        static float getAngle(float x, float y)
        {
            float radians = MathF.Atan2(y, x);
            return radians * (180 / MathF.PI);
        }
    }
}
