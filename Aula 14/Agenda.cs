using System;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {
    Compromisso c1 = new Compromisso {
      Assunto = "Avaliação de Propriedades",
      Local = "Remoto",
      Data = DateTime.Parse("2020-11-10")
    };
    Compromisso c2 = new Compromisso {
      Assunto = "Avaliação do Módulo I",
      Local = "Remoto",
      Data = DateTime.Parse("2020-11-12")
    };
    Compromisso c3 = new Compromisso {
      Assunto = "Avaliação do Módulo II",
      Local = "Remoto",
      Data = DateTime.Parse("2020-12-08")
    };    //Console.WriteLine(c1);
    //Console.WriteLine(c2);

    Agenda a = new Agenda();
    a.Inserir(c1);
    a.Inserir(c2);
    a.Inserir(c3);
    foreach(Compromisso c in a.Listar()) 
      Console.WriteLine(c);
    foreach(Compromisso c in a.Pesquisar2(11, 2020)) 
      Console.WriteLine(c);
    Console.WriteLine(a.Qtd);  
  }
}

class Agenda {
  private Compromisso[] comps = new Compromisso[1];
  private int k;
  public int Qtd { get => k; } //comps.Length; }
  public void Inserir(Compromisso c) {
    if (k >= comps.Length) Array.Resize(ref comps, 2 * comps.Length);
    comps[k++] = c;
  }
  public Compromisso[] Listar() {
    Compromisso[] r = new Compromisso[k];
    Array.Copy(comps, r, k);
    return r;
  }
  public Compromisso[] Pesquisar(int mes, int ano) {
    int x = 0;
    for(int i = 0; i < k; i++)
      if (comps[i].Data.Month == mes && comps[i].Data.Year == ano)
        x++;
    Compromisso[] r = new Compromisso[x];
    int j = 0;
    for(int i = 0; i < k; i++)
      if (comps[i].Data.Month == mes && comps[i].Data.Year == ano)
        r[j++] = comps[i];
    return r;
  }
  public Compromisso[] Pesquisar2(int mes, int ano) {
    var r = Listar().Where(c => c.Data.Month == mes && c.Data.Year == ano);
    return r.ToArray();
  }
}

class Compromisso {
  public string Assunto { get; set; }
  public string Local { get; set; }
  public DateTime Data { get; set; }
  public override string ToString() {
    return $"{Assunto} {Local} {Data:dd/MM/yyyy}";
  }
}
