using System;
using System.Collections;

class MainClass {
  public static void Main (string[] args) {
    int a = 3, b = 2, c = 1;
    Ordenar(ref a, ref b, ref c);
    Console.WriteLine("\nOrdenação de 3 inteiros");
    Console.WriteLine($"{a} {b} {c}");

    string s1 = "ZZZ", s2 = "YYY", s3 = "XXX";
    Ordenar(ref s1, ref s2, ref s3);
    Console.WriteLine("\nOrdenação de 3 strings");
    Console.WriteLine($"{s1} {s2} {s3}");

    Console.WriteLine("\nOrdenação de vetor de inteiros");
    int[] v = { 6, 5, 4, 3, 2, 1 };
    Ordenar(v);
    foreach(int i in v) Console.Write(i + " ");
    Console.WriteLine();

    Console.WriteLine("\nOrdenação de vetor de strings");
    string[] w = { "F", "E", "D", "C", "B", "A" };
    Ordenar(w);
    foreach(string i in w) Console.Write(i + " ");
    Console.WriteLine();

    Console.WriteLine("\nOrdenação de vetor de inteiros");
    int[] x = { 6, 5, 4, 3, 2, 1 };
    OrdenarArray(x);
    foreach(int i in x) Console.Write(i + " ");
    Console.WriteLine();

    Console.WriteLine("\nOrdenação de vetor de strings");
    string[] y = { "F", "E", "D", "C", "B", "A" };
    OrdenarArray(y);
    foreach(string i in y) Console.Write(i + " ");
    Console.WriteLine();
  }

  static void Ordenar(ref int a, ref int b, ref int c) {
    int x;
    if (a > b) { x = a; a = b; b = x; }
    if (a > c) { x = a; a = c; c = x; }
    if (b > c) { x = b; b = c; c = x; }
  }

  static void Ordenar(ref string a, ref string b, ref string c) {
    string x;
    if (a.CompareTo(b) == 1) { x = a; a = b; b = x; }
    if (a.CompareTo(c) == 1) { x = a; a = c; c = x; }
    if (b.CompareTo(c) == 1) { x = b; b = c; c = x; }
  }

  static void Ordenar(int[] v) {
    for (int i = 0; i < v.Length-1; i++)
      for (int j = i + 1; j < v.Length; j++) {
        int a = v[i];
        int b = v[j];
        if (a > b) { 
          v[i] = b;
          v[j] = a; 
        }
      }
  }

  static void Ordenar(string[] v) {
    for (int i = 0; i < v.Length-1; i++)
      for (int j = i + 1; j < v.Length; j++) {
        string a = v[i];
        string b = v[j];
        if (a.CompareTo(b) == 1) { 
          v[i] = b;
          v[j] = a; 
        }
      }
  }

  static void OrdenarArray(Array v) {
    for (int i = 0; i < v.Length-1; i++)
      for (int j = i + 1; j < v.Length; j++) {
        IComparable a = (IComparable) v.GetValue(i);
        IComparable b = (IComparable) v.GetValue(j);
        if (a.CompareTo(b) == 1) { 
          v.SetValue(b, i);
          v.SetValue(a, j);
        }
      }
  }

}


