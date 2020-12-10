using System;

class MainClass {
  public static void Main (string[] args) {
    int x = 10;
    Console.WriteLine(x);
    Triangulo y = new Triangulo();
    Console.WriteLine(y.b);
    if (y.c == null)
      Console.WriteLine("null");

  }
}

class Triangulo {
  public double b, h;
  public string c;
}