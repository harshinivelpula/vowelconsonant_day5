﻿

public class vowelorconsonant
{
    static void Main(string[] args)
    {
        char ch;
      
        Console.WriteLine("check whether the input alphabet is a vowel or not:");
        
        Console.WriteLine("Input an Alphabet (A-Z || a-z) : ");
        ch = Convert.ToChar(Console.ReadLine().ToLower());
        int i = ch;
        if (i >= 48 && i <= 57)
        {
            Console.WriteLine("You entered a number, Please enter an alpahbet.");
        }
        else
        {
            switch (ch)
            {
                case 'a':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'i':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'o':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'u':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'e':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                default:
                    Console.WriteLine("The Alphabet is not a vowel");
                    break;
            }
        }
    }
}

