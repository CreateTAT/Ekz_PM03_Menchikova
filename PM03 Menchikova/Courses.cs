using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM03_Menchikova
{
    public class Course
    {
        public string name;
        public int price;
        public int time;

        public Course(string name1, int price1, int time1)
        {
            name = name1;
            price = price1;
            time = time1;
        }
        public string Nazv { get; set; }
        public int Sale { get; set; }
        public string Time { get; set; }
    }
    class Courses
    {
        public int n;
        public Courses(int n1)
        {
            n = n1;
        }
    }
}
