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
        public int seats { get; set; }
     public string Carametrs()
    {
        string cartext = "Your " + Model + " have " + seats + " seats";
        return cartext;
    }
    
    }
   

}
