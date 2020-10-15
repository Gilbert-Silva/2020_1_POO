using System;

class MainClass {
  public static void Main (string[] args) {
    int x;
    Console.WriteLine("Digite um valor inteiro");
    while(int.TryParse(Console.ReadLine(), out x) == false) {
      Console.WriteLine("Valor é inválido");
      Console.WriteLine("Digite novamente");
    }
    Console.WriteLine(x);
  }
}