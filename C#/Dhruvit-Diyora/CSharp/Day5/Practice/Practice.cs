using System;
using System.Collections.Generic;

namespace Day5
{
    class Practice
    {
        static void Main(string[] args)
        {
            //1. Create a list which will store 5 student names and then display it search it index number
            string[] arr = new string[10];
            int i;

            Console.Write("Enter 5 students name :\n");
            for (i = 0; i < 5; i++)
            {
                Console.Write("Student - {0} : ", i);
                arr[i] = Convert.ToString(Console.ReadLine());
            }

            Console.Write("\nStudents' names are: \n");
            for (i = 0; i < 10; i++)
            {
                Console.Write("{0} \n ", arr[i]);
            }
            Console.Write("\n");

            //2. Create a stack which will store Age of person and display it last in first out order.

            Stack<int> numbers = new Stack<int>();
            numbers.Push(18);
            numbers.Push(21);
            numbers.Push(56);
            numbers.Push(48);
            numbers.Push(6);

            foreach (var item in numbers)
                Console.Write("Age is: " + item + "\n");


            //3. Store a product information in map object. Key will be a product item and value will be the price of that product. Search the product by product name.

            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            dictionary.Add("Football Shoes", 4860);
            dictionary.Add("Football", 5160);
            dictionary.Add("Football Jersey", 1920);
            dictionary.Add("Football Shorts", 1232);
            dictionary.Add("Football Shin-pads", 800);


            // See whether Dictionary contains this string.
            if (dictionary.ContainsKey("Football"))
            {
                int value = dictionary["Football"];
                Console.WriteLine("The price is ₹" + value);
            }
            else
            {
                Console.WriteLine("Key not found!");
            }
        }
    }
}
