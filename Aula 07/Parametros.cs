using System;

class MainClass {
  public static void Main (string[] args) {
    int x = 10, y = 20;
    Metodo1(x, y);
    Console.WriteLine($"x = {x}   y = {y}");
    Metodo2(ref x, ref y);
    Console.WriteLine($"x = {x}   y = {y}");
    int c, d;
    Metodo3(out c, out d);
    Console.WriteLine($"c = {c}   d = {d}");
  }
  public static void Metodo1 (int a, int b) {
    Console.WriteLine($"a = {a}   b = {b}");
    a = 30;
    b = 40;
    Console.WriteLine($"a = {a}   b = {b}");
  }
  public static void Metodo2 (ref int a, ref int b) {
    Console.WriteLine($"a = {a}   b = {b}");
    a = 30;
    b = 40;
    Console.WriteLine($"a = {a}   b = {b}");
  }
  public static void Metodo3 (out int a, out int b) {
    a = 30;
    b = 40;
    Console.WriteLine($"a = {a}   b = {b}");
  }
}  
