using System;

namespace Tresais_mdarbs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Phone phone = new Phone();
            //Console.WriteLine("What is your phone manufacturer?");
            //phone.ModelName = Console.ReadLine();
            //Console.WriteLine("How many your phone have Ram?");
            //phone.Ram = int.Parse(Console.ReadLine());
            //Console.WriteLine("Thats all what i need :)");
            //phone.Ghz = 3;
            //phone.width = 10;
            //phone.length = 15;
            //phone.height = 17;
            //string param = phone.Parameters();
            //Console.WriteLine(param);



            Car car = new Car();
            Console.WriteLine("What is your car model?");
            car.Model = Console.ReadLine();
            car.Seats = 4;
            string cartext = car.Carametrs();
            Console.WriteLine(cartext);
            car.Speed = 20;
            Console.WriteLine("To manage car type [beep, faster, slower], your car speed is 20 km/h");
            String function = Console.ReadLine();
            while (true)
            {
                switch (function)
                {
                    case "faster":
                        Console.WriteLine(car.Speed + 10);
                        break;
                    case "slower":
                        Console.WriteLine(car.Speed - 10);
                        break;
                    case "beep":
                        Console.WriteLine("BEEP");
                        Console.Beep();
                        break;
                    default:
                        Console.WriteLine("Its not valid.");
                        break;
                }
                break;
            }
        }
    }
}
