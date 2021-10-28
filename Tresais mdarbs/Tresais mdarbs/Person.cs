using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tresais_mdarbs
{
    class Person
    {
        public string name  { get; set; }
        public int age { get; set; }
        public string hob { get; set; }
        public string work { get; set; }
        public string sex { get; set; }
        
        //name surname hobijs dzimums 
        public string Persontext()
        {
            string Pers = name + ", you are " + age + " years old " + sex +". \nSome times you " + hob+ " and work like " + work + ".\nAnd that's all, thank you for completing this survey, have good day.";
            return Pers;
        }
        
       
    }
}
