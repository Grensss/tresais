using System;

namespace Tresais_mdarbs
{
    class Program
    {
        static void First(string[] args)
        {
            Phone phone = new Phone();
            Console.WriteLine("What is your phone manufacturer?");
            phone.ModelName = Console.ReadLine();
            Console.WriteLine("How many your phone have Ram?");
            phone.Ram = int.Parse(Console.ReadLine());
            Console.WriteLine("Thats all what i need :)");
            phone.Ghz = 3;
            phone.width = 10;
            phone.length = 15;
            phone.height = 17;
            string param = phone.Parameters();
            Console.WriteLine(param);

        }
        static void Second(string[] args)
        {



        }
    }
}
