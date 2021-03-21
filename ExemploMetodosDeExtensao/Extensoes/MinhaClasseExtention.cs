using System;
using System.Collections.Generic;
using System.Text;
using ExemploMetodosDeExtensao.Model;

namespace System
{
  public static class MinhaClasseExtention
  {
    public static string ExtensaoMinhaClasse(this MinhaClasse minhaClasse)
    {
      return "Método de extensão MinhaClasse";
    }
  }
}
