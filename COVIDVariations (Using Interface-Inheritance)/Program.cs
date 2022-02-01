using System;
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
    class Program // Program class: Houses all functions that are meant to be seen by compiler directly
    {

        static void Main(string[] args)
        {
            while (true)
            { 
                Helper.ColorCyan("\nCOVID 19 Information Chart");
                Helper.ColorYellow("1. Standard" +
                                 "\n2. Delta" +
                                 "\n3. Omicron" +
                                 "\n4. Exit" +
                                 "\n");

                COVID covid = new COVID();

                switch (Helper.ValidateNum(1, 4))
                {
                    case 1:
                        covid.Strain = "Standard";
                        Standard standard = new Standard(covid.ToString());
                        Helper.ColorGreen(standard.ToString());
                        break;
                    case 2:
                        covid.Strain = "Delta";
                        Delta delta = new Delta(covid.ToString());
                        Helper.ColorGreen(delta.ToString());
                        break;
                    case 3:
                        covid.Strain = "Omicron";
                        Omicron omicron = new Omicron(covid.ToString());
                        Helper.ColorGreen(omicron.ToString());
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                }

            }


        }
    }
}
