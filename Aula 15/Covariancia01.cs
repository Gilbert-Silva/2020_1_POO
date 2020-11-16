using System;

class MainClass {
  public static void Main (string[] args) {
    
    // 1. Compatibilidade de Atribuição
    // Um objeto de um tipo mais derivado é atribuído
    // a um tipo menos derivado: tipo_base = tipo_derivado

    // Tipos por referência podem ser referenciados
    // por objects e IComparable
    string a = "C#";
    object b = a;
    IComparable c = a;
    Console.WriteLine(a);
    Console.WriteLine(b);
    Console.WriteLine(c);


    // 2. Boxing
    // Um objeto de um tipo por valor é atribuído
    // a um tipo por referência: tipo_ref = tipo_valor

    // Tipos por valor podem ser referenciados
    // por objects e IComparable
    int d = 10;
    object e = d;
    IComparable f = d;
    Console.WriteLine(d);
    Console.WriteLine(e);
    Console.WriteLine(f);


    // 3. Covariância de Matrizes (Arrays)

    // Uma matriz de um tipo mais derivado é atribuído para uma matriz de um tipo menos derivado

    // A conversão de vetores de tipos por referência
    // para vetores de object e IComparable é suportada
    string[] va = { "C#" , "Java" };
    object[] vb = va;
    IComparable[] vc = va;

    Console.WriteLine(va[0]);
    Console.WriteLine(va[1]);
    Console.WriteLine(vb[0]);
    Console.WriteLine(vb[1]);
    Console.WriteLine(vc[0]);
    Console.WriteLine(vc[1]);


    // 4. Covariância de Matrizes (Arrays) para tipos
    // por valor NÃO é suportada

    // Uma matriz de um tipo por valor não pode ser atribuída a uma matriz de um tipo por referência

    // A conversão de vetores de tipos por valor
    // para vetores de object e IComparable NÂO é suportada
    int[] vd = { 10, 20 };
    //object[] ve = vd;
    //IComparable[] vf = vd;

    Console.WriteLine(vd[0]);
    Console.WriteLine(vd[1]);
    //Console.WriteLine(ve[0]);
    //Console.WriteLine(ve[1]);
    //Console.WriteLine(vf[0]);
    //Console.WriteLine(vf[1]);
  }
}