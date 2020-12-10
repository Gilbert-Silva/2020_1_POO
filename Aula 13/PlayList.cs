using System;

class MainClass {
  public static void Main (string[] args) {
    Musica a = new Musica("titulo 1", TimeSpan.Parse("00:05:00"));

    a.Duracao = TimeSpan.Parse("00:15:00");
    a.SetDuracao(TimeSpan.Parse("00:15:00"));

    Musica b = new Musica("titulo 2", TimeSpan.Parse("00:03:00"));
    //Console.WriteLine(a);
    //Console.WriteLine(b);

    PlayList p = new PlayList("Nome");
    p.Inserir(a);
    p.Inserir(b);

    //Musica[] x = p.Listar();
    //foreach(Musica m in x)
    //  Console.WriteLine(m);
    foreach(Musica m in p.Listar())
      Console.WriteLine(m);
    Console.WriteLine(p.TempoTotal());
  }
}

class PlayList {
  private string nome;
  private Musica[] musicas = new Musica[10];
  private int k;
  public PlayList(string nome) {
    this.nome = nome;
  }
  public void Inserir(Musica m) {
    if (k < 10) {
      musicas[k] = m;
      k++;
    }
  }
  public Musica[] Listar() {
    Musica[] r = new Musica[k];
    Array.Copy(musicas, r, k);
    return r;
  }
  public TimeSpan TempoTotal() {
    TimeSpan t = new TimeSpan(0,0,0);
    for(int i = 0; i < 10; i++)
      if (musicas[i] != null) 
        t += musicas[i].GetDuracao();
    return t;      
  }
}

class Musica {
  private string titulo;
  private TimeSpan duracao;

  public Musica(string titulo, TimeSpan duracao) {
    this.titulo = titulo;
    this.duracao = duracao;
  }

  public override string ToString() {
    return $"{titulo} - {duracao}";
  }

  public TimeSpan Duracao {
    get { return duracao; }
    set { /* validação*/ duracao = value; }
  }

  public void SetDuracao(TimeSpan duracao) {
    this.duracao = duracao;
  }
  public TimeSpan GetDuracao() {
    return duracao;
  }
}