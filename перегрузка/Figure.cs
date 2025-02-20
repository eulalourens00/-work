using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace перегрузка
{
    abstract class Figure
    {
        public abstract void Draw();

    }

    abstract class Quadrangle: Figure { }
    class Rectangle : Quadrangle
    {
       public int Width { get; set; }
       public int Height { get; set; }
       public static implicit operator Rectangle(Square s)
        {
            return new Rectangle
            {
                Width = s.Length * 2,
                Height = s.Length * 2
            };
        }

        public override void Draw() {
            for (int i = 0; i < Height; i++, Console.WriteLine()) {
                for (int j = 0; j < Width; j++) {
                    Console.Write("*");
                }
            }
            Console.WriteLine();
        }

        public override string ToString() {
            return $"REctangle: Width = {Width}\n Height = {Height}";          
        }

    }

    class Square : Quadrangle
    {
        public int Length { get; set; }
        public static explicit operator Square(Rectangle rect)
        {
            return new Square { Length = rect.Width };
        }

        public static explicit operator int(Square s)
        { 
            return s.Length;
        }

        public static implicit operator Square(int number)
        {
            return new Square { Length = number };
        }
        public override void Draw() { 
            for(int i = 0; i < Length; i++, Console.WriteLine())
            {
                for (int j = 0; j < Length; j++)
                { 
                    Console.Write("*");
                }
            }
            Console.WriteLine() ;
        }
        public override string ToString()
        {
            return $"Square Length = {Length}";
        }

    }
}
