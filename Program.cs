using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace Rock__Paper__Scissors_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] options = { "Rock", "Paper", "Scissors" };
            Random random = new Random();
            
            Console.WriteLine($"ROCK, PAPER, SCISSORS GAME");
            Console.WriteLine();
           
            int countWin;
            int countLose;         
            while(true)
            {
                countWin = 0;
                countLose = 0;
                while (true)
                {
                    int index = random.Next(0, 3);
                    string pcGuess = options[index];
                    Console.WriteLine("Rock, paper, scissors shoot!");
                    string yourChoice = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine($"You got: {yourChoice}");
                    Console.WriteLine();
                    Console.WriteLine($"Pc got: {pcGuess}");
                    countWin = Win(yourChoice, pcGuess, countWin);
                    countLose = Lose(yourChoice, pcGuess, countLose);
                    Count(yourChoice, pcGuess, countWin, countLose);
                    if (countWin == 3)
                    {
                        Console.WriteLine("Congratulations! You just won!");
                        Console.WriteLine("Wanna play again?(Y/N)");
                        Console.WriteLine();
                        string choice = Console.ReadLine();
                        choice = choice.ToUpper();
                        if (choice == "Y")
                        {
                            break;
                        }
                        else if (choice == "N")
                        {
                            Console.WriteLine();
                            Console.WriteLine("Thank you for playing!");
                            return;
                        }                        
                        break;
                    }
                    else if (countLose == 3)
                    {
                        Console.WriteLine("Sry, u just lost :(");
                        Console.WriteLine("Wanna play again?(Y/N)");
                        Console.WriteLine();
                        string choice = Console.ReadLine();
                        choice = choice.ToUpper();
                        if(choice == "Y")
                        {
                            break;
                        }
                        else if(choice == "N")
                        {
                            Console.WriteLine();
                            Console.WriteLine("Thank you for playing!");
                            return;
                        }
                    }
                }
            }
            
        }
        static void Count(string choice,string pc,int countWin,int lose)
        {
            if(pc == "Rock")
            {
                if(choice == "Rock")
                {
                    Console.WriteLine();
                    Console.WriteLine("Draw! Keep going!");
                    return;
                }
                else if(choice == "Paper")
                {
                    Console.WriteLine();
                    Console.WriteLine($"Count of win: {countWin}");
                    Console.WriteLine();
                }
                else if(choice == "Scissors")
                {
                    Console.WriteLine();
                    Console.WriteLine($"Count of losts: {lose}");
                    Console.WriteLine();
                }
            }
            else if (pc == "Paper")
            {
                if (choice == "Rock")
                {
                    Console.WriteLine();
                    Console.WriteLine($"Count of losts: {lose}");
                    Console.WriteLine();
                }
                else if (choice == "Paper")
                {
                    Console.WriteLine();
                    Console.WriteLine("Draw! Keep going!");
                    return;                   
                }
                else if (choice == "Scissors")
                {
                    Console.WriteLine();
                    Console.WriteLine($"Count of win: {countWin}");
                    Console.WriteLine();
                }
            }
            else if (pc == "Scissors")
            {
                if (choice == "Rock")
                {
                    Console.WriteLine();
                    Console.WriteLine($"Count of win: {countWin}");
                    Console.WriteLine();
                }
                else if (choice == "Paper")
                {
                    Console.WriteLine();
                    Console.WriteLine($"Count of losts: {lose}");
                    Console.WriteLine();
                }
                else if (choice == "Scissors")
                {
                    Console.WriteLine();
                    Console.WriteLine("Draw! Keep going!");
                    return;
                }
            }
        }
        static int Win(string choice,string pc,int win)
        {
            if (pc == "Rock")
            {
                if(choice == "Paper")
                {
                    win++;
                }                                                 
            }
            if (pc == "Paper")
            {
                if (choice == "Scissors")
                {
                    win++;                    
                }
            }
            if (pc == "Scissors")
            {
                if (choice == "Rock")
                {
                    win++;                  
                }               
            }
            return win;
        }
        static int Lose(string choice, string pc, int lose)
        {
            if (pc == "Rock")
            {
                if (choice == "Scissors")
                {
                    lose++;
                }
            }
            if (pc == "Paper")
            {
                if (choice == "Rock")
                {
                    lose++;
                }
            }
            if (pc == "Scissors")
            {
                if (choice == "Paper")
                {
                    lose++;
                }
            }
            return lose;
        }
    }
}
