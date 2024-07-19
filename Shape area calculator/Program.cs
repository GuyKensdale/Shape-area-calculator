using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_area_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer;
            float result;

            Console.WriteLine("What shape would you like to find the area of? Please enter 'r' for a rectangle, 'T' for a right angled trinagle or any other key for a circle.");
            
            answer = Console.ReadLine();

            if (answer == "r")
            {
                Console.WriteLine("Please entrer the height of the rectangle.");
                float height = float.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the width of the rectangle");
                float width = float.Parse(Console.ReadLine());

                result = height * width;
            }
            else if(answer == "t")
            {
                Console.WriteLine("Please entrer the height of the trinagle.");
                float height = float.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the width of the triangle");
                float width = float.Parse(Console.ReadLine());

                result = (height + width) / 2;
            }
            else
            {
                Console.WriteLine("Please enter the radius of the circle");
                float radius = float.Parse(Console.ReadLine());

                result = (float)Math.PI * (radius *radius);
            }

            Console.WriteLine("The Area is " + result);
            Console.ReadKey(); 
        }
    }
}
