using System;

namespace ItsAllGreek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter starting X value");
            float point1x = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter starting Y value");
            float point1y = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter ending X value");
            float point2x = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter ending Y value");
            float point2y = float.Parse(Console.ReadLine());
            float deltaX = delta(point2x, point1x);
            float deltaY = delta(point2y, point1y);
            Console.WriteLine($"You moved {distance(deltaX,deltaY)} units along {getAngle(deltaX, deltaY)} degrees");

        }

        static float delta(float x, float y)
        {
            return x - y;
        }

        static float distance(float deltaX, float deltaY)
        {
            return MathF.Sqrt((deltaX*deltaX) + (deltaY*deltaY));
        }

        static float getAngle(float x, float y)
        {
            float radians = MathF.Atan2(x, y);
            return radians * (180 / MathF.PI);
        }
    }
}
