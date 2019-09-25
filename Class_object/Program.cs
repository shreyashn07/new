using System;

namespace Class_object
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Programmer programmer = new Programmer(6, "Java", "bla", "bla");
            Console.WriteLine(programmer.getFavLanguage());
            Console.WriteLine(programmer.getName());
        }
    }
}
