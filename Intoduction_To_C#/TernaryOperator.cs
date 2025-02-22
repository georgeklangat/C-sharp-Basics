using System;

namespace HealthcareDiagnosisAssistant
{
    class TernaryOperator
    {
        static void Main(string[] args)
        {
            //EXAMPLE 1

            int patientAge = 65;
            bool hasDiabetes = false;

            // ternary operator
            string riskLevel = (patientAge >= 60 && hasDiabetes) ? "High-risk patient. Ugent care needed." : "Patient not classified as high-risk.";
            Console.WriteLine(riskLevel);

            Console.WriteLine("\n");
            //EXAMPLE 2
            int symptomCount = 3;

            string severity = (symptomCount >= 3) ? "Severe condition. Immediate attention required" : "Mild condition. Monitor symptoms";
            Console.WriteLine(severity);

        }

    }
}
