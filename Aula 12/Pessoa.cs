using System;
using System.Globalization;
using System.Threading;

class MainClass {
  public static void Main (string[] args) {
    CultureInfo ci = new CultureInfo("pt-BR");
    Thread.CurrentThread.CurrentCulture = ci;
    /*
    DateTime x = DateTime.Now;
    Console.WriteLine(x);
    Console.WriteLine(x.Day);
    Console.WriteLine(x.Month);
    Console.WriteLine(x.Year);
    Console.WriteLine(x.DayOfWeek);
    Console.WriteLine(ci.DateTimeFormat.GetDayName(x.DayOfWeek));
    Console.WriteLine(x.DayOfYear);
    Console.WriteLine(x.Hour);
    Console.WriteLine(x.Minute);
    Console.WriteLine(x.Second);
    Console.WriteLine(x.ToString("dd/MM/yyyy"));
    Console.WriteLine(x.ToString("ddd"));
    Console.WriteLine(x.ToString("dddd"));
    Console.WriteLine(x.ToString("MMM"));
    Console.WriteLine(x.ToString("MMMM"));
    */
    Pessoa p = new Pessoa("Teste", 
      DateTime.Parse("01/10/2020"));
    Console.WriteLine(ci.DateTimeFormat.GetDayName(p.DiaNascimento()));
    Console.WriteLine(p.DiasVividos().Days);  
  }
}

class Pessoa {
  private string nome;
  private DateTime nasc;
  public Pessoa (string nome, DateTime nasc) {
    this.nome = nome;
    this.nasc = nasc;
  }
  public DayOfWeek DiaNascimento() {
    return nasc.DayOfWeek;
  }
  public TimeSpan DiasVividos() {
    return DateTime.Today - nasc;
  }
}  
