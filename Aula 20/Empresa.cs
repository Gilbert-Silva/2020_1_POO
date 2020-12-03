using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

class MainClass {
  public static void Main (string[] args) {
    List<Empresa> listEmp = new List<Empresa>();
    Console.WriteLine("1-Iniciar Empresas, 2- Listar, 3-Salvar, 4-Abrir, 5-Iniciar Labs, 0-Fim");
    int op = int.Parse(Console.ReadLine());
    while (op != 0) {
      if (op == 1) {
        listEmp = new List<Empresa>();
        listEmp.Add(new Empresa { Id = 1, Descricao = "IFRN" });
        listEmp.Add(new Empresa { Id = 2, Descricao = "UFRN" });
      }
      if (op == 2) {
        foreach(Empresa emp in listEmp)
          Console.WriteLine(emp);
      }
      if (op == 3) {
        /*
        XmlSerializer xml = new XmlSerializer(typeof(List<Empresa>));
        StreamWriter f = new StreamWriter("Empresa.xml");
        xml.Serialize(f, listEmp);
        f.Close();
        */
        XmlSerializer xml = new XmlSerializer(typeof(List<Empresa>));
        using(StreamWriter f = new StreamWriter("Empresa.xml")) {
          xml.Serialize(f, listEmp);
        }
      }
      if (op == 4) {
        StreamReader f = null;
        try {
          XmlSerializer xml = new XmlSerializer(typeof(List<Empresa>));
          f = new StreamReader("Empresa.xml");
          listEmp = (List<Empresa>) xml.Deserialize(f);
        }
        catch (FileNotFoundException) {
          Console.WriteLine("Nenhum arquivo de dados");
        }
        catch (Exception) {
          Console.WriteLine("Erro na leitura ou conversão do arquivo");
        }
        finally {
          if (f != null) f.Close();
        }
      }
      if (op == 5) {
        listEmp[0].InserirLab(new Laboratorio { Id = 1, Descricao = "Lab01"} );
        listEmp[0].InserirLab(new Laboratorio { Id = 2, Descricao = "Lab02"} );
        listEmp[1].InserirLab(new Laboratorio { Id = 3, Descricao = "Lab03"} );
        listEmp[1].InserirLab(new Laboratorio { Id = 4, Descricao = "Lab04"} );
      }
      Console.WriteLine("1-Iniciar Empresas, 2- Listar, 3-Salvar, 4-Abrir, 5-Iniciar Labs, 0-Fim");
      op = int.Parse(Console.ReadLine());
    }  
  }
}

public class Empresa {
  public int Id { get; set; }
  public string Descricao { get; set; }
  public List<Laboratorio> labs = new List<Laboratorio>();
  public void InserirLab(Laboratorio lab) {
    labs.Add(lab);
  }
  public override string ToString() {
    return $"{Id} - {Descricao}";
  }
}

public class Laboratorio {
  public int Id { get; set; }
  public string Descricao { get; set; }
  public override string ToString() {
    return $"{Id} - {Descricao}";
  }
}
