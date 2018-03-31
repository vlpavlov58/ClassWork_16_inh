using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IWriteToFile //File stream
    {

    }

    interface IWriteToFileS //stream writer
    {

    }

    class StrWriter : IWriteToFile
    {

    }



    interface ICountOfAngles // в интерфейсе нет реализации
    {
        int GetAngles();
    }

    interface ICoords
    {
        int X { get; set; }
        int Y { get; set; }

    }

    abstract class Figure
    {
        public string Name { get; set; }
        public double Perimetr { get; set; }
        public double Area { get; set; }

        public abstract double GetPerimetr();
        public abstract double GetArea();

    }

    class Triangle : Figure, ICountOfAngles, ICoords
    {
        public double Storona { get; set; }
        public double Hight { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public int GetAngles()
        {
            return 3;
        }

        public override double GetArea()
        {
            Area = Math.Sqrt(3) / 4 * Math.Pow(Storona, 2);
            return Area;
        }

        public override double GetPerimetr()
        {
            Perimetr = Storona * 3;
            return Perimetr;
        }
    }

    class Circle : Figure, ICoords
    {
        public double Radius { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public override double GetArea()
        {
            Area = Math.PI * Math.Pow(Radius, 2);
            return Area;
        }

        public override double GetPerimetr()
        {
            Perimetr = 2 * Math.PI * Radius;
            return Perimetr;
        }
    }

    class Square : Figure, ICoords, ICountOfAngles
    {
        public double Storona { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public int GetAngles()
        {
            return 4;
        }

        public override double GetArea()
        {
            Area = Math.Pow(Storona, 2);
            return Area;
        }

        public override double GetPerimetr()
        {
            Perimetr = Storona * 4;
            return Perimetr;
        }
    }

    class Program
    {
        static int GetAngles(ICountOfAngles countOfAngles)
        {
            return countOfAngles.GetAngles();
        }

        static void PrintCoords(ICoords coords)
        {
            Console.WriteLine($"{coords.X} - {coords.Y}");
        }

        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.X = 15;
            circle.Y = 10;
            PrintCoords(circle);


        }
    }
}
