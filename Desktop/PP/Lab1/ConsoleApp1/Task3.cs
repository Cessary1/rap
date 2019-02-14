//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Task3
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int a = int.Parse(Console.ReadLine()); // количество элементов массива
//            int[] arr = new int[a]; // создаем массив 
//            string[] s = Console.ReadLine().Split(); // вводим элементы массива 
//            for (int i = 0; i < arr.Length; i++)
//            {
//                arr[i] = int.Parse(s[i]); // переводим в инт
//                Console.Write(arr[i] + " " + arr[i] + " "); // вывод чисел
//            }
//            Console.ReadKey();
//        }
//    }
//}