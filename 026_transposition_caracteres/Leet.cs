using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _026_transposition_caracteres {
  class Leet {
    private string[,] tr = new string[,] {{"H","|-|"},{"M","|\\/|"},{"N","/\\/"},{"U","[_]"},{"W","\\\\//"},
                                          {"B","13"},{"D","[)"},{"F","|="},{"J",".]"},{"K","|<"},{"P","|>"},{"Q","0,"},{"R","|2"},{"V","\\/"},{"X","}{"},{"Y","`/"},
                                          {"A","4"},{"C","("},{"E","3"},{"G","6"},{"I","|"},{"L","1"},{"O","0"},{"S","5"},{"T","7"},{"Z","2"}};
    private string _clear;
    private string _coded;

    public string Clear { get { return _clear; } set { SetClear(value); } }
    public string Coded { get { return _coded; } set { SetCoded(value); } }

    protected void SetClear(string value) {
      StringBuilder temp = new StringBuilder(value.ToUpper());
      _clear = value;
      for (int i = 0; i < tr.GetLength(0); i++) {
        temp.Replace(tr[i, 0], tr[i, 1]);
      }
      _coded = temp.ToString();
    }

    protected void SetCoded(string value) {
      StringBuilder temp = new StringBuilder(value);
      _coded = value;
      for (int i = 0; i < tr.GetLength(0); i++) {
        temp.Replace(tr[i, 1], tr[i, 0]);
      }
      _clear = temp.ToString();
    }
  }
}
