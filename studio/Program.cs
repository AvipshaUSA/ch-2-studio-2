using System;

namespace studio
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            float r;
            Console.WriteLine("enter radious");
               input= Console.ReadLine();
             r = float.Parse(input);
            int i = 1;
            while (i > 0)
            {
                if (r > 0)
                {
                    break;

                }
                else
                {

                    Console.WriteLine("enter Posetive number");
                    input = Console.ReadLine();
                    r = float.Parse(input);
                    i++;
                }
            }
            Console.WriteLine("Press A to get Area Or Press C to get circumference:");
            string s = Console.ReadLine();
            circle.CircleA(r, s);
            
        }
    }
}
