using System;

class MainClass {
  public static void MostrarNumero(int x, int y) {
    if (x > y) return;
    Console.WriteLine(x);
    MostrarNumero(x + 1, y);
  }
  public static long Fatorial(int x) {
    if (x == 1) return 1;
    return x * Fatorial(x - 1);
  }
  public static void Main (string[] args) {
    //MostrarNumero(1, 10);
    long f = Fatorial(int.Parse(Console.ReadLine()));
    Console.WriteLine(f);
  }
}  
