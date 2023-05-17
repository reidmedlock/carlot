using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Car
    {
        public string Make { get; set; }  
        public string Model { get; set; }   
        public int Year { get; set; }

         public decimal Price { get; set; }
        public Car()
        {
            Make = "";
            Model = "";
            Year = "";
            Price = "";




        }



        public Car(string carMake, string carModel, int carYear, decimal carPrice)
        {
            Make = carMake;
            Model = carModel;   
            Year = carYear; 
            Price = carPrice;  


        }

        
    }
}
