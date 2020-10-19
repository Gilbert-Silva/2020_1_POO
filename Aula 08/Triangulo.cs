using System;

class MainClass {
  public static void Main (string[] args) {
    Triangulo x = new Triangulo();
    x.b = 10;
    x.h = 20;
    Console.WriteLine(x.CalcArea());
    Triangulo y = new Triangulo();
    y.b = -10;
    y.h = -20;
    Console.WriteLine(y.CalcArea());
  }
}  

class Triangulo {
  public double b, h;
  public double CalcArea() {
    double area = b * h / 2;
    return area;
  }
}

