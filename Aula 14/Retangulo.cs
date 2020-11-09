using System;

class MainClass {
  public static void Main (string[] args) {
    Retangulo2 r = new Retangulo2();
    //r.SetBase(10);
    r.Base = 10;
    r.Altura = 20;
    //r.GetBase()
    Console.WriteLine(r.Base);
    Console.WriteLine(r.Altura);
    Console.WriteLine(r.Area);
    Console.WriteLine(r.Diagonal);
    //Console.WriteLine(r.CalcArea());
  }
}

class Retangulo 
{
  private double b, h;

  public double Base {
    get { return b; }
    set { if (value > 0) b = value; }
  }
  public double Altura {
    get => h;
    set => h = value > 0 ? value : 0;
  }
  public double Area {
    get => b * h;
  }
  public double Diagonal {
    get => Math.Sqrt(b*b + h*h);
  }
  public double CalcArea() => b * h;
}

class Retangulo2 {
  public double Base { get; set; }
  public double Altura { get; set; }
  public double Area {
    get => Base * Altura;
  }
  public double Diagonal {
    get => Math.Sqrt(Base*Base + Altura*Altura);
  }
}