using System;
using System.Collections;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    Frete a = new Frete();
    Console.WriteLine(a.ValorFrete);
    Frete b = new FreteExpresso();
    Console.WriteLine(b.ValorFrete);
  }
}


class Frete {
  public double ValorFrete { get => 10; }
}

class FreteExpresso : Frete {
  public double ValorFrete { get => 20; }
}



/*
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
*/