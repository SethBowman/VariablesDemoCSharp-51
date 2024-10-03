namespace VariablesDemoCSharp_51;

class Program
{
    static void Main(string[] args)
    {
        //Variables
        //camelCase for variable names - everyOtherWordStartsWithCapital
        
        //Number types
        
        //Declaring of a variable (creation of a variable)
        int wholeNumber;
        
        //Initializing a variable (giving a value to a variable)
        wholeNumber = 5;
        
        //Or do both
        //Declaring and initializing
        int newWholeNumber = 100;

        double average = 99.83;

        decimal myWallet = 500.00m;
        
        //Word types

        string ourClass = "CSharp-51";

        char initial = 'S';
        
        //Fact type

        bool isCoding = true;
        
        //String interpolation

        //string message = $"Our class is {ourClass} and has an average of {average}.";

        //Console.WriteLine(message);
        
        //Take user input

        Console.WriteLine("Give me your name:");

        string userName = Console.ReadLine();

        Console.WriteLine($"Hello, {userName}!");
    }
}