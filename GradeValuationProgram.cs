using System;

class Challenge {
  static void Main() {
    int notesRead = 0;
    bool option;
    double x = 0;
      
    while (notesRead < 2) {
      option = true;
      double note = double.Parse(Console.ReadLine());

      if (note < 0 || note > 10) {
        Console.WriteLine("invalid note");
      } else if (notesRead == 0) {
        x = note;
        notesRead++;
      } else if (notesRead == 1) {
        double average = (x + note) / 2;

        Console.Write("average = ");
        Console.WriteLine(average.ToString("N2"));
        
        while (option == true){
          Console.WriteLine("new calculation (1-yes 2-no)");
          double res = double.Parse(Console.ReadLine());

          if (res ==  1) {
            option = false;
            notesRead = 0;
          } else if (res == 2) {
            option = false;
            notesRead++;
          }
        }
      } 
    }
  }
}
