using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace _018_Matrice {
  class Program {
    static void Main(string[] args) {
      ConsoleTools.WriteTitle("Matrices");
      Matrix[] Matrixes = new Matrix[4];
      Matrixes[0] = new Matrix(new double[,] { { -2.8 } });                // 1x1
      Matrixes[1] = new Matrix(new double[,] { { -2.8, 6.2 },              // 2x2
                                               { -9.0, 0.0 } });
      Matrixes[2] = new Matrix(new double[,] { { -2.8, 6.2, 7.5 },         // 3x3
                                               { -9.0, 0.0, 6.3 },
                                               {  0.2, 5.8, 8.7 } });
      Matrixes[3] = new Matrix(new double[,] { { -2.8, 6.2, 7.5, 4.7 },    // 4x4
                                               { -9.0, 0.0, 6.3, 4.4 },
                                               {  0.2, 5.8, 8.7,-6.1 },
                                               { -1.1,-7.8,-1.8, 1.3 } });
      for (int i = 0; i < Matrixes.Length; i++) {
        Console.WriteLine("Matrice " + i + " :");
        Console.WriteLine(Matrixes[i]);
        Console.WriteLine("Inverse de la matrice " + i + " :");
        Console.WriteLine(Matrixes[i].Invert());
        Console.WriteLine("Multiplication des deux matrices :");
        Console.WriteLine(Matrixes[i].Multiply(Matrixes[i].Invert()));
        Console.WriteLine();
      }
      ConsoleTools.Pause();
    }
  }
}
