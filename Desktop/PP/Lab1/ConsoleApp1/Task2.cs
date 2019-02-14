//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Task2

//{

//    class Student //создание класса

//    {

//        public string name; //public доступен из любого места программы 

//        public string id; 

//        public int year = 2018; 


//        public Student(string name, string id) // создание метода

//        {

//            this.name = name;

//            this.id = id;

//        }



//        public void first()
//        {
//            Console.WriteLine(name + " " + id + " ");
//        }

//        public void second()
//        {
//            year++;
//            Console.WriteLine(year);
//        }

//    }



//    class Program

//    {

//        static void Main(string[] args)
//        {

//            Student s = new Student("Alem", "3068542");

//            s.first();
//            s.second();
//            Console.ReadKey();

//        }

//    }

//}