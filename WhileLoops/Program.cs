﻿
Random rnd = new Random();
int cpuRandom;

bool loopActive = true; //bool - true/false

while (loopActive)
{
    cpuRandom = rnd.Next(1, 4);
    Console.WriteLine("Make a guess. Enter number 1-4");
    int userNumber = Int32.Parse(Console.ReadLine());
    if (userNumber ==cpuRandom)
    {
        Console.WriteLine("Congratulation, you won!");
        //loopActive = false;
        break;
    }  else 
    {
        Console.WriteLine("Oops. Try again.");
    }
}
Console.WriteLine("Have a nice day!");