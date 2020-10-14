using System;
class MainClass {
  public static void Main (string[] args) {
    long f = 1;
    Console.WriteLine("Digite um número");
    int n = int.Parse(Console.ReadLine());
    for (int x = 1; x <= n; x++) {
      f = 1;
      for (int i = 1; i <= x; i++)
        f = f * i;
      Console.WriteLine($"Fatorial de {x} = {f}");  
    }
  }
}
