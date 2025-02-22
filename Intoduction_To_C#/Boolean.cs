using System;


namespace HealthCareDiagnosticAssistant
{
    class Boolean
    {
        static void Main(string[] args)
        {
            //EXAMPLE 1

            //patient symptoms
            bool hasFever = true;
            bool hasCough = true;

            // expression to check the condition
            if (hasFever && hasCough)
            {
                Console.WriteLine("The patient might have the flu.Recoment examination");
            }
            else
            {
                Console.WriteLine("No flu symptoms detected");
            }

            Console.WriteLine("\n");

            //EXAMPLE 2

            // patient symptoms
            bool hasfever = true;
            bool hascough = true;
            bool hasShortnessOfBreath = false;
            bool hasFatigue = true;

            if (hasfever && hascough && (hasShortnessOfBreath || hasFatigue))
            {
                Console.WriteLine("The patient shows symptoms consistent with COVID-19.Recommended testing");
            }
            else
            {
                Console.WriteLine("symptoms do not indicate COVID_19.");
            }

            Console.WriteLine("\n");

            // EXAMPLE 3
            int patientAge = 65;
            bool hasHighBloodPressure = true;
            bool hasDiabetes = false;

            // checking if the patient is at high risk
            if (patientAge >= 60 && (hasHighBloodPressure || hasDiabetes))
            {
                Console.WriteLine("The patient is at high risk.Recomend high care.");
            }
            else
            {
                Console.WriteLine("Patient is not classified as high risk");
            }

            Console.WriteLine("\n");

            //EXAMPLE 4
            int temperature = 39;
            if (IsFever(temperature))
            {
                Console.WriteLine("Fever detected.Monitor closely");
            }
            else
            {
                Console.WriteLine("No fever detected");
            }


        }
        static bool IsFever(int temp)
        {
            return temp >= 38;
        }
    }
}
