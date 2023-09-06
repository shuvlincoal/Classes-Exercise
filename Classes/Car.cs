using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Car
    {

        //fields
        //           Pascal
        public int    Year  { get; set; }  //property
        public string Model { get; set; }  //property
        public string Make  { get; set; }  //property

        
        public Car(string make, string model, int year)  //custom Constructor
        {// Pascal  Camel
            Model = model;
            Make = make;
            Year = year;
        }

    }//class
}//namespace
