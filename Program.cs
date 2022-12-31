using System;
using System.Collections.Generic;

namespace UdemyPractice
{
    class Program
    {

        static List<int> Solution(List<int> mylist)
        {
            // write a method that returns a list of even integer numbers between 100 and 170
            List<int> result = new List<int>();

            foreach (int num in mylist)
            {
                if (num <= 170)
                {
                    result.Add(num);
                }
            }


            return result;
        }
        static void Main(string[] args)
        {
            List<int> inputList = new List<int> { 100, 102, 104, 106, 108, 110, 114, 160, 170, 180 };
            List<int> result = Solution(inputList);

            foreach (int num in result)
            {
                System.Console.WriteLine(num);
            }
            // System.Console.WriteLine(inputList[2]);
        }
    }
}