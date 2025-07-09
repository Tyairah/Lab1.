using System;

class Program
{
    static void Main(string[] args)
    {
        /*  
        Name: Tyairah Flowers
        Title: IT-1050 - Lab 1
        */

       
        Console.WriteLine("Tyairah Flowers - IT-1050 - Lab 1");

        
        int favNum = 7;
        string favLang = "C#";
        double programsWritten = 2.5;
        bool hasExperience = true;

        Console.WriteLine("Favorite Number: " + favNum);
        Console.WriteLine("Favorite Language: " + favLang);
        Console.WriteLine("Programs Written: " + programsWritten);
        Console.WriteLine("Has Experience: " + hasExperience);

        
        const string schoolName = "Cuyahoga Community College";
        Console.WriteLine("School: " + schoolName);

     
        double myDouble = 9.78;
        int myInt = (int)myDouble;

        string intToString = Convert.ToString(myInt);
        string boolToString = Convert.ToString(hasExperience);

        Console.WriteLine("Double: " + myDouble);
        Console.WriteLine("Int (casted): " + myInt);
        Console.WriteLine("Int to String: " + intToString);
        Console.WriteLine("Bool to String: " + boolToString);

       
        Console.Write("Enter your name: Tyairah Flowers ");
        string userName = Console.ReadLine();

        Console.Write("Enter your age: 20 ");
        int userAge = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Hello " + userName + "! You are " + userAge + " years old.");

       
        int num1 = 10;
        int num2 = 5;

        Console.WriteLine("Add 10: " + (num1 + 10));
        Console.WriteLine("Subtract 2: " + (num2 - 2));
        Console.WriteLine("Multiply by 3: " + (num1 * 3));
        Console.WriteLine("Divide by 2: " + (num1 / 2));
        Console.WriteLine("Modulus 2: " + (num1 % 2));

       
        float myFloat = 1.123456789f;
        double myDoubleVal = 1.123456789;

        Console.WriteLine("Float: " + myFloat);
        Console.WriteLine("Double: " + myDoubleVal);

        
        int value = 10;
        value++;
        Console.WriteLine("After increment: " + value);
        value--;
        Console.WriteLine("After decrement: " + value);
    }
}
