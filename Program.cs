﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace UdemyPractice
{
    class Program
    {
        /*
        Write a program that iterate through each element of the students array and insert them into a hashtable.
        If a student with the same ID already exist in the hashtable skip it and display the following error  "Sorry, a student with the same ID already Exists.
        Use ContainsKey() to check if student already exits
        */
        static void Main(string[] args)
        {
            Student[] students = new Student[5];
            students[0] = new Student(1, "Matt", 100);
            students[1] = new Student(2, "Vanessa", 100);
            students[2] = new Student(3, "Lily", 100);
            students[3] = new Student(4, "Myla", 100);
            students[4] = new Student(5, "Andy", 100);
            // System.Console.WriteLine(students[0].Id);
            // arrayToHashTable(students);

            Dictionary<int, Student> studentDictionary = new Dictionary<int, Student>();

            foreach (Student student in students)
            {
                studentDictionary.Add(student.Id, student);
                // System.Console.WriteLine(student.Name);
            }

            // get collection of the keys
            for (int i = 0; i < studentDictionary.Count; i++)
            {
                KeyValuePair<int, Student> keyValuePair = studentDictionary.ElementAt(i);
                System.Console.WriteLine("Key : {0}", keyValuePair.Key);

                // To access student data we must store instance into an object
                Student studentValue = keyValuePair.Value;
                System.Console.WriteLine("Students Name: {0}", studentValue.Name);
                System.Console.WriteLine("Students GPA: {0}", studentValue.GPA);

            }

        }

    }
}