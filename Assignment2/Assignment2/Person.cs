﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public Person Spouse;

        //static variable, sum of all ages
        public static double SumOfAges;

        public void AskAge()
        {
            Console.Write("How old are you? ");
            this.Age = int.Parse(Console.ReadLine());
            SumOfAges += this.Age;
        }
        

        public string GetFullName()
        {
            Console.Write("What is your first name? ");
            this.FirstName = Console.ReadLine();
            Console.Write("What is your last name? ");
            this.LastName = Console.ReadLine();
            return GetFullName();
        }

        //are you married?

        //void PrintNameandAge()
        

    }
}