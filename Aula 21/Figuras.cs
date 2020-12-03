using System;

class MainClass {
  public static void Main (string[] args) {
    Retangulo r1 = new Retangulo(10, 20);
    Console.WriteLine(r1.CalcArea());
    Console.WriteLine(r1.CalcDiagonal());
    Console.WriteLine(r1);

    Retangulo r2 = new Quadrado(10);
    Console.WriteLine(r2.CalcArea());
    Console.WriteLine(r2.CalcDiagonal());
    Console.WriteLine(r2);

    object r3 = new Quadrado(10);
    //Retangulo r4 = new Quadrado(10);
    //Quadrado r5 = new Quadrado(10);

    Console.WriteLine((r3 as Quadrado).CalcArea());

    Triangulo t1 = new Triangulo(10, 20);
    object t2 = new Triangulo(20, 40);
    Console.WriteLine(t1);
    Console.WriteLine(t2);

    //(t2 asRetangulo).CalcArea();
    IFigura f1 = new Triangulo(10, 20);
    IFigura f2 = new Quadrado(10);
    IFigura f3 = new Retangulo(10, 20);
    Console.WriteLine(f1.CalcArea());
    Console.WriteLine(f2.CalcArea());
    Console.WriteLine(f3.CalcArea());
  }
}

interface IFigura {
  double CalcArea();
}

class Triangulo : IFigura {
  private double b, h;
  public Triangulo(double b, double h) {
    this.b = b;
    this.h = h;
  }
  public double CalcArea() {
    return b * h / 2;
  }
  public override string ToString() {
    return $"Triangulo base={b}, altura={h}";
  }

}

class Retangulo : IFigura {
  private double b, h;
  public Retangulo(double b, double h) {
    this.b = b;
    this.h = h;
  }
  public double GetBase() {
    return b;
  }
  public double GetAltura() {
    return h;
  }
  public double CalcArea() {
    return b * h;
  }
  public double CalcDiagonal() {
    return Math.Sqrt(b*b + h*h);
  }
  public override string ToString() {
    return $"Retângulo base={b}, altura={h}";
  }
}

class Quadrado : Retangulo {
  public Quadrado(double l) : base(l, l) { }
  public override string ToString() {
    return $"{base.ToString()} Quadrado lado={GetBase()}";
  }
}

