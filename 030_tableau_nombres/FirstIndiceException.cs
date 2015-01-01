using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _030_tableau_nombres {
  class FirstIndiceException : Exception {
    public FirstIndiceException() : base("Vous ne pouvez pas accéder au premier indice du tableau!") { }
  }
}
