using System;

namespace P128AnonymObjectClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Anonym Object
            //Anonym Object
            //var student = new 
            //{
            //    name = "Rehamn",
            //    surname = "Vahabov",
            //    age = 19,
            //};

            //var car = new 
            //{
            //    model = "",
            //    marka ="",
            //    year = 2000,

            //};

            //Console.WriteLine($"{student.name} {student.surname}");
            #endregion

            #region Class
            // Class

            //Student stu1 = new Student();

            //Classin Fieldna Deyer Set Olunmasi yeni Menisedilmesi
            //stu1.Age = 15;
            //stu1.Name = "Rahman";
            //stu1.SurName = "Vahabov";

            //Console.WriteLine(stu1.Info());
            //Console.WriteLine(stu1.FullName());

            //Console.WriteLine($"{stu1.Name} {stu1.Age}");

            //stu1.Age = 19;
            //stu1.Name = "Rehman";

            //Console.WriteLine($"{stu1.Name} {stu1.Age}");


            //Student stu2 = new Student();

            //stu2.Name = "Seid";
            //stu2.SurName = "Zahidov";
            //stu2.Age = 17;

            //Console.WriteLine(stu2.Info());
            //Console.WriteLine(stu2.FullName());
            //Console.WriteLine(stu2.Age);

            //sneake case - Variable
            //string fathername = "";
            //Paskal Case - Class Or Other Custom Type Memmber
            //string FatherName;
            //Camel Case - Method Parametr
            //string fatehrName;
            //kebab case
            //string fatehr-name
            #endregion

            #region Aggreagtion
            //Address address = new Address();
            //address.Country = "Azerbaijan";
            //address.City = "Baki";
            //address.PostalCode = "1102";

            //Student Instance
            //Console.WriteLine("Adi Daxil Et");
            //string name = Console.ReadLine();

            //Student student = new Student(name);
            //student.Name = name;
            //Console.WriteLine(student.Info());


            //student.Address = address;
            //student.Address = new Address();
            //student.Address.Country = "Amerika";
            //student.Address.City = "Miami";
            //student.Address.PostalCode = "1111";

            ////Company Instance
            //Company company = new Company();
            //company.Name = "Code Academy";
            //company.Address = address;

            //company.Address.PostalCode = "999999";
            //company.Address.City = "Yevlax";

            //Console.WriteLine(address.City);
            //Console.WriteLine(student.Address.City);
            //Console.WriteLine(company.GetAdress());
            #endregion

            #region OOP - Inheritance
            Student student = new Student();


            Developer developer = new Developer();
            developer.
            #endregion
        }
    }
}
