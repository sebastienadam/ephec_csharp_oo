using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common {
  public class KeyboardTools {
    private static void ShowErrorMessage(Exception e) {
      Console.WriteLine(e.Message);
      Console.WriteLine();
    }

    public static bool ReadBoolean() {
      char val;
      char[] TrueValues = { 'o', 'O', 'v', 'V' };
      char[] FalseValues = { 'n', 'N', 'F', 'F' };
      char[] AllValues = TrueValues.Concat(FalseValues).ToArray();
      val = ReadChar(AllValues);
      return (Array.IndexOf(TrueValues, val) >= 0);
    }

    public static bool ReadBoolean(string prompt) {
      bool val;
      while (true) {
        try {
          Console.Write(prompt);
          val = ReadBoolean();
          break;
        } catch (Exception e) {
          ShowErrorMessage(e);
        }
      }
      return val;
    }

    public static char ReadChar() {
      return Console.ReadKey().KeyChar;
    }

    public static char ReadChar(string prompt) {
      char val;
      while (true) {
        try {
          Console.Write(prompt);
          val = ReadChar();
          Console.WriteLine();
          break;
        } catch (Exception e) {
          ShowErrorMessage(e);
        }
      }
      return val;
    }

    public static char ReadChar(char[] AcceptedValues) {
      char val;
      while (true) {
        try {
          val = ReadChar();
          Console.WriteLine();
          if (Array.IndexOf(AcceptedValues, val) < 0) {
            Console.WriteLine("Valeur non autorisée !!");
          } else {
            break;
          }
        } catch (Exception e) {
          ShowErrorMessage(e);
        }
      }
      return val;
    }

    public static char ReadChar(String prompt, char[] AcceptedValues) {
      char val;
      while (true) {
        try {
          Console.Write(prompt);
          val = ReadChar();
          Console.WriteLine();
          if (Array.IndexOf(AcceptedValues, val) < 0) {
            Console.WriteLine("Valeur non autorisée !!");
          } else {
            break;
          }
        } catch (Exception e) {
          ShowErrorMessage(e);
        }
      }
      return val;
    }

    public static double ReadDouble() {
      return Double.Parse(ReadString());
    }

    public static double ReadDouble(String prompt) {
      double val;
      while (true) {
        try {
          Console.Write(prompt);
          val = ReadDouble();
          break;
        } catch (Exception e) {
          ShowErrorMessage(e);
        }
      }
      return val;
    }

    public static double ReadDouble(String prompt, double min) {
      double val;
      while (true) {
        try {
          Console.Write(prompt);
          val = ReadDouble();
          if (val < min) {
            Console.WriteLine("Minimum " + min + " !!!");
          } else {
            break;
          }
        } catch (Exception e) {
          ShowErrorMessage(e);
        }
      }
      return val;
    }

    public static double ReadDouble(String prompt, double min, double max) {
      double val;
      while (true) {
        try {
          Console.Write(prompt);
          val = ReadDouble();
          if ((val < min) || (val > max)) {
            Console.WriteLine("Entre " + min + " et " + max + " !!!");
          } else {
            break;
          }
        } catch (Exception e) {
          ShowErrorMessage(e);
        }
      }
      return val;
    }

    public static int ReadInt() {
      return Int32.Parse(ReadString());
    }

    public static int ReadInt(String prompt) {
      int val;
      while (true) {
        try {
          Console.Write(prompt);
          val = ReadInt();
          break;
        } catch (Exception e) {
          ShowErrorMessage(e);
        }
      }
      return val;
    }

    public static int ReadInt(String prompt, int min) {
      int val;
      while (true) {
        try {
          Console.Write(prompt);
          val = ReadInt();
          if (val < min) {
            Console.WriteLine("Minimum " + min + " !!!");
          } else {
            break;
          }
        } catch (Exception e) {
          ShowErrorMessage(e);
        }
      }
      return val;
    }

    public static int ReadInt(String prompt, int min, int max) {
      int val;
      while (true) {
        try {
          Console.Write(prompt);
          val = ReadInt();
          if ((val < min) || (val > max)) {
            Console.WriteLine("Entre " + min + " et " + max + " !!!");
          } else {
            break;
          }
        } catch (Exception e) {
          ShowErrorMessage(e);
        }
      }
      return val;
    }

    public static String ReadString() {
      return Console.ReadLine();
    }

    public static String ReadString(String prompt) {
      String strInput;
      while (true) {
        Console.Write(prompt);
        try {
          strInput = ReadString();
          break;
        } catch (Exception e) {
          ShowErrorMessage(e);
        }
      }
      return strInput;
    }

    public static String ReadString(String prompt, Boolean acceptEmpty) {
      String strInput;
      while (true) {
        Console.Write(prompt);
        try {
          strInput = ReadString();
          if (!acceptEmpty && strInput == "") {
            Console.WriteLine("Pas de chaîne vide !!");
          } else {
            break;
          }
        } catch (Exception e) {
          ShowErrorMessage(e);
        }
      }
      return strInput;
    }
  }
}
