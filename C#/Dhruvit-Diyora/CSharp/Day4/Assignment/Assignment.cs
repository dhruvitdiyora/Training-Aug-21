using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day4
{
    class Assignment
    {
        static void Main(string[] args)
        {
            //Assigment 1: Create a user defined Exception Class AgeException. If Age is less than 0 it should be thrown an exception. And you need to handle that exception in student class.

            Age a = new Age();
            try
            {
                a.displayAge();
            }
            catch (AgeException e)
            {
                Console.WriteLine("Exception Occured: {0}", e.Message);
            }
            Console.ReadLine();

            //Assigment 2: Create a user defined exception class NameException which will validate a Name and name should contain only character. If name does not contain proper value it should throw an exception. You need to handle exception in student class.
            Student newStudent = null;

            try
            {
                newStudent = new Student();
                newStudent.StudentName = "dhruvit";

                ValidateStudent(newStudent);
            }
            catch (InvalidStudentNameException ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.ReadKey();

            //Assigment 3: Create a user defined Exception DateException class which will validate date should not be less than the current date. If date is less than current date it should throw an exception.

            try
            {
                DateTime dtAdd;
                Console.WriteLine("Enter Date");
                dtAdd = Convert.ToDateTime(Console.ReadLine());
                validateDate(dtAdd);
                Console.WriteLine("You have entered correct Date");
            }
            catch (DateException e)
            {
                Console.WriteLine(e);
            }
        }

        //2
        private static void ValidateStudent(Student std)
        {
            Regex regex = new Regex("^[a-zA-Z]+$");

            if (!regex.IsMatch(std.StudentName))
                throw new InvalidStudentNameException(std.StudentName);

        }

        //3
        static void validateDate(DateTime dtAdd)
        {
            if (dtAdd.Day < DateTime.Now.Day || dtAdd.Month < DateTime.Now.Month || dtAdd.Year < DateTime.Now.Year)
            {
                throw new DateException("The entered date is not current date");
            }
        }
    }
    public class AgeException : Exception
    {
        public AgeException(string message) : base(message)
        {
        }
    }
    public class Age
    {
        int age = -6;
        public void displayAge()
        {
            if (age < 0)
            {
                throw (new AgeException("Age cannot be negative"));
            }
            else
            {
                Console.WriteLine("Age is: {0}", age);
            }
            Console.ReadLine();
        }
    }

    //2
    class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
    }

    class InvalidStudentNameException : Exception
    {
        public InvalidStudentNameException() { }

        public InvalidStudentNameException(string name)
            : base(String.Format("Invalid Student Name: {0}", name))
        {

        }
    }


    //3
    public class DateException : Exception
    {
        public DateException(String message)
            : base(message)
        {

        }
    }
}
