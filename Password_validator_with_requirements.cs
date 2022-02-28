using System;
using System.Text.RegularExpressions;

class Challenge {
  static void Main() {
    while (true) {
      string password = Console.ReadLine();

      if (string.IsNullOrEmpty(password)) break;
      Regex rx = new Regex("^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])[a-zA-Z0-9]{6,32}$");
      Match match = rx.Match(password);
      
      if (match.Success) {
        Console.WriteLine("valid password.");
      } else {
        Console.WriteLine("invalid password.");
      }
    }
  }
}
