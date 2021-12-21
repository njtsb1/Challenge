// Challenge
// Dividing X by Y
// Write an algorithm that reads 2 numbers and prints the result of dividing the first by the second. If it is not possible, show the message “impossible division” for the values ​​in question.

// Input
// The input contains an integer N. This N will be the number of integer value pairs (X and Y) that will be read next.

// Exit
// For each case, show the result of the division with one digit after the decimal point, or “division impossible” if it is not possible to perform the calculation.

using System;
	
	class DividindoXPorY 
	{    
	    static void Main(string[] args) 
	    {
	        int limit = Int32.Parse(Console.ReadLine());
	            for (int i = 0; i < limit; i++)
	            {
	                string[] line = Console.ReadLine().Split(" ");
	                double X = double.Parse(line[0]);
	                double Y = double.Parse(line[1]);
	                
	                if (Y == 0)
	                {
	                    Console.WriteLine("divisao impossivel");
	                }
	                else
	                {
	                    double divisao = (double)X / Y;
	                    
	                    if (divisao < 0 && divisao > -0.5)
	                    {
	                        Console.WriteLine("-0.0");
	                    }
	                    else
	                    {
	                        Console.WriteLine(Math.Round(divisao, 1).ToString("N1"));
	                    }
	                }
	            }
	    }
}
