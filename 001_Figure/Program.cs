using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;


namespace _001_Figure
{
  class Program
  {
    static void DrawFigure(int nbLines) {
      for (int i = 0; i < nbLines; i++) {
        Console.WriteLine("*" + StringTools.MultiChar(' ', i) + "*");
      }
    }

    static void Main(string[] args)
    {
      int nbLines;
      ConsoleTools.WriteTitle("Figure");
      nbLines = KeyboardTools.ReadInt("Nombre de ligne : ", 1);
      DrawFigure(nbLines);
      ConsoleTools.Pause();
    }
  }
}
