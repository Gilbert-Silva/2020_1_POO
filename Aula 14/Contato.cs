using System;

class MainClass {
  public static void Main (string[] args) {
    Contato x = new Contato();
    x.Nome = "Contato 1";
    Console.WriteLine(x.Nome);

    Contato y = new Contato { Nome = "Contato 2",
      Email = "Email 2" };
    Console.WriteLine(y.Nome);
    Console.WriteLine(y.Email);

    Contato z = new Contato { };
    Console.WriteLine(z);
  }
}

class Contato {
  public string Nome { get; set; }
  public string Email { get; set; }
  public string Fone { get; set; }
  public DateTime Nascimento { get; set; }
}
