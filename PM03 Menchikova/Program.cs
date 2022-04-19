using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM03_Menchikova
{
    class Program
    {
        void BubbleSort(int *arr, int N){
           for (int i = 0; i < N; i++)
              for (int j = i + 1; j < N; j++){
                 if (arr[j] < arr[i]){
                     int tmp = arr[i];
                     arr[i] = arr[j];
                     arr[j] = tmp;
                 }
              }
        }
        static void Main(string[] args)
        {
            Courses f1 = new Courses();
            int n;
            n = int.Parse(Console.ReadLine());
            //создается массив с объектами класса Course
            f1.myArr = new Course[n];
            Console.WriteLine(f1.n);
        }
        int main () 
{
    setlocale(0, "");
    int number;
    int *p_darr;
    ofstream fp("number.txt"); 
    cout << "Программа запишет целые числа в текстовый документ\n";
    cout << "Для выхода из программы вместо числа напишите 0\n";
    cout << "Введите целое число: ";
    cin >> number;
    p_darr = new int[number];
    for (int i = 0; i < number; i++) {
        cin >> p_darr[i];
    }
    BubbleSort(p_darr, number);   
    for(int i = 0; i < number; ++i){
       fp << p_darr[i] << ' ';
    }
    fp.close();
    delete [] p_darr;
    cout << "\033[1;31mКоманда для завершения работы принята.\033[0m\n";
    cout << "\033[1;31mРезультат записан в number.txt.\033[0m\n";
}
    }
}
