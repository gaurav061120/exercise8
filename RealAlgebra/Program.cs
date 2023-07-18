using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeAreaLib;
namespace RealAlgebra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please select shape");
                Console.WriteLine("1. Rectangle");
                Console.WriteLine("2. Square");
                Console.WriteLine("3. Tiangle");
                Console.WriteLine("0. Exit");
                Console.Write("enter choice");
                string input = Console.ReadLine();
                int choice;
                if (int.TryParse(input, out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            CalculateRectangleArea();
                            break;
                        case 2:
                            CalculateSquareArea();
                            break;
                        case 3:
                            CalculateTriangleArea();
                            break;
                        case 0:
                            Console.WriteLine("thanx for using RealAlgebra");
                            return;
                        default:
                            Console.WriteLine("inalid input");
                            break;
                    }
                }
                void CalculateRectangleArea()
                {
                    Console.Write("enter length of rectangle");
                    double length = Convert.ToDouble(Console.ReadLine());
                    Console.Write("enter width of rectangle");
                    double width = Convert.ToDouble(Console.ReadLine());
                    double Area = ShapeAreaLib.Rectangle.CalculateArea(length, width);
                    Console.WriteLine($"the area of rectangle is : {Area}");
                }
                void CalculateSquareArea()
                {
                    Console.Write("enter side of square");
                    double side = Convert.ToDouble(Console.ReadLine());


                    double Area = ShapeAreaLib.Square.CalculateArea(side);
                    Console.WriteLine($"the area of square is : {Area}");
                }
                void CalculateTriangleArea()
                {
                    Console.Write("enter baseLength of triangle");
                    double baseLength = Convert.ToDouble(Console.ReadLine());
                    Console.Write("enter heigth of rectangle");
                    double height = Convert.ToDouble(Console.ReadLine());
                    double Area = ShapeAreaLib.Triangle.CalculateArea(baseLength, height);
                    Console.WriteLine($"the area of triangle is : {Area}");
                }
            }
        }
    }
}





                



            
        
    

