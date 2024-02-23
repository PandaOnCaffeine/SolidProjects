using SolidProjects.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidProjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square squareTest1 = new Square(5);
            Square squareTest2 = new Square(2);
            Square squareTest3 = new Square(7);
            Square squareTest4 = new Square(1);

            Console.WriteLine($"Square 1 | Omkreds: {squareTest1.Circumference()}| Areal: {squareTest1.Area()}");
            Console.WriteLine($"Square 2 | Omkreds: {squareTest2.Circumference()}| Areal: {squareTest2.Area()}");
            Console.WriteLine($"Square 3 | Omkreds: {squareTest3.Circumference()}| Areal: {squareTest3.Area()}");
            Console.WriteLine($"Square 4 | Omkreds: {squareTest4.Circumference()}| Areal: {squareTest4.Area()}");







            Console.ReadLine();
        }
    }
}
