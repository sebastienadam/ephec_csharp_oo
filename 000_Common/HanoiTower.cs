using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Common {
  public class HanoiTower {
    protected int[,] Towers;
    protected const int nbDiscs = 6;
    protected const int nbTowers = 3;
    protected int nbMoves;
    protected int nbOptimalMoves;
    protected bool success;
    protected int TowerTarget;

    /// <summary>
    /// Constructeur.
    /// </summary>
    public HanoiTower() {
      Init();
    }

    /// <summary>
    /// Lance la résolution automatique du jeu.
    /// </summary>
    public void AutoPlay() {
      if (nbMoves == 0) {
        Resolve(nbDiscs, 0, TowerTarget, nbTowers - TowerTarget);
      }
    }

    /// <summary>
    /// Vérifie si un déplacement est autorisé. Un disque ne peut être déplacé que vers une tour vide ou sur un disque plus grand.
    /// </summary>
    /// <param name="TowerIdxFrom">Indice de la tour de départ.</param>
    /// <param name="TowerIdxTo">Indice de la tour de destination.</param>
    /// <returns>Si le déplacement est autorisé, retourne 'true', sinon, retourne 'false'.</returns>
    protected bool CanMove(int TowerIdxFrom, int TowerIdxTo) {
      if (IsValidTowerIndex(TowerIdxFrom) && IsValidTowerIndex(TowerIdxTo) && (TowerIdxFrom != TowerIdxTo)) {
        int IdxTopDiscFrom = IndexTopDisc(TowerIdxFrom);
        int IdxTopDiscTo = IndexTopDisc(TowerIdxTo);
        if (IdxTopDiscFrom < 0) {
          return false;
        } else if (IdxTopDiscTo < 0) {
          return true;
        } else {
          int DiscSizeFrom = Towers[TowerIdxFrom, IdxTopDiscFrom];
          int DiscSizeTo = Towers[TowerIdxTo, IdxTopDiscTo];
          if (DiscSizeFrom < DiscSizeTo) {
            return true;
          } else {
            return false;
          }
        }
      } else {
        return false;
      }
    }

    /// <summary>
    /// Recherche l'index du plateau le plus haut d'une tour.
    /// </summary>
    /// <param name="TowerIdx">L'index de la tour à contrôler.</param>
    /// <returns>L'index du disque le plus élevé, -1 si la tour est vide.</returns>
    protected int IndexTopDisc(int TowerIdx) {
      if (IsValidTowerIndex(TowerIdx)) {
        int DiscIdx = 0;
        while (Towers[TowerIdx, DiscIdx] != 0) {
          DiscIdx++;
          if (DiscIdx >= nbDiscs) {
            DiscIdx = nbDiscs;
            break;
          }
        }
        return DiscIdx - 1;
      } else {
        return -1;
      }
    }

    /// <summary>
    /// Initialise l'objet. Cette fonction est appelée par le constructeur.
    /// </summary>
    public void Init() {
      int val;
      Random rng = new Random();
      Towers = new int[nbTowers, nbDiscs];
      for (int i = 0; i < Towers.GetLength(0); i++) {
        for (int j = 0; j < Towers.GetLength(1); j++) {
          if (i == 0) {
            val = nbDiscs - j;
          } else {
            val = 0;
          }
          Towers[i, j] = val;
        }
      }
      TowerTarget = rng.Next(1, nbTowers);
      nbMoves = 0;
      success = false;
      nbOptimalMoves = (int)Math.Pow(2, nbDiscs) - 1;
    }

    /// <summary>
    /// Vérifie s'il s'agit d'un index de disque valide.
    /// </summary>
    /// <param name="idx">L'index à vérifier.</param>
    /// <returns>Si l'index est valide, retourne 'true', sinon retourne 'false'.</returns>
    protected bool IsValidDiscIndex(int idx) {
      return ((idx >= 0) && (idx < nbDiscs));
    }

    /// <summary>
    /// Vérifie s'il s'agit d'un index de tour valide.
    /// </summary>
    /// <param name="idx">L'index à vérifier.</param>
    /// <returns>Si l'index est valide, retourne 'true', sinon retourne 'false'.</returns>
    protected bool IsValidTowerIndex(int idx) {
      return ((idx >= 0) && (idx < nbTowers));
    }

    /// <summary>
    /// Teste si on a gagné ou non.
    /// </summary>
    /// <returns>Si le jeu est gagné retourne 'true', sinon retourne 'false'.</returns>
    public bool IsWon() {
      return success;
    }

    /// <summary>
    /// Déplace un disque.
    /// </summary>
    /// <param name="TowerIdxFrom">Index de la tour de départ, la première tour commence à 1.</param>
    /// <param name="TowerIdxTo">Index de la tour d'arrivée, la première tour commence à 1.</param>
    /// <returns>Si le déplacement est autorisé, retourne 'true', sinon retourne 'false'.</returns>
    public bool Move(int TowerIdxFrom, int TowerIdxTo) {
      TowerIdxFrom--;
      TowerIdxTo--;
      if (CanMove(TowerIdxFrom, TowerIdxTo)) {
        int DiscIdxFrom = IndexTopDisc(TowerIdxFrom);
        int DiscIdxTo = IndexTopDisc(TowerIdxTo) + 1;
        Towers[TowerIdxTo, DiscIdxTo] = Towers[TowerIdxFrom, DiscIdxFrom];
        Towers[TowerIdxFrom, DiscIdxFrom] = 0;
        nbMoves++;
        if (IndexTopDisc(TowerTarget) == (nbDiscs - 1)) {
          success = true;
        }
        return true;
      } else {
        return false;
      }
    }

    /// <summary>
    /// Résoud le jeu de manière récursive.
    /// </summary>
    /// <param name="nbDiscs">Nombre de disques à déplacer.</param>
    /// <param name="TowerIdxFrom">Index de la tour de départ.</param>
    /// <param name="TowerIdxTo">Index de la tour d'arrivée.</param>
    /// <param name="TowerIdxItermediate">Index de la tour intermédiaire.</param>
    protected void Resolve(int nbDiscs, int TowerIdxFrom, int TowerIdxTo, int TowerIdxItermediate) {
      if (nbDiscs != 0) {
        Resolve(nbDiscs - 1, TowerIdxFrom, TowerIdxItermediate, TowerIdxTo);
        Move(TowerIdxFrom + 1, TowerIdxTo + 1);
        Resolve(nbDiscs - 1, TowerIdxItermediate, TowerIdxTo, TowerIdxFrom);
      }
    }
  }
}
