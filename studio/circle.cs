using System;
using System.Collections.Generic;
using System.Text;

namespace studio
{
    class circle
    {
        public static void CircleA(float r, string str)
        {
            int i = 0;
            
            if (str.Equals("A"))
            {
                Console.WriteLine($"The Area of Circle is {Math.Round((Math.PI * r * r), 3)} with a radious of {r}");
            }else if (str.Equals("C")){
                Console.WriteLine($"The Circumference of Circle is {Math.Round((Math.PI * r * 2), 3)} with a radious of {r}");

                }
              

        }
    }
}
