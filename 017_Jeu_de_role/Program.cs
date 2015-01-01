using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace _017_Jeu_de_role {
  public class Program {
    static void Main(string[] args) {
      bool Again = true;
      char Action;
      Hero CurrentPlayer;
      Hero Opponent;
      int IdxCurrentPlayer = 0;
      int IdxOpponent;
      int NbrPlayers;
      List<Hero> Players = new List<Hero>();
      string StrTemp;
      string Title = "Jeu de rôle";

      ConsoleTools.WriteTitle(Title);
      NbrPlayers = KeyboardTools.ReadInt("Nombre de joueurs (entre 2 et 5) : ", 2, 5);
      for (int i = 0; i < NbrPlayers; i++) {
        StrTemp = KeyboardTools.ReadString("Nom du joueur " + (i + 1) + " : ");
        Players.Add(new Hero(StrTemp));
      }
      Console.WriteLine();
      for (int i = 0; i < Players.Count; i++) {
        Console.WriteLine("Joueur {0} : {1}", (i + 1), Players[i]);
      }
      ConsoleTools.Pause();

      Console.Clear();
      do {
        ConsoleTools.WriteTitle(Title);
        CurrentPlayer = Players[IdxCurrentPlayer];
        Console.WriteLine("Participants :");
        for (int i = 0; i < Players.Count; i++) {
          Console.WriteLine("    " + Players[i]);
        }
        Console.WriteLine();
        Console.WriteLine("Joueur courant : " + CurrentPlayer.Name);
        Console.WriteLine();
        Console.WriteLine("Action :  a : Attaque");
        Console.WriteLine("          d : Duel");
        Action = KeyboardTools.ReadChar("Votre choix : ", new[] { 'a', 'A', 'd', 'D' });
        Action = Char.ToLower(Action);
        StrTemp = "";
        switch (Action) {
          case 'a':
            StrTemp = "l'attaque";
            break;
          case 'd':
            StrTemp = "le duel";
            break;
        }
        Console.WriteLine("Choisissez votre opposant pour " + StrTemp + " :");
        for (int i = 0; i < Players.Count; i++) {
          if (Players[i] != CurrentPlayer) {
            Console.WriteLine("          {0} : {1}", (i + 1), Players[i]);
          }
        }
        IdxOpponent = KeyboardTools.ReadInt("Votre choix : ", 1, Players.Count);
        IdxOpponent--;
        Opponent = Players[IdxOpponent];
        switch (Action) {
          case 'a':
            CurrentPlayer.Attack(Opponent);
            Console.WriteLine();
            Console.WriteLine(Opponent);
            if (Opponent.IsDead) {
              Players.Remove(Opponent);
              IdxCurrentPlayer = Players.IndexOf(CurrentPlayer) + 1;
            } else {
              IdxCurrentPlayer++;
            }
            break;
          case 'd':
            Arena.Duel(CurrentPlayer, Opponent);
            Console.WriteLine();
            Console.WriteLine(CurrentPlayer);
            Console.WriteLine(Opponent);
            if (CurrentPlayer.IsDead) {
              Players.Remove(CurrentPlayer);
            }
            if (Opponent.IsDead) {
              Players.Remove(Opponent);
              IdxCurrentPlayer = Players.IndexOf(CurrentPlayer) + 1;
            }
            break;
        }
        if (Players.Count == 1) {
          Console.WriteLine();
          Console.WriteLine("Le gagnant  est : " + Players[0].Name);
          Again = false;
        } else {
          if (IdxCurrentPlayer >= Players.Count) {
            IdxCurrentPlayer = 0;
          }
        }
        ConsoleTools.Pause();
      } while (Again);
    }
  }
}
