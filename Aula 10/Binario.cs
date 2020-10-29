using System;

class MainClass {
  public static void Main (string[] args) {
    Conversor c = new Conversor(1024*1024);
    Console.WriteLine(c.Binario());
  }
}

class Conversor {
  private int num;
  public Conversor(int num) {
    this.num = num;
  }
  public string Binario() {
    int x = num;
    string s = "";
    while (x != 0) {
      int r = x % 2;
      x = x / 2;
      s = r.ToString() + s;
    }
    return s;
  }
}
