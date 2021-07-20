using System;
using System.Collections.Generic;
using System.Linq;


namespace CodeWarsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] phoneNum = { 7, 2, 7, 6, 1, 2, 7, 2, 9, 2 };
            Console.WriteLine(CreatePhoneNumber(phoneNum));
           

            string words = "is2 Thi1s T4est 3a";            
            Console.WriteLine(Order(words));

           
            Console.WriteLine(SquareDigits(9119));

            ToCamelCase("yo-yo-yo");
        }

        //Write a function that accepts an array of 10 integers (between 0 and 9), that returns a string of those numbers in the form of a phone number.
        public static string CreatePhoneNumber(int[] numbers)
        {
            string phoneNumber = string.Join("", numbers);

            phoneNumber = "(" + phoneNumber.Substring(0, 3) + ") " + phoneNumber.Substring(3, 3) + "-" + phoneNumber.Substring(6, 4);

            return phoneNumber;
        }

        //Your task is to sort a given string. Each word in the string will contain a single number. This number is the position the word should have in the result.
        public static string Order(string words)
        {
            return string.Join(" ", words.Split().OrderBy(word => word.SingleOrDefault(char.IsDigit)));
        }


        // In this kata, you are asked to square every digit of a number and concatenate them.
        public static int SquareDigits(int numbers)
        {
            char[] charNumArray = numbers.ToString().ToCharArray();

            List<string> squaredNumList = new List<string>();

            foreach(char num in charNumArray)
            {
                int charToIntNum = int.Parse(num.ToString());
                int squaredNum = charToIntNum * charToIntNum;
                string squaredString = squaredNum.ToString();
                squaredNumList.Add(squaredString);
            }

            int combinedNumbers = int.Parse(String.Join("", squaredNumList));          

            return combinedNumbers;
        }

        //Complete the method/function so that it converts dash/underscore delimited words into camel casing.
        //The first word within the output should be capitalized only if the original word was capitalized
        //(known as Upper Camel Case, also often referred to as Pascal case).

        public static string ToCamelCase(string str)
        {
            List<char> stringList = str.ToList();

            int index = 0;

            List<int> indexList = new();

            foreach (char letter in stringList)
            {
                if(letter == '-')
                {
                    indexList.Add(index);
                    stringList.Remove()
                }
                index++;
            }
            
            foreach(int i in indexList)
            {
                _ = i - 1;
            }


           
            return str;
        }
    }
}