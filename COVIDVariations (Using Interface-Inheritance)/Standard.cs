using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVIDVariations__Using_Interface_Inheritance_
{
    class Standard : COVID, IInfectionRate,ISurvivalRate
    {
        public string InfectionRate()
        {
            return "500,000";
        }
        public string SurvivalRate()
        {
            return "98.8";
        }
        public string CountryOfOrigin()
        {
            return "China";
        }
        public Standard(string _strain)
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
