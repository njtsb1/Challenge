// Challenge
// In an episode of the acclaimed series The Big Ban Theor two legions, Sheldon and Raj, discuss which of the two is better: the Saturn 3 movie or the Deep Space 9 series. 
// -Paper-Scissors. However, Sheldon argues that if the parties involved know each other, between 75% and 80% of Stone-Paper-Scissors disputes end up in a tie, and then suggests the Stone-Paper-Scissors-Lizard-Spock.

// The rules of the proposed game are:

// the scissors cut the paper;
// the paper wraps the stone;
// the stone crushes the lizard;
// the lizard poisons Spock;
// Spock destroys the scissors;
// the scissors decapitate the lizard;
// the lizard eats the paper;
// the role disputes Spock;
// Spock vaporizes the stone;
// the stone breaks the scissors.
// Knowing the characters, we know that if Sheldon won, he would scream victory with a "Bazinga!" If Raj won, Sheldon would accuse him of cheating. 
// Now, if there was a tie, Sheldon wouldn't rest and insisted they play again until it's decided. Knowing these actions, make a program that prints Sheldon's likely reaction.

// Input
// Input consists of a series of test cases. The first line contains a positive integer T (T ≤ 100), which represents the number of test cases. 
// Each test case is represented by a line of input, containing the choices of Sheldon and Raj, respectively, separated by a blank space. 
// Possible choices are game characters: rock, paper, scissors, lizard and Spock.

// Exit
// For each test case, the message "Case #t: R" must be printed, where t is the number of the test case (whose count starts at number one) and R is one of Sheldon's three possible reactions: "Bazinga! ", "Raj cheated!", or "Again!".

using System;

class Desafio {
  static void Main() {
    int limit = int.Parse(Console.ReadLine());

    for (int i = 1; i <= limit; i++) {
      if (i > 100) return;
      
      string[] line = Console.ReadLine().Split(" ");
      string sheldon = line[0].ToLower();
      string raj = line[1].ToLower();

      switch (sheldon) {
        case "pedra":
          switch (raj) {
            case "lagarto":
            case "tesoura":
              Console.WriteLine("Caso #" + i + ": Bazinga!");
              break;
            case "pedra":
              Console.WriteLine("Caso #" + i + ": De novo!");
              break;
            default:
              Console.WriteLine("Caso #" + i + ": Raj trapaceou!");
              break;
          }
          break;
        case "papel":
          switch (raj) {
            case "pedra":
            case "spock":
              Console.WriteLine("Caso #" + i + ": Bazinga!");
              break;
            case "papel":
              Console.WriteLine("Caso #" + i + ": De novo!");
              break;
            default:
              Console.WriteLine("Caso #" + i + ": Raj trapaceou!");
              break;
          }
          break;
        case "tesoura":
          switch (raj) {
            case "papel":
            case "lagarto":
              Console.WriteLine("Caso #" + i + ": Bazinga!");
              break;
            case "tesoura":
              Console.WriteLine("Caso #" + i + ": De novo!");
              break;
            default:
              Console.WriteLine("Caso #" + i + ": Raj trapaceou!");
              break;
          }
          break;
        case "lagarto":
          switch (raj) {
            case "spock":
            case "papel":
              Console.WriteLine("Caso #" + i + ": Bazinga!");
              break;
            case "lagarto":
              Console.WriteLine("Caso #" + i + ": De novo!");
              break;
            default:
              Console.WriteLine("Caso #" + i + ": Raj trapaceou!");
              break;
          }
          break;
        case "spock":
          switch (raj) {
            case "tesoura":
            case "pedra":
              Console.WriteLine("Caso #" + i + ": Bazinga!");
              break;
            case "spock":
              Console.WriteLine("Caso #" + i + ": De novo!");
              break;
            default:
              Console.WriteLine("Caso #" + i + ": Raj trapaceou!");
              break;
          }
          break;
        default:
          break;
      }
    }
  }
}
