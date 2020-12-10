using System;
using System.Globalization;
using System.Threading;

class MainClass {
  public static void Main (string[] args) {
    CultureInfo ci = new CultureInfo("pt-BR");
    Thread.CurrentThread.CurrentCulture = ci;
    
    DateTime x = DateTime.Now;
    Console.WriteLine(x);

    Boleto b = new Boleto(1000);
    Console.WriteLine(b.Situacao());
    b.Pagar(200);
    Console.WriteLine(b.Situacao());
    b.Pagar(1000);
    Console.WriteLine(b.Situacao());
  }
} 

enum Pagamento {
  EmAberto, PagoParcial, Pago
}

class Boleto {
  private decimal valorBoleto;
  private decimal valorPago;
  private Pagamento situacaoPagamento;
  public Boleto(decimal valorBoleto) {
    this.valorBoleto = valorBoleto;
    situacaoPagamento = Pagamento.EmAberto;
  }
  public void Pagar(decimal valor) {
    valorPago = valor;
    if (valor == valorBoleto) 
      situacaoPagamento = Pagamento.Pago;
    else  
      situacaoPagamento = Pagamento.PagoParcial;
  }
  public Pagamento Situacao() {
    return situacaoPagamento;
  }
}

