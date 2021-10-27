using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tresais_mdarbs
{
    class Product
    {
        public string Productname { get; set; }
        public int ProdWidth {get; set;}
        public int ProdLength {get; set;}
        public int ProdWeight { get; set; }
        public int ProdHeight { get; set; }
        public string Productometrs()
        {
            string Prod = "Your product /" + Productname + "/\nWeight is " + ProdWeight + " kg \n"  + "Width " + ProdWidth + " cm\nLength " + ProdLength + " cm\nHeight " + ProdHeight + " cm.\nNothing more, have good day :)";
            return Prod;
        }

    }
}
