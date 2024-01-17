using System;

namespace Exercises_43
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            NewMethod(out var userNumber);

            NewMethod1(out var num1, out var num2);

            NewMethod2(out var width, out var height);

            NewMethod3(out var speedLimit, out var carSpeed);
        }

        private static void NewMethod3(out int speedLimit, out int carSpeed)
        {
            // EX4
            speedLimit = 90;
            carSpeed = 100;
            
            if (carSpeed < speedLimit)
            {
                Console.WriteLine("OK");
            }
            else
            {
                var amoutAbove = speedLimit - carSpeed;
                var demeritPoints = (int)amoutAbove / 5;
            
                if (Math.Abs(demeritPoints) > 12)
                {
                    Console.WriteLine("License is suspended");
                }
                else
                {
                    Console.WriteLine(string.Format("Demerit is {0}", demeritPoints));
                }
            }
        }

        private static void NewMethod2(out int width, out int height)
        {
            // EX3
            width = 1920;
            height = 1080;
            
            if (width > height)
            {
                Console.WriteLine("Image is landscape");
            }
            else
            {
                Console.WriteLine("Image is portrait");
            }
        }

        private static void NewMethod1(out int num1, out int num2)
        {
            // EX2
            num1 = 23;
            num2 = 34;
            
            if (num1 > num2)
            {
                Console.WriteLine(num1);
            }
            else
            {
                Console.WriteLine(num2);
            }
        }

        private static void NewMethod(out int userNumber)
        {
            // EX1
            userNumber = 11;

            if (userNumber > 0 && userNumber <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}