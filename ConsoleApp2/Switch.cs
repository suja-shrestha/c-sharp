public class Switch 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("----Day Finder----");
        Console.WriteLine("Enter the number from 1 - 7");
       int day = Convert.ToInt32(Console.ReadLine());
        switch (day)
        {
            case 1:
                Console.WriteLine("The day is : sunday");
                break;
            case 2:
                Console.WriteLine("The day is : monday");
                break;
            case 3:
                Console.WriteLine("The day is : tuesday");
                break;
            case 4:
                Console.WriteLine("The day is : wednesday");
                break;
            case 5:
                Console.WriteLine("The day is : thursday");
                break;
            case 6:
                Console.WriteLine("The day is : Friday");
                break;
            case 7:
                Console.WriteLine("The day is : saturday");
                break;
            default:
                Console.WriteLine("----invalid input----");
                break;
        }
    }
}