using System;

class MainClass {
  public static void Main (string[] args) {

    // Tipos de Delagates - Referências de Métodos
    // 1. Action é um delegado para um método que recebe ou não parâmetros e não retorna um valor (void)

    // 2. Func é um delegado para um método que recebe ou não parâmetros e retorna um valor (diferente de void)

    // 3. Predicate é um delegado para um método que recebe ou não parâmetros e retorna um valor lógico (bool)
    
    Console.WriteLine("\nMostrar Objetos");
    MostrarObjeto(10);
    MostrarObjeto("Teste");

    Console.WriteLine("\nMostrar Strings");
    //MostrarString(10);
    MostrarString("Teste");

    Console.WriteLine("\nRetornar Objetos");
    Console.WriteLine(RetornarObjeto());

    Console.WriteLine("\nRetornar Strings");
    Console.WriteLine(RetornarString());

    Console.WriteLine("\nTestar Objetos");
    Console.WriteLine(TestarObjeto("teste"));

    Console.WriteLine("\nTestar Strings");
    Console.WriteLine(TestarString("Teste"));

    // 1. Delegate Action
    Console.WriteLine("\nDelegate Mostrar Objetos");
    Action<object> m1 = MostrarObjeto;
    m1(10);
    m1("Teste");
    MostrarObjeto(10);
    MostrarObjeto("Teste");

    Console.WriteLine("\nDelegate Mostrar Strings");
    Action<string> m2 = MostrarString;
    m2("Teste");
    MostrarString("Teste");

    // 2. Delegate Func
    Func<object> m3 = RetornarObjeto;
    Console.WriteLine("\nDelegate Retornar Objetos");
    Console.WriteLine(m3());
    Console.WriteLine(RetornarObjeto());

    Func<string> m4 = RetornarString;
    Console.WriteLine("\nDelegate Retornar Strings");
    Console.WriteLine(m4());
    Console.WriteLine(RetornarString());

    // 3. Delegate Predicate
    Predicate<object> m5 = TestarObjeto;
    Console.WriteLine("\nTestar Objetos");
    Console.WriteLine(m5("teste"));
    Console.WriteLine(TestarObjeto("teste"));

    Predicate<string> m6 = TestarString;
    Console.WriteLine("\nTestar Strings");
    Console.WriteLine(m6("Teste"));
    Console.WriteLine(TestarString("Teste"));


    // 4. Covariância com delegate
    // Um método de um tipo mais derivado é atribuído para um delegate de um tipo menos derivado
    Console.WriteLine("\nCovariância de Delegate");
    Func<object> m7 = RetornarString;
    Console.WriteLine(m7());
    Console.WriteLine(RetornarString());


    // 5. Contravariância com delegate
    // Um método de um tipo menos derivado é atribuído para um delegate de um tipo mais derivado
    Console.WriteLine("\nContravariância de Delegate");
    Action<string> m8 = MostrarObjeto;
    //m8(10);
    m8("Teste");
    MostrarObjeto(10);
    MostrarObjeto("Teste");
        
    Predicate<string> m9 = TestarObjeto;
    Console.WriteLine(m9("teste"));
    Console.WriteLine(TestarObjeto("teste"));   
    //Console.WriteLine(m9(10));
    Console.WriteLine(TestarObjeto(10));
  }

  // Actions - Ações

  public static void MostrarObjeto(object x) {
    Console.WriteLine(x);
  }

  public static void MostrarString(string x) {
    Console.WriteLine(x);
  }

  // Functions - Funções

  public static object RetornarObjeto() {
    return 10;
  }

  public static string RetornarString() {
    return "Teste";
  }

  // Predicate - Predicados

  public static bool TestarObjeto(object x) {
    return x.ToString() == "Teste";
  }

  public static bool TestarString(string x) {
    return x == "Teste";
  }


}