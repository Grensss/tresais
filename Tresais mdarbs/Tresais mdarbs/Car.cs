using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tresais_mdarbs
{
    class Car
    {
        public string Model { get; set; }
        public int Seats { get; set; }
        public string Numbcar { get; set; }
        public int Speed { get; set; }
        public string Functoin { get; set; }
        
        public string Carametrs()
        {
            string cartext = "Your " + Model + " have " + Seats + " seats and number is "+ Numbcar + ".";
            return cartext;
        }
        public string Carfunctionality()
        {
            string carmanage = "To manage car type [beep, faster, slower], your car speed is " + Speed + " km/h.";
            return carmanage;
        }










    }
   

}
