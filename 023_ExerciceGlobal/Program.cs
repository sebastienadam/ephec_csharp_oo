using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace _023_ExerciceGlobal {
  class Program {
    static List<Personne> ListeOfPersons = new List<Personne>();
    static string[] ListOfActions;

    static void ActionBuyCar(Personne CurrentPerson) {
      Personne Seller;
      PrintActionHeader(CurrentPerson, "Achat d'une voiture");
      Console.WriteLine("Sélectionnez un vendeur ('q' pour quitter):");
      Seller = SelectPerson(CurrentPerson);
      if (Seller != null) {
        try {
          CurrentPerson.AcheterVoiture(Seller);
          Console.WriteLine("Voiture achetée");
        } catch (Exception e) {
          Console.WriteLine(e.Message);
        }
        ConsoleTools.Pause();
      }
    }

    static void ActionBuyGas(Personne CurrentPerson) {
      PrintActionHeader(CurrentPerson, "Achat d'essence");

    }

    static void AcionMove(Personne CurrentPerson) {
      double distance;
      PrintActionHeader(CurrentPerson, "Déplacement");
      Console.WriteLine(CurrentPerson.Voiture);
      distance = KeyboardTools.ReadDouble("Quelle distance voulez-vous parcourir (" + CurrentPerson.Voiture.DistanceParcourable + ")? ");
      try {
        CurrentPerson.Voiture.Rouler(distance);
        Console.WriteLine("Distance parcourue");
      } catch (Exception e) {
        Console.WriteLine(e.Message);
      }
      ConsoleTools.Pause();
    }

    static void ActionNewCar(Personne CurrentPerson) {
      PrintActionHeader(CurrentPerson, "Nouvelle voiture");
      if (CurrentPerson is Concessionnaire) {
        string marque = KeyboardTools.ReadString("Marque       : ");
        string modele = KeyboardTools.ReadString("Modèle       : ");
        double prix = KeyboardTools.ReadDouble("Prix         : ", 0);
        double conso = KeyboardTools.ReadDouble("Consommation : ", 0);
        try {
          ((Concessionnaire)CurrentPerson).NouvelleVoiture(new Voiture(marque, modele, prix, conso));
          Console.WriteLine("Nouvelle voiture créée");
        } catch (Exception e) {
          Console.WriteLine(e.Message);
        }
      } else {
        Console.WriteLine("Vous devez être concessionnnaire pour effectuer cette action");
      }
      ConsoleTools.Pause();
    }

    static void ActionSellCar(Personne CurrentPerson) {
      Personne Buyer;
      PrintActionHeader(CurrentPerson, "Vente d'une voiture");
      Console.WriteLine("Sélectionnez un acheteur ('q' pour quitter):");
      Buyer = SelectPerson(CurrentPerson);
      if (Buyer != null) {
        try {
          CurrentPerson.VendreVoiture(Buyer);
          Console.WriteLine("Voiture vendue");
        } catch (Exception e) {
          Console.WriteLine(e.Message);
        }
        ConsoleTools.Pause();
      }
    }

    static void PrintActionHeader(Personne CurrentPerson, string action) {
      Console.Clear();
      ConsoleTools.WriteTitle("Exercice récapitulatif");
      Console.WriteLine("// {0} \\\\", action);
      Console.WriteLine();
      Console.WriteLine("Personne courante :");
      Console.Write(CurrentPerson);
      Console.WriteLine();
    }

    static void PrintActionScreen(Personne CurrentPerson) {
      Console.Clear();
      ConsoleTools.WriteTitle("Exercice récapitulatif");
      Console.WriteLine("Personne courante :");
      Console.Write(CurrentPerson);
      Console.WriteLine();
      Console.WriteLine("Que voulez-vous faire?");
      for (int i = 0; i < ListOfActions.Length; i++) {
        Console.WriteLine("  {0}) {1}", i, ListOfActions[i]);
      }
    }

    static void PrintInitialScreen() {
      Console.Clear();
      ConsoleTools.WriteTitle("Exercice récapitulatif");
      Console.WriteLine("Liste des personnes :");
    }

    static int SelectAction() {
      List<char> answers = new List<char>();
      char chosen;
      for (int i = 0; i < ListOfActions.Length; i++) {
        answers.Add(Convert.ToChar(i.ToString()));
      }
      answers.Add('q');
      answers.Add('Q');
      chosen = KeyboardTools.ReadChar("Choisssez une action (ou 'q' pour quitter) : ", answers.ToArray());
      if (chosen == 'q' || chosen == 'Q') {
        return -1;
      } else {
        return Int32.Parse(chosen.ToString());
      }
    }

    static Personne SelectPerson(Personne NotSelectable = null) {
      List<char> answers = new List<char>();
      char chosen;
      for (int i = 0; i < ListeOfPersons.Count; i++) {
        if (!ListeOfPersons[i].Equals(NotSelectable)) {
          Console.Write(i + ") " + ListeOfPersons[i].ToString());
          answers.Add(Convert.ToChar(i.ToString()));
        }
      }
      answers.Add('q');
      answers.Add('Q');
      chosen = KeyboardTools.ReadChar("Choisssez une personne (ou 'q' pour quitter) : ", answers.ToArray());
      if (chosen == 'q' || chosen == 'Q') {
        return null;
      } else {
        return ListeOfPersons[Int32.Parse(chosen.ToString())];
      }
    }

    static void Main(string[] args) {
      bool again = true;
      Personne CurrentPerson;
      int ChosenActionIndex;
      ListeOfPersons.Add(new Personne("Jean", "Bauche", null));
      CurrentPerson = new Personne("Mark", "Twain", new CompteBancaire("123456789002", 6543.21));
      CurrentPerson.CarteDeFideliteTaxecool = new CarteFideliteTaxecool();
      ListeOfPersons.Add(CurrentPerson);
      ListeOfPersons.Add(new Concessionnaire("Renaud", "Cabrio", new CompteBancaire("000000008989", 1234.56)));
      ListOfActions = new string[5];
      ListOfActions[0] = "Acheter une voiture";
      ListOfActions[1] = "Vendre une voiture";
      ListOfActions[2] = "Nouvelle voiture voiture";
      ListOfActions[3] = "Se déplacer";
      ListOfActions[4] = "Acheter de l'essence";
      while (again) {
        PrintInitialScreen();
        CurrentPerson = SelectPerson();
        if (CurrentPerson == null) {
          again = false;
        } else {
          PrintActionScreen(CurrentPerson);
          ChosenActionIndex = SelectAction();
          switch (ChosenActionIndex) {
            case 0:
              ActionBuyCar(CurrentPerson);
              break;
            case 1:
              ActionSellCar(CurrentPerson);
              break;
            case 2:
              ActionNewCar(CurrentPerson);
              break;
            case 3:
              AcionMove(CurrentPerson);
              break;
            case 4:
              // acheter de l'essence
              break;
            default:
              again = false;
              break;
          }
        }
      }
//      ConsoleTools.Pause();
    }
  }
}
