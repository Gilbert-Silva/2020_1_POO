using System;

class MainClass {
  public static void Main (string[] args) {
    double bx = 10;
    double hx = 20;
    string cx = "Azul";
    Triangulo x = new Triangulo(bx, hx, cx);
  }
}

class Triangulo {
  private double b, h;
  private string c;

  public Triangulo(double b, double h, string c) {
    this.b = b;
    this.h = h;
    this.c = c;
  }
}
