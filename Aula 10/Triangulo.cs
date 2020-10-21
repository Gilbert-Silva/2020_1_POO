using System;

class MainClass {
  public static void Main (string[] args) {
    Triangulo x = new Triangulo(10, 20);
    //x.SetBase(10);
    //x.SetAltura(20);
    Console.WriteLine(x.CalcArea());
    Console.WriteLine(x);
  }
}  

class Triangulo : Object {
  private double b, h;
  public Triangulo() { }
  public Triangulo(double b, double h) {
    if (b > 0) this.b = b;
    if (h > 0) this.h = h;
  }
  public void SetBase(double v) {
    if (v > 0) b = v;
  }
  public void SetAltura(double v) {
    if (v > 0) h = v;
  }
  public double GetBase() {
    return b;
  }
  public double GetAltura() {
    return h;
  }
  public double CalcArea() {
    double area = b * h / 2;
    return area;
  }
  public override string ToString() {
    return $"Base = {b}, Altura = {h}";
  }
}

