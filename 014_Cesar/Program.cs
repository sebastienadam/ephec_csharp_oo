using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace _014_Cesar {
  class Program {
    static void Main(string[] args) {
      string phrase = "ceciestunmessagesecretaz";
      Cesar code = new Cesar(4);
      ConsoleTools.WriteTitle("Codage César");
      Console.WriteLine("Message en clair : " + phrase);
      phrase = code.Cipher(phrase);
      Console.WriteLine("Message codé     : " + phrase);
      phrase = code.Decipher(phrase);
      Console.WriteLine("Message décodé   : " + phrase);
      ConsoleTools.Pause();
    }
  }
}
