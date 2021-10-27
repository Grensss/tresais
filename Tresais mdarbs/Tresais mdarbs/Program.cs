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
            car.Speed = 20;
            car.Numbcar = "HK - 2748";
            string cartext = car.Carametrs();
            Console.WriteLine(cartext);
            string carmanage = car.Carfunctionality();
            Console.WriteLine(carmanage);
            car.Functoin = Console.ReadLine();
            if (car.Functoin == "beep")
            {
                Console.WriteLine ("Beep Beep");
                Console.Beep();
            }
            else if(car.Functoin == "faster")
            {
                car.Speed = car.Speed + 10;
                Console.WriteLine("Your car speed is " + car.Speed + " km / h.");
            }
            else if (car.Functoin == "slower")
            {
                car.Speed = car.Speed -10;
                Console.WriteLine("Your car speed is " + car.Speed + " km / h.");
            }
            

        }
    }
}
