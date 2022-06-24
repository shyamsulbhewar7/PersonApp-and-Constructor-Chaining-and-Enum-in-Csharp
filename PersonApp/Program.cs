using PersonApp.Model;
using System;

namespace PersonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(100,"shyam",23, 6, 90);
            Person person2 = new Person(200,"Bruce", 25);
            Console.WriteLine("Person 1 :");
            Console.WriteLine("Name : " + person1.Name + "\n Age :" + person1.Age);
            Console.WriteLine("Person 2 :");
            Console.WriteLine("Name : " + person2.Name + "\n Age :" + person2.Age);
            Console.WriteLine("BMI of person1 is : " + person1.BMI() + "\nBody Type : " + person1.BodyTypeOnBMI());
            Console.WriteLine();
            Console.WriteLine("BMI of person1 is : " + person2.BMI() + "\nBody Type : " + person2.BodyTypeOnBMI());
        }
    }
}
