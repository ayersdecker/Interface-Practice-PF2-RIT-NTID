using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVIDVariations__Using_Interface_Inheritance_
{
    class COVID
    {
        private string strain;
        public string Strain
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
        public COVID()
        {
            Strain = "UNKNOWN";
        }
        public COVID(string _strain)
        {
            Strain = _strain;
        }
        public override string ToString()
        {
            return $"{strain}";
        }
    }
}
