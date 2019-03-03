using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // one variable set to 1
            // another variable to hold the separate number in order to multiply
            // split in order to separate it from it's comma
            // int32

            Console.WriteLine("Type in some numbers, seprated with a comma, to do some multiplying!");
            var x = Console.ReadLine();
            Console.WriteLine("If you want to multiply, please type X, if you would like the Square Root, please type S."); 
            var selectedMathChoice = Console.ReadLine().ToLower();
            var valueToSplit = x.Split(',');
            var y = 1;
                if (selectedMathChoice == "x")
                {
                    foreach (var z in valueToSplit)
                    {
                        y = y * Convert.ToInt32(z);
                    }
                    Console.WriteLine("Your multiplied answer is {0}", y);
                    Console.ReadLine();
                }
                else if (selectedMathChoice == "s")
                {
                    var emptyString = " ";
                    foreach (var z in valueToSplit)
                    {
                        var a = 1;
                        a = a * Convert.ToInt16(z);
                        var squared = Math.Pow(a, 2);
                        emptyString += squared.ToString() + ",";
                    }
                    Console.WriteLine("Your squared answer is {0}", emptyString.TrimEnd(','));
                    Console.ReadLine();
                }
        }
    }
}
