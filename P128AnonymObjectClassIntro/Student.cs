using System;
using System.Collections.Generic;
using System.Text;

namespace P128AnonymObjectClassIntro
{
    partial class Student : Human
    {
        //Constructor
        //Classin Adinnan Eyni Adda Olan Methodu
        //return Type Olmur
        //Yalniz Initialize Zamanai Cagrilir Isdiyit
        //Eger Constructor Biz Yaratmasa Default Olaraq Bir Dener CLR Yaradir

        public Student()
        {
            Console.WriteLine("Telebe Yarandi");
            Console.WriteLine(Info());
        }

        public Student(string name) : this()
        {
            Name = name;
            Console.WriteLine(Info());
        }

        public Student(string name, string surName) : this(name)
        {
            SurName = surName;
            Console.WriteLine(Info());

        }

        public Student(string name, string surName, byte age) : this(name, surName)
        {
            Age = age;
            Console.WriteLine(Info());
        }

        
    }
}
