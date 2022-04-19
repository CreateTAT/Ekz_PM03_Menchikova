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
		    Courses* current, * previous, * tmp;
		    previous = NULL;
		    if (first) {
			current = first;
			do {
				if (current->price > p) {
					tmp = new Courses;
					tmp->name = n;
					tmp->price = p;
					tmp->time = t;
					tmp->next = current;
					if (previous)
						previous->next = tmp;
					else
						first = tmp;
					break;
				}
				if (current->price == p)
					return 0;
				previous = current;
				current = current->next;
			} while (current);
			if (!current) {
				previous->next = new Tour;
				previous->next->name = n;
				previous->next->price = p;
				previous->next->time = t;
				previous->next->next = NULL;
			}
		}
		else {
			Courses* c = new Courses;
			c->name = n;
			c->price = p;
			c->time = t;
			c->next = NULL;
			first = c;
		}
		return 1;
	}

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите название блюда: ",name, "Введите цену: ",price,"Введите время приготовления в минутах (от 1 до 60): ",time);
                x[i] = Convert.ToInt32(Console.ReadLine());
                
            }  
    Console.ReadLine();
        

            
        }
string path = @"D:\Users\stu-pksp118\source\repos\Ekz_PM03_Menchikova\file.txt";   // путь к файлу
 
// запись в файл
using (FileStream fstream = new FileStream(path, FileMode.OpenOrCreate))
{
    // преобразуем строку в байты
    byte[] buffer = Encoding.Default.GetBytes(text);
    // запись массива байтов в файл
    await fstream.WriteAsync(buffer, 0, buffer.Length);
    Console.WriteLine("Текст записан в файл");
}
 
// чтение из файла
using (FileStream fstream = File.OpenRead(path))
{
    // выделяем массив для считывания данных из файла
    byte[] buffer = new byte[fstream.Length];
    // считываем данные
    await fstream.ReadAsync(buffer, 0, buffer.Length);
    // декодируем байты в строку
    string textFromFile = Encoding.Default.GetString(buffer);
    Console.WriteLine($"Текст из файла: {textFromFile}");
}
    }
}
