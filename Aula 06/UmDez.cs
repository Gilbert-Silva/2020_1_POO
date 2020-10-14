using System;
class MainClass {
  public static void Main (string[] args) {
    int x = 11;
    while (x <= 10) {
      Console.WriteLine(x);
      x++;
    }
    Console.WriteLine("--------");
    for (x = 11; x <= 10; x++) {
      Console.WriteLine(x);
    }
    Console.WriteLine("--------");
    x = 11;
    do {
      Console.WriteLine(x);
      x++;
    } while (x <= 10);

  }
}