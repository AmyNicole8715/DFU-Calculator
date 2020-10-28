using System;
using System.Numerics;

namespace DFU_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //User is asked to input their pipe diameter
            //User is asked to input slope of pipe
            //program outputs dfu per that size of pipe and slope
            //string piped = "blah blah blah";
            //string pipes = "bleh bleh bleh";

            //Acceptable Diameters = 1.25, 1.5, 2, 3, 4, 5, 6, 8, 10, 12, 15
            //Acceptable slopes (inches per foot of pipe) = 0.063 (1/16"), 0.125 (1/8"), 0.25 (1/4"), 0.5 (1/2")
            double diameter;
            double slope;

            while (true)
            {
                //program start
                Console.WriteLine("What is the diameter of your pipe in decimal format?");
                diameter = Convert.ToDouble(Console.ReadLine());

                if (diameter == 1.25)
                {
                    Console.WriteLine("What is the slope of your pipe converted to decimal?");
                    slope = Convert.ToDouble(Console.ReadLine());

                    if (slope == 0.25)
                    {
                        Console.WriteLine("The max DFU of your pipe is 1");
                    }
                    else if (slope == 0.5)
                    {
                        Console.WriteLine("The max DFU of your pipe is 1");
                    }
                    else
                    {
                        Console.WriteLine("You need to input a valid measurement in inches");
                    }

                }
                if (diameter == 1.5)
                {
                    Console.WriteLine("What is the slope of your pipe converted to decimal?");
                    slope = Convert.ToDouble(Console.ReadLine());

                    if (slope == 0.25)
                    {
                        Console.WriteLine("The max DFU of your pipe is 3");
                    }
                    else if (slope == 0.5)
                    {
                        Console.WriteLine("The max DFU of your pipe is 3");
                    }
                    else
                    {
                        Console.WriteLine("You need to input a valid measurement in inches");
                    }
                }
                if (diameter == 2)
                {
                    Console.WriteLine("What is the slope of your pipe converted to decimal?");
                    slope = Convert.ToDouble(Console.ReadLine());

                    if (slope == 0.25)
                    {
                        Console.WriteLine("The max DFU of your pipe is 21");
                    }
                    else if (slope == 0.5)
                    {
                        Console.WriteLine("The max DFU of your pipe is 26");
                    }
                    else
                    {
                        Console.WriteLine("You need to input a valid measurement in inches");
                    }



                }
                if (diameter == 2.5)
                {
                    Console.WriteLine("What is the slope of your pipe converted to decimal?");
                    slope = Convert.ToDouble(Console.ReadLine());

                    if (slope == 0.25)
                    {
                        Console.WriteLine("The max DFU of your pipe is 24");
                    }
                    else if (slope == 0.5)
                    {
                        Console.WriteLine("The max DFU of your pipe is 31");
                    }
                    else
                    {
                        Console.WriteLine("You need to input a valid measurement in inches");
                    }



                }
                if (diameter == 3)
                {
                    Console.WriteLine("What is the slope of your pipe converted to decimal?");
                    slope = Convert.ToDouble(Console.ReadLine());

                    if (slope == 0.125)
                    {
                        Console.WriteLine("The max DFU of your pipe is 36");
                    }
                    else if (slope == 0.25)
                    {
                        Console.WriteLine("The max DFU of your pipe is 42");
                    }
                    else if (slope == 0.5)
                    {
                        Console.WriteLine("The max DFU of your pipe is 50");
                    }
                    else
                    {
                        Console.WriteLine("You need to input a valid measurement in inches");
                    }



                }
                if (diameter == 4)
                {
                    Console.WriteLine("What is the slope of your pipe converted to decimal?");
                    slope = Convert.ToDouble(Console.ReadLine());

                    if (slope == 0.125)
                    {
                        Console.WriteLine("The max DFU of your pipe is 180");
                    }
                    else if (slope == 0.25)
                    {
                        Console.WriteLine("The max DFU of your pipe is 216");
                    }
                    else if (slope == 0.5)
                    {
                        Console.WriteLine("The max DFU of your pipe is 250");
                    }
                    else
                    {
                        Console.WriteLine("You need to input a valid measurement in inches");
                    }



                }
                if (diameter == 5)
                {
                    Console.WriteLine("What is the slope of your pipe converted to decimal?");
                    slope = Convert.ToDouble(Console.ReadLine());

                    if (slope == 0.125)
                    {
                        Console.WriteLine("The max DFU of your pipe is 390");
                    }
                    else if (slope == 0.25)
                    {
                        Console.WriteLine("The max DFU of your pipe is 480");
                    }
                    else if (slope == 0.5)
                    {
                        Console.WriteLine("The max DFU of your pipe is 575");
                    }
                    else
                    {
                        Console.WriteLine("You need to input a valid measurement in inches");
                    }



                }
                if (diameter == 6)
                {
                    Console.WriteLine("What is the slope of your pipe converted to decimal?");
                    slope = Convert.ToDouble(Console.ReadLine());

                    if (slope == 0.125)
                    {
                        Console.WriteLine("The max DFU of your pipe is 700");
                    }
                    else if (slope == 0.25)
                    {
                        Console.WriteLine("The max DFU of your pipe is 840");
                    }
                    else if (slope == 0.5)
                    {
                        Console.WriteLine("The max DFU of your pipe is 1000");
                    }
                    else
                    {
                        Console.WriteLine("You need to input a valid measurement in inches");
                    }



                }
                if (diameter == 8)
                {
                    Console.WriteLine("What is the slope of your pipe converted to decimal?");
                    slope = Convert.ToDouble(Console.ReadLine());

                    if (slope == 0.063)
                    {
                        Console.WriteLine("The max DFU of your pipe is 1400");
                    }
                    else if (slope == 0.125)
                    {
                        Console.WriteLine("The max DFU of your pipe is 1600");
                    }
                    else if (slope == 0.25)
                    {
                        Console.WriteLine("The max DFU of your pipe is 1920");
                    }
                    else if (slope == 0.5)
                    {
                        Console.WriteLine("The max DFU of your pipe is 2300");
                    }
                    else
                    {
                        Console.WriteLine("You need to input a valid measurement in inches");
                    }



                }
                if (diameter == 10)
                {
                    Console.WriteLine("What is the slope of your pipe converted to decimal?");
                    slope = Convert.ToDouble(Console.ReadLine());

                    if (slope == 0.063)
                    {
                        Console.WriteLine("The max DFU of your pipe is 2500");
                    }
                    else if (slope == 0.125)
                    {
                        Console.WriteLine("The max DFU of your pipe is 2900");
                    }
                    else if (slope == 0.25)
                    {
                        Console.WriteLine("The max DFU of your pipe is 3500");
                    }
                    else if (slope == 0.5)
                    {
                        Console.WriteLine("The max DFU of your pipe is 4200");
                    }
                    else
                    {
                        Console.WriteLine("You need to input a valid measurement in inches");
                    }



                }
                if (diameter == 12)
                {
                    Console.WriteLine("What is the slope of your pipe converted to decimal?");
                    slope = Convert.ToDouble(Console.ReadLine());

                    if (slope == 0.063)
                    {
                        Console.WriteLine("The max DFU of your pipe is 3900");
                    }
                    else if (slope == 0.125)
                    {
                        Console.WriteLine("The max DFU of your pipe is 4600");
                    }
                    else if (slope == 0.25)
                    {
                        Console.WriteLine("The max DFU of your pipe is 5600");
                    }
                    else if (slope == 0.5)
                    {
                        Console.WriteLine("The max DFU of your pipe is 6700");
                    }
                    else
                    {
                        Console.WriteLine("You need to input a valid measurement in inches");
                    }



                }
                if (diameter == 15)
                {
                    Console.WriteLine("What is the slope of your pipe converted to decimal?");
                    slope = Convert.ToDouble(Console.ReadLine());

                    if (slope == 0.063)
                    {
                        Console.WriteLine("The max DFU of your pipe is 7000");
                    }
                    else if (slope == 0.125)
                    {
                        Console.WriteLine("The max DFU of your pipe is 8300");
                    }
                    else if (slope == 0.25)
                    {
                        Console.WriteLine("The max DFU of your pipe is 10000");
                    }
                    else if (slope == 0.5)
                    {
                        Console.WriteLine("The max DFU of your pipe is 12000");
                    }
                    else
                    {
                        Console.WriteLine("You need to input a valid measurement in inches");
                    }



                }


            }
                

                
            
        }

    }
}
