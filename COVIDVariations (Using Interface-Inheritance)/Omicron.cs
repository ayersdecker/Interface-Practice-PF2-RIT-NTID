using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//
// Name: Decker Ayers
// Course: NMAD 181.2
// Date: 1/31/2022
//
// Assignment: Interface Classwork 
// Caveats: Program meant to be simple
//
// 
//
//

namespace COVIDVariations__Using_Interface_Inheritance_
{
    class Omicron : COVID, IInfectionRate, ISurvivalRate, ICountryOrigin // Omicron class: Builds Omicron COVID strain
    {
        public string InfectionRate() // Set IR
        {
            return "750,000";
        }
        public string SurvivalRate() // Set SR
        {
            return "99.7";
        }
        public string CountryOfOrigin()// Set CO
        {
            return "South Africa";
        }
        public Omicron(string _strain) // Constructor (FOR COVID)
                        : base(_strain)
        {

        }
        public override string ToString()
        {
            return base.ToString() + $"\nDaily Infection Rate: {InfectionRate()}" +
                                    $"\nDaily Survival Rate: {SurvivalRate()}" +
                                    $"\nCountry of Origin: {CountryOfOrigin()}";
        }
    }
}
