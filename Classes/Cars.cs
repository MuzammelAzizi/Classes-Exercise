using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Cars
    {
        public Cars()
        {
        }

        public Cars(string make, string model,string enginesize, int year)
        {
            Make = make;
            Model = model;
            EngineSize = enginesize;
            Year = year;
        }
    

        //Create a class named Car - make sure it is public
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineSize { get; set; }
        public int Year { get; set; }
        
    }
}

