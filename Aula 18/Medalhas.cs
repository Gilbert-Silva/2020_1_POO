using System;
using System.Collections;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    Pais a = new Pais { Nome = "China", Ouro = 10, Prata = 10, Bronze = 10 }; 
    Pais b = new Pais { Nome = "Japão", Ouro = 8, Prata = 10, Bronze = 10 }; 
    Pais c = new Pais { Nome = "EUA", Ouro = 8, Prata = 8, Bronze = 10 }; 
    Pais d = new Pais { Nome = "Brasil", Ouro = 10, Prata = 10, Bronze = 10 }; 
    QuadroMedalhas q = new QuadroMedalhas();
    q.Inserir(a);
    q.Inserir(b);
    q.Inserir(c);
    q.Inserir(d);
    foreach (Pais p in q.Listar())
      Console.WriteLine(p);
  }
}

class QuadroMedalhas {
  List<Pais> paises = new List<Pais>();
  public void Inserir(Pais p) {
    paises.Add(p);
  }
  public List<Pais> Listar() {
    paises.Sort();
    return paises;
  }
}


class Pais : IComparable<Pais> {
  public string Nome {get;set;}
  public int Ouro {get;set;}
  public int Prata {get;set;}
  public int Bronze {get;set;}
  public int CompareTo(Pais obj) {
    if (this.Ouro > obj.Ouro) return -1;
    if (this.Ouro < obj.Ouro) return 1;
    if (this.Prata > obj.Prata) return -1;
    if (this.Prata < obj.Prata) return 1;
    if (this.Bronze > obj.Bronze) return -1;
    if (this.Bronze < obj.Bronze) return 1;
    return this.Nome.CompareTo(obj.Nome);
  }
  public override string ToString() {
    return $"{Nome} {Ouro} {Prata} {Bronze}";
  }
}
