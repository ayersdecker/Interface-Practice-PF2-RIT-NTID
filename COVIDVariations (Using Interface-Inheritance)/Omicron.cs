using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVIDVariations__Using_Interface_Inheritance_
{
    class Omicron : COVID, IInfectionRate, ISurvivalRate, ICountryOrigin
    {
        public string InfectionRate()
        {
            return "750,000";
        }
        public string SurvivalRate()
        {
            return "99.7";
        }
        public string CountryOfOrigin()
        {
            return "South Africa";
        }
        public Omicron(string _strain)
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
