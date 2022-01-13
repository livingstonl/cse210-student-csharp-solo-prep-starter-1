using System;

namespace solo_prep_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter grade percentage: ");
            string gradeResponse = Console.ReadLine();
            int grade = int.Parse(gradeResponse);
            string letter = "";
            if (grade >= 90)
            {
                letter = "A";
            }
            else if (grade < 90 || grade >=80)
            {
                letter = "B";
            }
            else if (grade < 80 || grade >=70)
            {
                letter = "C";
            }
            else if (grade < 70 || grade >=60)
            {
                letter = "D"; 
            }
            else 
            {
                letter = "F";      
            }
                
            {    
                Console.WriteLine($"Your grade is: {letter}.");
            }
            if (grade >= 70)
            {
                Console.WriteLine("You passed!");
            }
            else
            {
                Console.WriteLine("You can do this, try again!");
            }
        }
    }
}
