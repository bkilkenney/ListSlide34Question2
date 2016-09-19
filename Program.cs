using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListSlide34Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<bool> boolList = new List<bool>() { true, false, false, true, false };

            

            foreach (bool currentVal in boolList)
                if(currentVal == true)
                {
                    Console.WriteLine("Better bring an umbrella");
                }
            else if (currentVal == false)
                {
                    Console.WriteLine("No rain today, enjoy the sun!");
                }
                    
            

            //Loop through each value
            // If the value is true print: "Better bring an umbrella"
            //If the value is false print: "No rain today, enjoy the sun!"

        }
    }
}
