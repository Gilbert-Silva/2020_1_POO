using System;
using System.Collections;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {
    IDisciplina[] historico = new IDisciplina[4];
    historico[0] = new DisciplinaSemestral("Poo", 100, 100);
    historico[1] = new DisciplinaSemestral("Sistemas Digitais", 60, 60);
    historico[2] = new DisciplinaAnual("Poo2", 100, 100, 80, 60);
    historico[3] = new DisciplinaAnual("Sistemas Digitais 2", 60, 60, 50, 100);
    foreach(IDisciplina x in historico) {
      Console.WriteLine($"{x.GetNome()} {x.CalcMediaParcial()}");
    }
  }
}

interface IDisciplina {
  string GetNome();
  int CalcMediaParcial();
}

class DisciplinaSemestral : IDisciplina {
  private string nome;
  private int nota1;
  private int nota2;
  public DisciplinaSemestral(string nome, int nota1,
    int nota2) {
      this.nome = nome;
      this.nota1 = nota1;
      this.nota2 = nota2;
    }
  public string GetNome() => nome;
  public int CalcMediaParcial() => (2*nota1+3*nota2)/5;
}

class DisciplinaAnual : IDisciplina {
  private string nome;
  private int nota1;
  private int nota2;
  private int nota3;
  private int nota4;
  public DisciplinaAnual(string nome, int nota1, int nota2, int nota3, int nota4) {
      this.nome = nome;
      this.nota1 = nota1;
      this.nota2 = nota2;
      this.nota3 = nota3;
      this.nota4 = nota4;
    }
  public string GetNome() => nome;
  public int CalcMediaParcial() => (2*nota1+2*nota2+3*nota3+3*nota4)/10;
  
}