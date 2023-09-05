using Microsoft.VisualBasic;
using System.Xml.Schema;

namespace Classes
{
    public class Program
    {


        static void Main(string[] args)
        {
            Car car1   = new Car("Nissan", "Rogue", 2023);


            Console.WriteLine($"Car: Make: {car1.Make}, Model: {car1.Model}, Year{car1.Year} ");



        }//method
    }//class
}//namespace
