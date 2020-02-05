//lab 01
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("testing");
            string department = "CSE";
            Console.WriteLine("Hello "+department);
            Console.WriteLine("Hello {0}",department);
            Console.WriteLine($"Hello {department}");

            string fileName1 = @"E:\softwear\MATLAB R2018a Win64 Crack\R2018a\bin\win64";
            string fileName2 = "E:\\softwear\\MATLAB R2018a Win64 Crack\\R2018a\\bin\\win64";
            string quote = @"He said, ""this is the last chance""";

            Console.WriteLine(fileName1);
            Console.WriteLine(fileName2);
            Console.WriteLine(quote);
            Console.ReadKey();

            //number properties
            int max = Int32.MaxValue;
            int min = Int32.MinValue;
            Console.WriteLine($"Min value: {min} and Max value {max}");

            //type casting
            int intNumb = 10;
            double doubleNumb = 10.5;
            int n1 = Convert.ToInt32(doubleNumb);

            Console.WriteLine("Int to Double conversion "+ Convert.ToDouble(intNumb));
            Console.WriteLine("Converted already Double to Int "+n1);
            Console.WriteLine("Double to Int conversion "+ Convert.ToInt32(intNumb));

            //calculate area of a circle
            double radius = 2.5;
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"Area of a circle of radius {radius} : {area}");

            //if-else statements

            //ternary operation
            string department = "CSE";
            string message = department == "CSE" ? "Hello CSE" : "Other Department";
            Console.WriteLine("From ternary operation: "+message);
            Console.WriteLine("_________________________________");

            //null check
            String name = "";
            if (String.IsNullOrWhiteSpace(name))
            {
               Console.WriteLine("Name is Empty/Null");
            }
            else
            {
               Console.WriteLine($"Name is {name}");
            }

            //null check using ternary operation
            name = String.IsNullOrWhiteSpace(name) ? "Empty/Null" : name;
            Console.WriteLine("Ternary => Name is "+name);

            name = name ?? "Empty/Null";
            Console.WriteLine($"Null Coalescing => {name}");

            //loop
            var numbers = new int[] { 1, 2, 3 };
            Console.WriteLine("Inside for loop");
            int sum = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
               sum += numbers[i];
            }
            Console.WriteLine($"Sum is: {sum}");
            Console.WriteLine("Inside while loop");
            sum = 0;
            int j = 0;
            while (j < numbers.Length)
            {
               sum += numbers[j];
               j++;
            }
            Console.WriteLine($"Sum is: {sum}");
            Console.WriteLine("Inside froeach loop");
            sum = 0;
            foreach(var number in numbers)
            {
               sum += number;
            }
            Console.WriteLine($"Sum is: {sum}");

            //generic  syntax
            Console.WriteLine(Sum<int>(1,2));
            Console.WriteLine(Sum<double>(2.9,3.9));
            Console.WriteLine(Sum<string>("10","20"));

            var deptNames = new List<string>() { "CSE", "EEE", "ME" };
            Console.WriteLine("Lowercase: ");
            foreach(var deptName in deptNames)
            {
                Console.WriteLine(deptName.ToLower()+"\n");
            }

            var letters = new List<string>();
            letters.Add("A");
            letters.Add("B");
            letters.Add("C");
            foreach(var letter in letters)
            {
                Console.WriteLine(letter);
            }
            Console.WriteLine("After removing letters: ");

            letters.Remove("C");
            foreach(var letter in letters)
            {
                Console.WriteLine(letter);
            }

            var newLetters = new List<string>() { "P", "Q", "R" };
            letters.Insert(0, "Z");
            letters.InsertRange(0, newLetters);
            foreach(var letter in letters)
            {
                Console.WriteLine(letter);
            }
            Console.WriteLine("After sorting the list: ");

            letters.Sort();
            for(int i = 0; i < letters.Count; i++)
            {
                Console.WriteLine(letters[i]);
            }
        }

        //generic function
        public static double Sum<T>(T num1,T num2)
        {
           double number1 = Convert.ToDouble(num1);
           double number2 = Convert.ToDouble(num2);

           return number1 + number2;
        }
    }
}
