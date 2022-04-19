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
            Course f1 = new Course();
            int n;
            Console.WriteLine("Введите количество блюд: ");
            n = int.Parse(Console.ReadLine());
            //создается массив с объектами класса Course
            f1.myArr = new Course[n];
            Console.WriteLine(f1.n);
            int[] x = new int[n];
 
            int add(string n, int t, double p, int s) {

            for (int i = 0; i < n; i++)
            {
                myArr[i].price = int.parse(console.readline());
                Console.WriteLine("Введите название блюда: ",name);
			    Console.WriteLine("Введите цену: ",price);
				Console.WriteLine("Введите время приготовления в минутах (от 1 до 60): ",time);
                x[i] = Convert.ToInt32(Console.ReadLine());
                
            }  
    Console.ReadLine();
        

            
        }

		for (int j = i + 1; j < nums.Length; j++)
        {
           if (myArr[i].price > myArr[j].price && myArr[i].time > myArr[j].time)
           {
              temp = nums[i];
              nums[i] = nums[j];
              nums[j] = temp;
           }
        }

}

string path = @"D:\Users\stu-pksp118\source\repos\Ekz_PM03_Menchikova\file.txt";   // путь к файлу
 private void logger_new(string name, string action_name, TextBox textID) 
{
Logger.WriteLog(" ");

    }
}
