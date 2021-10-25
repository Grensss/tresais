using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tresais_mdarbs
{
    class Phone
    {
        public string ModelName { get; set; }
        public int Ram { get; set; }
        public int Ghz { get; set; }
        public int width { get ;set;}
        public int length { get; set; }
        public int height { get; set; }
        

        public string Parameters()
        {
            string Param = "Your " + ModelName + " have " + Ram + " Ram and " + Ghz + " Ghz processor, it's size(width, length, and height) in cm is "+ width + "/" + length + "/" + height + ". Nothing more, have good day :)" ;
            return Param;
        }
    }
}
