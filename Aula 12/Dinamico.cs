using System;


class MainClass {
  public static void Main (string[] args) {
    var y = new { Nome = "C#", Ano = 2000 };
    Console.WriteLine(y);
    Console.WriteLine(y.GetType());
    //Console.WriteLine(y.Substring(0, 3));
    
    var x = "Programação C#";
    Console.WriteLine(x);
    Console.WriteLine(x.GetType());
    Console.WriteLine(x.Substring(0, 3));
  


  }
}