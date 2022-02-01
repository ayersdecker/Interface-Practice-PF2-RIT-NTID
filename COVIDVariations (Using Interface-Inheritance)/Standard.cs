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
    class Standard : COVID, IInfectionRate,ISurvivalRate // Standard Class: Builds Standard COVID strain
    {
        public string InfectionRate() // Set IR
        {
            return "500,000";
        }
        public string SurvivalRate() // Set SR
        {
            return "98.8";
        }
        public string CountryOfOrigin() // Set CO
        {
            return "China";
        }
        public Standard(string _strain) // Constructor (FOR COVID)
                        :base(_strain)
        {

        }
        public override string ToString()
        {
            return base.ToString() +$"\nDaily Infection Rate: {InfectionRate()}" +
                                    $"\nDaily Survival Rate: {SurvivalRate()}" +
                                    $"\nCountry of Origin: {CountryOfOrigin()}";
        }
    }
}
