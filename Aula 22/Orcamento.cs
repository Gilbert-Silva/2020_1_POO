using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    Item a = new Servico("Montagem de Micro", 30);
    Item b = new Material("Processador", 600);
    Item c = new Material("Memória 4GB", 300);
    Console.WriteLine(a);
    Console.WriteLine(a.GetPreco());
    Console.WriteLine(b);
    Console.WriteLine(b.GetPreco());
    Console.WriteLine(c);
    Console.WriteLine(c.GetPreco());

    Orcamento x = new Orcamento();
    x.Inserir(a);
    x.Inserir(b);
    c.Qtd = 2;
    x.Inserir(c);
    Console.WriteLine(x.Total());
  }
}

class Orcamento {
  public List<Item> itens = new List<Item>();
  public void Inserir(Item item) {
    itens.Add(item);
  }
  public decimal Total() {
    decimal t = 0;
    foreach(Item item in itens)
      t += item.Qtd * item.GetPreco();
  return t;
  }
}

abstract class Item {
  public string Descricao {get; set;}
  public int Qtd {get; set;}
  public Item(string d, int q) {
    Descricao = d;
    Qtd = q;
  }
  public abstract decimal GetPreco();
  public override string ToString() {
    return $"{Qtd} - {Descricao}";
  }
}

class Servico : Item {
  private int tempo;
  public Servico(string d, int t) : base(d, 1) {
    tempo = t;
  }
  public override decimal GetPreco() {
    return tempo * 2;
  }
}

class Material : Item {
  private decimal precoCompra;
  public Material(string d, decimal p) : base(d, 1) {
    precoCompra = p;
  }
  public override decimal GetPreco() {
    return precoCompra * 1.2M;
  }
}