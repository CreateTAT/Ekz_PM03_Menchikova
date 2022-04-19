using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM03_Menchikova
{
    public class Courses
    {
        public string name;
        public int price;
        public int time;

        public Courses(string name1, int price1, int time1)
        {
            name = name1;
            price = price1;
            time = time1;
        }
    }
    class Course
    {
        public int n;
        public Course(int n1)
        {
            n = n1;
        }
    }
}
