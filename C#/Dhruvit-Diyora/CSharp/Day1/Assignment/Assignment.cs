using System;

namespace Day1
{
    class Assignment
    {


        enum weekdays
        {
            Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
        };

        static void Main(string[] args)
        {

            //Assignment-1: Print sum of all the even numbers

            int i, num, sum = 0;

            // Reading number
            Console.Write("Enter any number: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (i = 2; i <= num; i += 2)
            {
                //Adding current even number to sum variable
                sum += i;
            }
            Console.WriteLine("Sum of all even numbers between 1 to " + num + " is: " + sum);

            Console.ReadLine();


            //Assignment-2: Store your name in one string and find out how many vowel characters are there in your name.

            string myStr;
            int len, vowel_count, cons_count;

            myStr = "Dhruvit";

            vowel_count = 0;
            cons_count = 0;

            // find length
            len = myStr.Length;

            for (i = 0; i < len; i++)
            {
                if (myStr[i] == 'a' || myStr[i] == 'e' || myStr[i] == 'i' || myStr[i] == 'o' || myStr[i] == 'u' || myStr[i] == 'A'
                   || myStr[i] == 'E' || myStr[i] == 'I' || myStr[i] == 'O' || myStr[i] == 'U')
                {
                    vowel_count++;
                }
                else
                {
                    cons_count++;
                }
            }

            Console.Write("\nVowels in the string: {0}\n", vowel_count);
            Console.Write("\nConsonants in the string: {0}\n", cons_count);
            Console.ReadLine();

            //Assignment-3: Create a weekday enum and accept week day number and display week day.
            Console.WriteLine("Enter the WeekDay no. (Note: First day is Sunday & Index is 0): ");
            int userInput = int.Parse(Console.ReadLine());
            weekdays value = (weekdays)userInput;
            Console.WriteLine("WeekDay is: {0} ", value);
            Console.Read();

            //Assignment-4: Accept 10 student Name, Address, Hindi, English, Maths Marks ,do the total and compute Grade. Note do it with Array and display the result in grid format


            //Assignment-5: Accept Age from user, if age is more than 18 eligible for vote otherwise it should be displayed as not eligible. Do it with ternary operator
            int age;
            Console.Write("Input the age of the candidate : ");
            age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)
            {
                Console.Write("Sorry, You can not vote.\n");
                Console.Write("You scan vote after {0} year.\n", 18 - age);
                Console.ReadLine();
            }
            else
                Console.Write("Congratulation! You are eligible for casting your vote.");
            Console.ReadLine();
    
        }
    }
}
