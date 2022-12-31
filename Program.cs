using System;
using System.Collections;
using System.Collections.Generic;

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

            Hashtable studentHashTable = new Hashtable();
            foreach (Student student in students)
            {
                studentHashTable.Add(student.Id, student);
                // System.Console.WriteLine(student.Name);
            }

            Student storedStudent1 = (Student)studentHashTable[students[0].Id];
        }

        // static Hashtable arrayToHashTable(Array studentArr)
        // {
        //     Hashtable studentHashTable = new Hashtable();

        //     foreach (Student student in studentArr)
        //     {
        //         studentHashTable.Add(student.Id, student);
        //         // System.Console.WriteLine(student.Name);
        //     }

        //     // Let retrieve and print out hashtable items
        //     System.Console.WriteLine(studentHashTable);
        //     int storedStudent1 = (int)studentHashTable[0];


        //     return studentHashTable;
        // }
    }
}