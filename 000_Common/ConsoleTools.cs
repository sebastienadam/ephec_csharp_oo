using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common {
  public class ConsoleTools {
    /// <summary>
    /// Affiche un message d'attente sur la console et attend que l'utilisateur ait pressé une touche
    /// </summary>
    public static void Pause() {
      Console.WriteLine();
      Console.Write("Pressez une touche pour continuer...");
      Console.ReadKey();
    }

    /// <summary>
    /// Affiche un titre formaté sur la console
    /// </summary>
    /// <param name="title">Le titre à afficher</param>
    public static void WriteTitle(String title) {
      String underLine = StringTools.MultiChar('-', title.Length);
      Console.Clear();
      Console.WriteLine("** " + title + " **");
      Console.WriteLine("   " + underLine);
      Console.WriteLine();
    }

    public static void WriteAtPos(int left, int top, string message) {
      Console.SetCursorPosition(left, top);
      Console.Write(message);
    }
  }
}
