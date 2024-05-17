using System;

public class Program
{
    public static void Main(string[] args)
    {
        Student student = new Student();
        Console.WriteLine("----Student Details----");
        Console.Write("Enter the name of the student: ");
        student.Name = Convert.ToString(Console.Read());
        Console.Write("Enter the age of the student: ");
        student.Age = Convert.ToInt32(Console.ReadLine());
        student.Address = Convert.ToString(Console.Read()); 
        Console.Write("Enter the faculty of the student: ");
        student.Faculty =Convert.ToString(Console.Read());
        Console.WriteLine("\n----Entered Student Details----");
        Console.WriteLine($"Name: {student.Name}");
        Console.WriteLine($"Age: {student.Age}");
        Console.WriteLine($"Address: {student.Address}");
        Console.WriteLine($"Faculty: {student.Faculty}");
    }
}
