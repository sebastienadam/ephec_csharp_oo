using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

/*
 * Ecrivez un programme qui
Demande 5 nombres à l’utilisateur, et remplit un tableau T avec ces nombres
Demande ensuite deux valeurs i et j et affiche la valeur de T[i] / T[j]
Réagit à tous les problèmes pouvant survenir, en affichant des messages différents selon le type de problème
Supposons qu’il soit également interdit d’accéder au premier nombre du tableau : définissez votre propre exception pour traiter ce cas
 */
namespace _030_tableau_nombres {
  class Program {
    static int[] tab = new int[5];

    static int GetIndice(string prompt) {
      int val = KeyboardTools.ReadInt(prompt, 0, tab.Length - 1);
      if (val == 0) {
        throw new FirstIndiceException();
      } else {
        return val;
      }
    }

    static void Main(string[] args) {
      int i, j;
      ConsoleTools.WriteTitle("Remplissage et àccès à un tableau");
      for (int l = 0; l < tab.Length; l++) {
        tab[l] = KeyboardTools.ReadInt("Valeur " + l + " : ");
      }
      try {
        i = GetIndice("Premier indice : ");
        j = GetIndice("Second indice  : ");
        Console.WriteLine("La division de {0} par {1} donne : {2}", tab[i], tab[j], tab[j] / tab[j]);
      } catch (DivideByZeroException) {
        Console.WriteLine("Vous ne pouvez pas sélectionner un diviseur égal à zéro");
      } catch (FirstIndiceException e) {
        Console.WriteLine(e.Message);
      } catch (Exception e) {
        Console.WriteLine("Une erreur indéterminée s'est produite {0} - {1}", e.GetType(), e.Message);
      }
      ConsoleTools.Pause();
    }
  }
}
