using static System.Console;

internal class Program
{
    private static void Main(string[] args)




{
 
 /*
    {
        Console.Write("Enter a number between 0 and 255: ");
        string input1 = Console.ReadLine();
        int firstNumber = Int16.Parse(s: input1);
             
        Console.Write("Enter another number between 0 and 255: ");
        string input2 = Console.ReadLine();
        int secondNumber = Int16.Parse(s: input2);

        Console.WriteLine(
        $"{firstNumber} divided by {secondNumber} is {firstNumber / secondNumber}");
   }
    
*/

{
        Clear();
        
        int input1 = 0;

    do
    {
       Console.WriteLine("Enter a number between 0 and 255; ");
        try
        {
            input1 = int.Parse(ReadLine());
        }
        catch (ArithmeticException ex)
        {            
            WriteLine($"{ex.GetType()} says {ex.Message}");
        }
        catch (Exception ex)
        {
            WriteLine($"{ex.GetType()} says {ex.Message}");
        }
        if (input1 <= 0 || input1 >=255)
        {
            WriteLine("The number is not in range");
        }
    } 
    while (input1 <= 0 || input1 >=255);

     int input2 = 0;
 
    do
    {
        WriteLine("Enter another number between 0 and 255; ");
        try
        {
            input2 = int.Parse(Console.ReadLine());
        }
        catch (ArithmeticException ex)
        {            
            WriteLine($"{ex.GetType()} says {ex.Message}");
        }
        catch (Exception ex)
        {
            WriteLine($"{ex.GetType()} says {ex.Message}");
        }
        if (input2 <= 0 || input2 >=255)
        {
            WriteLine("The number is not in range");
        }

    } 
    while (input2 <= 0 || input2 >=255);

    Console.WriteLine(
        $"{input1} divided by {input2} is {input1 / input2}");
}
}      

}
        
 
