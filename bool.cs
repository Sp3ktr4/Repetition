using System;

class Program 
{
    static void Main(string[] args) 
    {
        int number = 5;
        bool isEven = number % 2 == 0;

        if (isEven) 
        {
            Console.WriteLine(number + " is even.");
        } 
        
        else 
        {
            Console.WriteLine(number + " is odd.");
        }
    }
}