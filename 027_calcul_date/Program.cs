using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

/*
 * Ecrire un programme qui:
 *  - Affiche la date et l’heure
 *  - Demande à l’utilisateur sa date de naissance
 *  - Affiche quel jour de la semaine il est né
 *  - Affiche son âge exact (jours, heures, minutes, secondes) en tenant compte des années bissextiles
 *  - Enfin, affiche le temps qu’il a fallu au programme pour calculer toutes ces informations
 */

namespace _027_calcul_date {
  class Program {
    static void Main(string[] args) {
      DateTime CurrentDate = DateTime.Today;
      DateTime BirthDate;
      ConsoleTools.WriteTitle("Calcul de dates");
      Console.WriteLine("Date du jour : {0}/{1}/{2}", CurrentDate.Day, CurrentDate.Month, CurrentDate.Year);
      while (true) {
        try {
          BirthDate = DateTime.Parse(KeyboardTools.ReadString("Votre date de naissance : "));
          break;
        } catch (Exception E) {
          Console.WriteLine("Erreur d'encodage de date : {0} - {1}", E.GetType(), E.Message);
        }
      }
      DateTime Start = DateTime.Now;
      Console.WriteLine("Vous êtes né un {0}.", BirthDate.DayOfWeek);
      TimeSpan Age = new TimeSpan(CurrentDate.Ticks - BirthDate.Ticks);
      Console.WriteLine("Vous êtes âgé de " + Age);
      DateTime Stop = DateTime.Now;
      Console.WriteLine("Durée du calcul : " + new TimeSpan(Stop.Ticks - Start.Ticks));
      ConsoleTools.Pause();
    }
  }
}
