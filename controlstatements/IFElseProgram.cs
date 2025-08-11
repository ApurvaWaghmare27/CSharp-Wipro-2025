// See https://aka.ms/new-console-template for more information
class Program
{

static void Main()
{
    //create a program to accept a number and print the no is odd or even
    //taking a input
    string s ="dsf";

    Console.WriteLine("Enter a number");
    int number = Convert.ToInt32(Console.ReadLine());
    if(number % 2 == 0)
    {

        Console.WriteLine($"Number : {number} is Even ");
    }
    else
    {
        Console.WriteLine($"Number : {number} is not Even ");
    }
}

}


