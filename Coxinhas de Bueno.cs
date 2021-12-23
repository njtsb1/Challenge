// Challenge
// In 2015 a new record was achieved in the Coxinhas de Bueno de Andrada competition, where Mônica sent in 43 drumsticks in just 10 minutes, 
// passing his predecessor who managed to eat 38 drumsticks at the same time in 2014.

// The restaurant specializing in coxinhas in the small district of Bueno de Andrada, in the interior of São Paulo, organizes this competition every year, 
// but they never made it into the Guinness Book of records. For this, the restaurant needs to fill in information about the competition, 
// such as the number of drumsticks consumed by the competitors during the event.

// However, as I was told, their specialty is coxinha, not math, so can you help them? 
// Based on the total number of drumsticks consumed and the number of participants in the competition, 
// the restaurant owner needs you to develop a program to know the average amount of drumsticks that competition participants can devour.

// Ah, remember that, in exchange for your help, you can eat as many drumsticks as you can.

// Input
// The input consists of a single line containing two integers H and P (1 ≤ H, P ≤ 1000) indicating respectively the total number of drumsticks consumed and 
// the total number of participants in the competition.

// Exit
// Your program must produce a single line with a rational number representing the average number of drumsticks consumed by the participants. 
// The result must be written as a rational number with exactly two digits after the decimal point, rounded if necessary.

using System;

class Desafio {
  static void Main() {
    string[] line = Console.ReadLine().Split(" ");
    double coxinhas = int.Parse(line[0]);
    double participantes = int.Parse(line[1]);
    double media = coxinhas / participantes;
    
    Console.WriteLine(media.ToString("N2"));
  }
}
