using System;
using System.Collections.Generic;
using ExemploMetodosDeExtensao.Model;

namespace ExemploMetodosDeExtensao
{
  class Program
  {
    static void Main(string[] args)
    {
      MinhaClasse minha = new MinhaClasse();
      string nome = "isabella yasmin raquel";
      Console.WriteLine(nome.FirstToUpper());
      Console.WriteLine(minha.ExtensaoMinhaClasse());
      Console.ReadKey();
    }
  }
}
