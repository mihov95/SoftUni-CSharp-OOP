using System;
using System.Linq;

namespace _02._Point_In_Rectangle
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangle();
            var point = new Point();

            int[] rectangleCoordinates = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            rectangle.TopLeftX = rectangleCoordinates[0];
            rectangle.TopLeftY = rectangleCoordinates[1];
            rectangle.BottomRightX = rectangleCoordinates[2];
            rectangle.BottomRightY = rectangleCoordinates[3];

            int countPoints = int.Parse(Console.ReadLine());

            for (int i = 0; i < countPoints; i++)
            {
                int[] pointCoordinates = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                point.CoordinateX = pointCoordinates[0];
                point.CoordinateY = pointCoordinates[1];

                Console.WriteLine(rectangle.Contains(point));
                
            }
        }
    }
}
