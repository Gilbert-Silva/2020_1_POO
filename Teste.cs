using System;
using System.Collections;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    Colecao<int> c = new Colecao<int>();
    c.list.Add(5);
    c.list.Add(3);
    c.list.Add(1);
    //c.Sort();
    Console.WriteLine(c.list[0]);
    Console.WriteLine(c.list[1]);
    Console.WriteLine(c.list[2]);
    c.Sort();
    foreach(int i in c) Console.WriteLine(i);
  }
}

class Colecao<T> : IEnumerable<T> where T : IComparable<T> {
  public List<T> list = new List<T>();
  public void Sort() {
    list.Sort();
  }
  public IEnumerator<T> GetEnumerator() {
    return list.GetEnumerator();
  }
  IEnumerator IEnumerable.GetEnumerator()
  {
    return this.GetEnumerator();
  }
}
