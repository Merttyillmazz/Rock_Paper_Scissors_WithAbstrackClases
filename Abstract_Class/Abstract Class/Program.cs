using Abstract_Class;
using System;
using System.Runtime.CompilerServices;
class Program
{
    static void Main(string[] args)
    {
        string welcome = "welcome to rock paper scissors game";
        foreach (char letter in welcome)
        {
            Console.Write(letter);
            Thread.Sleep(100);
        }
        Console.Write("\n");
        
        GAme gAme = new GAme();
        gAme.start();
    }
}