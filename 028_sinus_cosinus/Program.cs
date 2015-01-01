using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace _028_sinus_cosinus {
  class Program {
    static void Main(string[] args) {
      Random rnd = new Random();
      double angle;
      double sinAngle;
      double cosAngle;
      double result;
      ConsoleTools.WriteTitle("Calcul de sinus et cosinus");
      for (int i = 0; i < 100; i++) {
        angle = rnd.NextDouble() * 2 * Math.PI;
        sinAngle = Math.Sin(angle);
        cosAngle = Math.Cos(angle);
        result = sinAngle * sinAngle + cosAngle * cosAngle;
        if (result != 1.0) {
          Console.Write("!!!! -> ");
        }
        Console.WriteLine("sin²({0,4:0.00}) + cos²({0,4:0.00}) = {1}", angle, result);
      }
      ConsoleTools.Pause();
    }
  }
}
