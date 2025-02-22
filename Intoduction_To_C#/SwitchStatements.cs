using System;
using System.Diagnostics;

namespace StudentPortal
{
    class SwitchStatements
    {
        static void Main(string[] args)
        {
                    //EXAMPLE 1
            Console.WriteLine("select and option: ");
            Console.WriteLine("1 - View Grades");
            Console.WriteLine("2 - View Timetable");
            Console.WriteLine("3 - View Profile");
            Console.WriteLine("4 - View Log Out");
          
            // Student choice
            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    Console.WriteLine("📊 Displaying grades...");
                    break;
                case 2: Console.WriteLine("📅 Displaying timetable...");
                    break;

                    case 3:
                    Console.WriteLine("✏️ Updating profile...");
                    break;

                    case 4:
                    Console.WriteLine("🔒 Logging out...");
                    break;

                    default:
                    Console.WriteLine("❌ Invalid choice. Please select a valid option.");
                    break;
            }

            Console.WriteLine("\n");

            //EXAMPLE 2
            //Students attendance status

            string attendance = "Present";

            switch (attendance)
            {
                case "Present":
                    Console.WriteLine("You are marked as present");
                    break;

                case "Absent":
                    Console.WriteLine("You are marked as absent");
                    break;

                case "Late":
                        Console.WriteLine("You are marked as late");
                    break;

                default:
                    Console.WriteLine("Attendance status unknown. Please check with the registrar");
                    break;

            }

            Console.WriteLine("\n");

            //EXAMPLE 3
            //Check Student Grade with User Input

            Console.WriteLine("Enter the grade()A,B,C,D,F: ");
            char grade = Convert.ToChar(Console.ReadLine());

            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Exelent work!");
                    break;

                case 'B':
                    Console.WriteLine("Good job! Keep it up.");
                    break;
                case 'C':
                    Console.WriteLine("Fair. Review your coursework.");
                    break;

                case 'D':
                    Console.WriteLine(" Needs improvement");
                    break;

                case 'E':
                    Console.WriteLine(" Failed. Seek instructor help");
                    break;

                default:
                    Console.WriteLine("Invalid grade. Enter A, B, C, D, or F");
                    break;
            }
        }
    }
}
