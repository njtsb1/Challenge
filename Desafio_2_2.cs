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