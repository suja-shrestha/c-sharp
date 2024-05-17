using System;
 
 namespace Program{
    class Program{
        public static int sum(int a, int b){
            return a+b;
        }
        public static int diff(int a, int b){
            return a-b;
        }
        public static int multi(int a, int b){
            return a*b;

        }
        public static int div( int a, int b){
            return a/b;
        }
        public static void Main(string[] args){
            int num1, num2, sumStore, difference, multiply, difff;
            Console.Write("Enter number 1; ");
            num1= Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number 2; ");
            num2 = Convert.ToInt32(Console.ReadLine());
            sumStore = sum(num1, num2); 
            Console.WriteLine($"Sum: {sumStore}");
            difference = diff(num1, num2);
            Console.WriteLine($"difference: {difference}");
            multiply = multi(num1 , num2);
            Console.WriteLine($"multiplication: {multiply}");
            difff  = div(num1, num2);
            Console.WriteLine($"division: {div}");
        }
    }
 }