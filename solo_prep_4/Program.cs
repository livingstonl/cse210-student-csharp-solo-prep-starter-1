// using System;
// using System.Collections.Generic;
// using System.Linq;

// namespace solo_prep_4
// {
//     class Program
//     {
//         static void Main(string[] args)

//         {
//             List<int> number_list = new List<int>();
//             int number = 0;

//             do
//                 {
//                     Console.Write("Give me a number: ");
//                     string input = Console.ReadLine();
//                     number = int.Parse(input);
//                     numberList.Add(number);

//                 }   
//             while(number != 0);    

//             {
//                 int sum =  numberList.Sum();
//                 // float avg = numberList.Sum()/numberList.Count();
//                 float avg =  (float
//                 )number_list.Sum()/ numberList.Count();
//                 int max = numberList.Max();
//                 int min = numberList.Min();
//                 // Console.WriteLine(sum);
//                 // Console.WriteLine(numberList.Count);
//                 Console.WriteLine($"The sum of the number list is {sum}");
//                 Console.WriteLine($"The average of the number list is {avg}");
//                 Console.WriteLine($"Maximum number: {max} and the min: {min}");

//             }

//         }
//     }
// }


using System;
using System.Collections.Generic;

namespace solo_prep_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            
            // Please note we could use a do-while loop here instead
            int userNumber = -1;
            while (userNumber != 0)
            {
                Console.Write("Enter a number (0 to quit): ");
                
                string userResponse = Console.ReadLine();
                userNumber = int.Parse(userResponse);
                
                numbers.Add(userNumber);
            }

            // Part 1: Compute the sum
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            Console.WriteLine($"The sum is: {sum}");

            // Part 2: Compute the average
            float average = (float)sum / numbers.Count;
            Console.WriteLine($"The average is: {average}");

            // Part 3: Find the max
            // There are several ways to do this, such as sorting the list
            
            int max = numbers[0];

            foreach (int number in numbers)
            {
                if (number > max)
                {
                    // if this number is greater than the max, we have found the new max!
                    max = number;
                }
            }

            Console.WriteLine($"The max is: {max}");

            int min = numbers[0];
            
            foreach (int number in numbers)
            
            {    if (number < min)

                {    
                    min = number;
                }
            }        

            Console.WriteLine($"The min is: {min}");        

        }
    }
}
