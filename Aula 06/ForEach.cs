using System;

class MainClass {
  public static void Main (string[] args) {
    int[] v = { 1, 2, 3, 4, 5 };
    string s = "Linguagem C#";
    foreach (int i in v) Console.WriteLine(i);
    foreach (char c in s) Console.WriteLine(c);
  }
}