using System;

class MainClass {
  public static void Main (string[] args) {
    //BancoDados x = new BancoDados("Banco 1");
    //Console.WriteLine(x.GetNome());
    //BancoDados y = new BancoDados("Banco 2");
    //Console.WriteLine(y.GetNome());

    BancoDados x = BancoDados.RetornarObjeto();
    Console.WriteLine(x.GetNome());

    BancoDados y = BancoDados.RetornarObjeto();
    Console.WriteLine(y.GetNome());

    if (x == y) Console.WriteLine("Mesmo objeto");
    else Console.WriteLine("Objetos diferentes");


    Boleto a = new Boleto("00000");
    Boleto b = new Boleto("00000");
    Boleto c = new Boleto("00000");
    Boleto d = new Boleto("00000");

    Console.WriteLine(Boleto.GetN());

  }
}

class BancoDados {
  private string nome;

  private static BancoDados z;
  private static int n;

  public static BancoDados RetornarObjeto() {
    if (n == 0) {
      z = new BancoDados("Banco Único");
      n++;
      return z;
    }
    return z;
  }

  private BancoDados(string nome) {
    this.nome = nome;
  }

  public void SetNome(string nome) {
    this.nome = nome;
  } 
  public string GetNome() {
    return this.nome;
  } 
}

class Boleto {
  private static int n;
  private string codBarra;
  public Boleto(string codBarra) {
    this.codBarra = codBarra;
    n++;
  }
  public static int GetN() {
    return n;
  }
  public override string ToString() {
    return codBarra;
  }
}