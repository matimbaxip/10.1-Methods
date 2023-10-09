using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._1_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //calling a method
            SayHi();
            // method with parameters
            SayHiUser("Matimba");

            // method with many parameters
            SayHiAge("John", 45);
            //freezing the console
            Console.ReadLine();

        }
        // Creating a Method
        static void SayHi()

        {
            Console.WriteLine("Hi");
        }
        // Method with one parameter
        static void SayHiUser(string name)
        {
            Console.WriteLine("Hello" + name);
        }
        // Method with many parameters
        static void SayHiAge(string name, int age)
        {
            Console.WriteLine("Hello" + name + "You are" + age);

        }
    }

}

