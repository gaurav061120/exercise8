using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaLib
{

    
    
        public class Rectangle
        {
            public static double CalculateArea(double length, double width)
            {
                return length * width;

            }
        }

        public class Square
        {
            public static double CalculateArea(double side)
            {
                return side * side;

            }
        }

        public class Triangle
        {
            public static double CalculateArea(double baseLength, double height)
            {
                return 0.5 * baseLength * height;

            }
        }
    }


                

