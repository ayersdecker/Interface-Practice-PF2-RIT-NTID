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
    class COVID // COVID class: Builds COVID without specific strain traits
    {
        private string strain;
        public string Strain // Property to set strain field
        {
            get
            {
                return strain;
            }
            set
            {
                strain = value;
            }
        }
        public COVID() // Default Constructor
        {
            Strain = "UNKNOWN";
        }
        public COVID(string _strain) // Parameterized Constructor
        {
            Strain = _strain;
        }
        public override string ToString() // Adjust ToString to begin with name of Strain
        {
            return $"{strain}";
        }
    }
}
