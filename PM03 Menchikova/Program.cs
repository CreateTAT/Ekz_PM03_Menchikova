using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM03_Menchikova
{
    class Program
    {
        static void Main(string[] args)
        {
            Courses f1 = new Courses();
            int n;
            n = int.Parse(Console.ReadLine());
            //создается массив с объектами класса Course
            f1.myArr = new Course[n];
            Console.WriteLine(f1.n);
        }
    }
}
