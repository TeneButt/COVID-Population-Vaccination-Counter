using System;

namespace PopVaccinatedCalculator
{
    class Program
    {
        static void Main()
        {
            decimal Population;
            decimal AdultVaccinatedPercent;
            decimal AdultNotVaccinatedPercent;
            decimal ChildVaccinatedPercent;
            decimal ChildNotVaccinatedPercent;
            decimal AdultPopNotVaccinated;
            decimal ChildPopNotVaccinated;
            decimal TotalPopNotVaccinated;
            decimal TotalPopVaccinated;
            decimal AdultPop;
            decimal ChildPop;
            decimal AdultPopPercent;
            decimal ChildPopPercent;

            Console.WriteLine("Please enter the total population (in millions):");
            Population = Convert.ToDecimal(Console.ReadLine()); //store the given string number as a decimal

            Console.WriteLine("Please enter the percentage of adults vaccinated (without %):");
            AdultVaccinatedPercent = Convert.ToDecimal(Console.ReadLine()); 
            AdultNotVaccinatedPercent = (100 - AdultVaccinatedPercent); //work out non-vaccinated percentage of adults

            Console.WriteLine("Please enter the percentage of children vaccinated (0 if not applicable, without %):");
            ChildVaccinatedPercent = Convert.ToDecimal(Console.ReadLine());

            if (ChildVaccinatedPercent > 0) //if the entered number is more than 0
            {
                ChildNotVaccinatedPercent = (100 - ChildVaccinatedPercent); //take that number away from 100 and store it

                Console.WriteLine("Please enter the total population of adults (in millions):");
                AdultPop = Convert.ToDecimal(Console.ReadLine());
                AdultPopPercent = (AdultPop / Population) * 100; //percentage of adults in the population is worked out by dividing adult population from total population
                AdultPopPercent = Math.Round(AdultPopPercent, 2); //rounded to two decimal places

                Console.WriteLine("Please enter the total population of children (in millions):");
                ChildPop = Convert.ToDecimal(Console.ReadLine());
                ChildPopPercent = (ChildPop / Population) * 100; //percentage of children in the population is worked out by dividing child population from total population
                ChildPopPercent = Math.Round(ChildPopPercent, 2); //rounded to two decimal places

                AdultPopNotVaccinated = ((AdultPopPercent / 100) * (AdultNotVaccinatedPercent / 100)) * 100; //the number of unvaccinated adults in the population is worked out 
                AdultPopNotVaccinated = Math.Round(AdultPopNotVaccinated, 2);
                ChildPopNotVaccinated = ((ChildPopPercent / 100) * (ChildNotVaccinatedPercent / 100)) * 100; //the number of unvaccinated adults in the population is worked out
                ChildPopNotVaccinated= Math.Round(ChildPopNotVaccinated, 2);
                Console.WriteLine("Adult Pop Not Vaccinated: " + AdultPopNotVaccinated + "%"); //show the total of non vaccinated adults in the population
                Console.WriteLine("Child Pop Not Vaccinated: " + ChildPopNotVaccinated + "%"); //show the total of non vaccinated children in the population
                TotalPopNotVaccinated = AdultPopNotVaccinated + ChildPopNotVaccinated;
                TotalPopNotVaccinated = Math.Round(TotalPopNotVaccinated, 2);
                Console.WriteLine("Total Population Not Vaccinated: " + TotalPopNotVaccinated + "%"); //show the total of non vaccinated people in the population
                TotalPopVaccinated = 100 - TotalPopNotVaccinated;
                TotalPopVaccinated = Math.Round(TotalPopVaccinated, 2);
                Console.WriteLine("Total Population Vaccinated: " + TotalPopVaccinated + "%"); //show the total of vaccinated people in the population
                Console.WriteLine("Please hit Enter to close this application.");
                Console.ReadLine();
                Environment.Exit(1);
            }
            else if (ChildVaccinatedPercent == 0)
            {
                Console.WriteLine("Please enter the total population of adults (in millions):");
                AdultPop = Convert.ToDecimal(Console.ReadLine());
                AdultPopPercent = (AdultPop / Population) * 100; //percentage of adults in the population is worked out by dividing adult population from total population
                AdultPopPercent = Math.Round(AdultPopPercent, 2); //rounded to two decimal places

                Console.WriteLine("Please enter the total population of children (in millions):");
                ChildPop = Convert.ToDecimal(Console.ReadLine());
                ChildPopPercent = (ChildPop / Population) * 100; //percentage of children in the population is worked out by dividing child population from total population
                ChildPopPercent = Math.Round(ChildPopPercent, 2); //rounded to two decimal places

                ChildPopNotVaccinated = ChildPopPercent; //if no value is entered, value is set to the whole population of children to be included in calculations later

                AdultPopNotVaccinated = ((AdultPopPercent / 100) * (AdultNotVaccinatedPercent / 100)) * 100; //the number of unvaccinated adults in the population is worked out 
                AdultPopNotVaccinated = Math.Round(AdultPopNotVaccinated, 2);
                ChildPopNotVaccinated = Math.Round(ChildPopNotVaccinated, 2);

                Console.WriteLine("Adult Pop Not Vaccinated: " + AdultPopNotVaccinated + "%"); //show the total of non vaccinated adults in the population
                Console.WriteLine("Child Pop Not Vaccinated: " + ChildPopNotVaccinated + "%"); //show the total of non vaccinated children in the population
                TotalPopNotVaccinated = AdultPopNotVaccinated + ChildPopNotVaccinated;
                TotalPopNotVaccinated = Math.Round(TotalPopNotVaccinated, 2);
                Console.WriteLine("Total Population Not Vaccinated: " + TotalPopNotVaccinated + "%"); //show the total of non vaccinated people in the population
                TotalPopVaccinated = 100 - TotalPopNotVaccinated;
                TotalPopVaccinated = Math.Round(TotalPopVaccinated, 2);
                Console.WriteLine("Total Population Vaccinated: " + TotalPopVaccinated + "%"); //show the total of vaccinated people in the population
                Console.WriteLine("Please hit Enter to close this application.");
                Console.ReadLine();
                Environment.Exit(1);
            }
        }
    }
}
