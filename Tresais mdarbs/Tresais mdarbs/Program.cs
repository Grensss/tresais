using System;

namespace Tresais_mdarbs
{
    class Program
    {
        static void Main(string[] args)
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
                Console.WriteLine("Beep Beep");
                Console.Beep();
            }
            else if (car.Functoin == "faster")
            {
                car.Speed = car.Speed + 10;
                Console.WriteLine("Your car speed is " + car.Speed + " km / h.");
            }
            else if (car.Functoin == "slower")
            {
                car.Speed = car.Speed - 10;
                Console.WriteLine("Your car speed is " + car.Speed + " km / h.");
            }

            Product product = new Product();
            Console.WriteLine("Greetings write product name to search it's parameters.");
            product.Productname = Console.ReadLine();
            product.ProdHeight = 40;
            product.ProdLength = 20;
            product.ProdWeight = 5;
            product.ProdWidth = 60;
            string Prod = product.Productometrs();
            Console.WriteLine(Prod);

            Person person = new Person();
            Console.WriteLine("Greetings, do you want to complete some survey about you? Yes or No.");
            string answer = Console.ReadLine();
            if (answer == "Yes")
            {
                Console.WriteLine("Nice, what's your name?");
            }
            else if (answer == "No")
            {
                Console.WriteLine("Eh, that's bad, but ok, see you another time.");
                return;
            }
            person.name = Console.ReadLine();
            Console.WriteLine("Cool name, when you born? Write only year.");
            string _age = Console.ReadLine();
            person.age = int.Parse(_age);
            int finalage = 2021 - person.age;
            Console.WriteLine("Heh, you are young, it's cool, which sex you are? male or female?");
            person.sex = Console.ReadLine();
            if (person.sex == "male")
            {
                Console.WriteLine("Nice man, maybe you have a hobbies?");
            }
            else if (person.sex == "female")
            {
                Console.WriteLine("It's cool girl, maybe you have a hobbies?");
            }
            person.hob = Console.ReadLine();
            Console.WriteLine("Very good, what kind of work you have now?");
            person.work = Console.ReadLine();
            Console.WriteLine("Good, now we can see what we got.");
            string Pers = person.Persontext();
            Console.WriteLine(Pers);











        }
    }
}
