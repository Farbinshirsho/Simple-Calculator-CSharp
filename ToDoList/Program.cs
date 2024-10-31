using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Calculator");
            Result();
            Console.WriteLine("Press any key to close");
            Console.ReadKey();
            
        }
        public static void Result()
        {
            Console.WriteLine("Input the First Number");
            int fn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the Second Number");
            int sn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} {1}", fn, sn);
            Console.WriteLine("What do you want to do?");
            Console.WriteLine();
            Console.WriteLine("[A]dd Numbers");
            Console.WriteLine("[S]ubtract Numbers");
            Console.WriteLine("[M]ultiply Numbers");
            string UserChoice = Console.ReadLine().ToUpper();
            int Result;
            
            switch (UserChoice)
            {
                case "A":
                    Result = fn+sn;
                    Console.WriteLine(Result);
                    break;
                case "S":
                    Result = fn - sn;
                    Console.WriteLine(Result);
                    break;
                case "M":
                    Result = fn * sn;
                    Console.WriteLine(Result);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
