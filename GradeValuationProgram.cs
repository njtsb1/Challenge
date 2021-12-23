using System;

class Desafio {
  static void Main() {
    int notasLidas = 0;
    bool opcao;
    double x = 0;
      
    while (notasLidas < 2) {
      opcao = true;
      double nota = double.Parse(Console.ReadLine());

      if (nota < 0 || nota > 10) {
        Console.WriteLine("nota invalida");
      } else if (notasLidas == 0) {
        x = nota;
        notasLidas++;
      } else if (notasLidas == 1) {
        double media = (x + nota) / 2;

        Console.Write("media = ");
        Console.WriteLine(media.ToString("N2"));
        
        while (opcao == true){
          Console.WriteLine("novo calculo (1-sim 2-nao)");
          double res = double.Parse(Console.ReadLine());

          if (res ==  1) {
            opcao = false;
            notasLidas = 0;
          } else if (res == 2) {
            opcao = false;
            notasLidas++;
          }
        }
      } 
    }
  }
}