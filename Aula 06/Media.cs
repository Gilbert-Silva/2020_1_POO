using System;
class MainClass {
  public static void Main (string[] args) {
    int n = 0;
    double s = 0;
    double x;
    Console.WriteLine("Digite os valores para cálculo da média e zero para finalizar");
    do {
      x = double.Parse(Console.ReadLine());
      s += x;
      n++;
    } while (x != 0);
    double m = s / (n - 1);
    Console.WriteLine($"Média = {m}");
  }
}