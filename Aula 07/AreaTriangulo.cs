using System;

class MainClass {
  public static void Main (string[] args) {
    double x = Area.AreaTriangulo(10, 20);
    double y = Area.AreaTriangulo(5, 8);
    Console.WriteLine(x);
    Console.WriteLine(y);
  }
}  

class Area {
  public static double AreaTriangulo(double b, double h) {
    double area = b * h / 2;
    return area;
  }
}