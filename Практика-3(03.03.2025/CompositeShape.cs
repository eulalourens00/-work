using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_3_03._03._2025
{
    internal class CompositeShape
    {
        private List<GeometryFigures> figuresList = new List<GeometryFigures>();

        public void AddFigures(GeometryFigures figure)
        {
            figuresList.Add(figure);
        }

        public double Area()
        {
            double totalArea = 0;
            foreach (var figure in figuresList)
            {
                totalArea += figure.Area();
            }
            Console.WriteLine($"Total Area of your figures is {totalArea}");
            return totalArea;
        }

        public double Perimeter()
        {
            double totalPerimeter = 0;
            foreach (var figure in figuresList)
            {
                totalPerimeter += figure.Perimeter();
            }
            Console.WriteLine($"Total Perimeter of your figures is {totalPerimeter}");
            return totalPerimeter;
        }
    }
}
