using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace _018_Matrice {
  public class Matrix {
    public enum EnumMatrixType { Diagonal, Identity, LowerTriangle, NotNotable, Square, UpperTriangle, Zero }

    protected double[,] _matrix;

    public int Height { get { return _matrix.GetLength(0); } }
    public double Determinant { get { return GetDeterminant(this); } }
    public bool IsDiagonal { get { return GetIsDiagonal(); } }
    public bool IsIdentity { get { return GetIsIdentity(); } }
    public bool IsLowerTriangle { get { return GetIsLowerTriangle(); } }
    public bool IsSquare { get { return (Height == Width); } }
    public bool IsUpperTriangle { get { return GetIsUpperTriangle(); } }
    public bool IsZero { get { return GetIsZero(); } }
    public EnumMatrixType MatrixType { get { return GetMatrixType(); } }
    public int Width { get { return _matrix.GetLength(1); } }

    /// <summary>
    /// Construit une matrice en déterminant le nombre de lignes et de colonnes. La matrice ne contiendra aucune donnée.
    /// </summary>
    /// <param name="nbLines">Nombre de lignes</param>
    /// <param name="nbCols">Nombre de colonnes</param>
    public Matrix(int nbLines, int nbCols) {
      _matrix = new double[nbLines, nbCols];
    }

    /// <summary>
    /// Construit une matrice avec les données fournies.
    /// </summary>
    /// <param name="matrix">Tableaux des données qui devront être insérées dans la matrice.</param>
    public Matrix(double[,] matrix) {
      _matrix = new double[matrix.GetLength(0), matrix.GetLength(1)];
      for (int i = 0; i < matrix.GetLength(0); i++) {
        for (int j = 0; j < matrix.GetLength(1); j++) {
          SetValue(i, j, matrix[i, j]);
        }
      }
    }

    /// <summary>
    /// Ajoute une matrice à la matrice actuelle. Si la matrice données n'est pas de la même taille que la matrice actuelle, lève une exception 'ArgumentException'.
    /// </summary>
    /// <param name="other">La matrice à ajoutre à la matrice actuelle.</param>
    /// <returns>Le résultat de l'addition de la matrice actuelle avec la matrice donnée.</returns>
    public Matrix Add(Matrix other) {
      if (this.Height != other.Height || this.Width != other.Width) {
        throw new ArgumentException("Le deux matrices doivent être de même taille");
      } else {
        Matrix NewMatrix = new Matrix(Height, Width);
        for (int i = 0; i < Height; i++) {
          for (int j = 0; j < Width; j++) {
            NewMatrix.SetValue(i, j, this.GetValue(i, j) + other.GetValue(i, j));
          }
        }
        return NewMatrix;
      }
    }

    /// <summary>
    /// Vérifie si la matrie donnée possède les mêmes valeurs que la matrice actuelle.
    /// </summary>
    /// <param name="other">La matrice à comparer avec la matrice actuelle.</param>
    /// <returns>Si les deux matrices possèdent les mêmes valeurs, retourne vrai. Sinon, retourne faux.</returns>
    public override bool Equals(Matrix other) {
      bool Result = true;
      if ((this.Width != other.Width) || (this.Height != other.Height)) {
        Result = false;
      } else {
        for (int i = 0; i < this.Height; i++) {
          if (Result) {
            for (int j = 0; j < this.Width; j++) {
              if (!NumericTools.AreEquals(this.GetValue(i, j), other.GetValue(i, j), 2)) {
                Result = false;
                break;
              }
            }
          } else {
            break;
          }
        }
      }
      return Result;
    }

    /// <summary>
    /// Retourne le déterminant de la matrice données. Si la matrice n'est pas carrée, lève une exception 'InvalidOperationException'.
    /// </summary>
    /// <param name="other">La matrice dont il faut calculer le déterminant.</param>
    /// <returns>Le déterminant de la matrice donnée en paramètre.</returns>
    protected double GetDeterminant(Matrix other) {
      if (other.IsSquare) {
        if (other.Width == 1) {
          return other.GetValue(0, 0);
        } else if (other.Width == 2) {
          return (other.GetValue(0, 0) * other.GetValue(1, 1) - other.GetValue(0, 1) * other.GetValue(1, 0));
        } else {
          double sign;
          double Result = 0;
          for (int i = 0; i < other.Height; i++) {
            sign = ((i % 2) == 0) ? 1 : -1;
            Result += sign * other.GetValue(i, 0) * GetDeterminant(other.Reduce(i, 0));
          }
          return Result;
        }
      } else {
        throw new InvalidOperationException("La matrice doit être carrée");
      }
    }

    /// <summary>
    /// Détermine si la matrice actuelle est une matrice diagonale.
    /// </summary>
    /// <returns>Si la matrice actuelle est une matrice diagonale, retourne vrai. Sinon, retourne faux.</returns>
    protected bool GetIsDiagonal() {
      bool Result = IsSquare;
      if (Result) {
        for (int i = 0; i < Height; i++) {
          if (Result) {
            for (int j = 0; j < Width; j++) {
              if ((i != j) && (GetValue(i, j) != 0.0)) {
                Result = false;
                break;
              }
            }
          } else {
            break;
          }
        }
      }
      return Result;
    }

    /// <summary>
    /// Détermine si la matrice actuelle est une matrice identité.
    /// </summary>
    /// <returns>Si la matrice actuelle est une matrice identité, retourne vrai. Sinon, retourne faux.</returns>
    protected bool GetIsIdentity() {
      bool Result = IsSquare;
      if (Result) {
        for (int i = 0; i < Height; i++) {
          if (Result) {
            for (int j = 0; j < Width; j++) {
              if (((i == j) && (GetValue(i, j) != 1.0)) || ((i != j) && (GetValue(i, j) != 0.0))) {
                Result = false;
                break;
              }
            }
          } else {
            break;
          }
        }
      }
      return Result;
    }

    /// <summary>
    /// Détermine si la matrice actuelle est une matrice triangle inférieur.
    /// </summary>
    /// <returns>Si la matrice actuelle est une matrice triangle inférieur, retourne vrai. Sinon, retourne faux.</returns>
    protected bool GetIsLowerTriangle() {
      bool Result = IsSquare;
      if (Result) {
        for (int i = 0; i < Height; i++) {
          if (Result) {
            for (int j = 0; j < i; j++) {
              if (GetValue(i, j) != 0) {
                Result = false;
                break;
              }
            }
          } else {
            break;
          }
        }
      }
      return Result;
    }

    /// <summary>
    /// Détermine si la matrice actuelle est une matrice triangle suppérieure.
    /// </summary>
    /// <returns>Si la matrice actuelle est une matrice triangle suppérieure, retourne vrai. Sinon, retourne faux.</returns>
    protected bool GetIsUpperTriangle() {
      bool Result = IsSquare;
      if (Result) {
        for (int i = 0; i < Height; i++) {
          if (Result) {
            for (int j = i + 1; j < Width; j++) {
              if (GetValue(i, j) != 0) {
                Result = false;
                break;
              }
            }
          } else {
            break;
          }
        }
      }
      return Result;
    }

    /// <summary>
    /// Détermine si la matrice actuelle est une matrice nulle.
    /// </summary>
    /// <returns>Si la matrice actuelle est une matrice nulle, retourne vrai. Sinon, retourne faux.</returns>
    protected bool GetIsZero() {
      bool Result = true;
      for (int i = 0; i < Height; i++) {
        if (Result) {
          for (int j = 0; j < Width; j++) {
            if (GetValue(i, j) != 0) {
              Result = false;
              break;
            }
          }
        } else {
          break;
        }
      }
      return Result;
    }

    /// <summary>
    /// Retourne le type de matrice.
    /// </summary>
    /// <returns>Le type de matrice.</returns>
    protected EnumMatrixType GetMatrixType() {
      if (IsZero) {
        return EnumMatrixType.Zero;
      } else if (IsIdentity) {
        return EnumMatrixType.Identity;
      } else if (IsDiagonal) {
        return EnumMatrixType.Diagonal;
      } else if (IsLowerTriangle) {
        return EnumMatrixType.LowerTriangle;
      } else if (IsUpperTriangle) {
        return EnumMatrixType.UpperTriangle;
      } else if (IsSquare) {
        return EnumMatrixType.Square;
      } else {
        return EnumMatrixType.NotNotable;
      }
    }

    /// <summary>
    /// Retourne la valeur de la ligne IndexLine et la colonne IndexColumn.
    /// </summary>
    /// <param name="IndexLine">Index de la ligne de la valeur à retrouver</param>
    /// <param name="IndexColumn">Index de la colonne de la valeur à retrouver</param>
    /// <returns></returns>
    public double GetValue(int IndexLine, int IndexColumn) {
      return _matrix[IndexLine, IndexColumn];
    }

    /// <summary>
    /// Caclul l'inverse de la matrice actuelle
    /// </summary>
    /// <returns>Une nouvelle matrice inverse de la matrice actuelle</returns>
    public Matrix Invert() {
      if (!IsSquare) {
        throw new InvalidOperationException("La matrice actuelle doit être carrée");
      } else if (Determinant == 0) {
        throw new InvalidOperationException("Le déterminant de la matrice actuelle ne peut pas être nul");
      } else if (Width == 1) {
        return new Matrix(new double[,] { { 1 / Determinant } });
      } else {
        Matrix Result = new Matrix(Height, Width);
        int sign;
        for (int i = 0; i < Height; i++) {
          for (int j = 0; j < Width; j++) {
            sign = (((i + j) % 2) == 0) ? 1 : -1;
            Result.SetValue(i, j, (Reduce(i, j).Determinant * sign));
          }
        }
        Result = Result.Transpose();
        Result = Result.Multiply(1 / Determinant);
        return Result;
      }
      throw new NotImplementedException();
    }

    /// <summary>
    /// Multiplie la matrice actuelle avec un scalaire.
    /// </summary>
    /// <param name="val">La valeur avec laquelle la matrice sera multipliée.</param>
    /// <returns>Une nouvelle matrice résultant de la multuplication de la matrice actuelle avec le scalaire donné.</returns>
    public Matrix Multiply(double val) {
      Matrix NewMatrix = new Matrix(Height, Width);
      for (int i = 0; i < Height; i++) {
        for (int j = 0; j < Width; j++) {
          NewMatrix.SetValue(i, j, val * GetValue(i, j));
        }
      }
      return NewMatrix;
    }

    /// <summary>
    /// Multiplie la matrice actuelle avec une autre matrice.
    /// </summary>
    /// <param name="other">La matrice avec laquelle la matrice actuelle doit être multipliée</param>
    /// <returns>Une nouvelle matrice résultant de la multiplication de la matrice actuelle avec la matice donnée</returns>
    public Matrix Multiply(Matrix other) {
      if (this.Width == other.Height) {
        Matrix Result = new Matrix(this.Height, other.Width);
        for (int i = 0; i < Result.Height; i++) {
          for (int j = 0; j < Result.Width; j++) {
            double val = 0;
            for (int n = 0; n < this.Width; n++) {
              val += this.GetValue(i, n) * other.GetValue(n, j);
            }
            Result.SetValue(i, j, val);
          }
        }
        return Result;
      } else {
        throw new ArgumentException("La matrice actuelle doit avoir un nombre de colonnes égal au nombre de ligne de la matrice donnée");
      }
    }

    /// <summary>
    /// Retourne une matrice dont on a supprimé la ligne et la colonne.
    /// </summary>
    /// <param name="IndexLine">L'index de la ligne à supprimer.</param>
    /// <param name="IndexColumn">L'index de la colonne à supprimer.</param>
    /// <returns></returns>
    public Matrix Reduce(int IndexLine, int IndexColumn) {
      if (Width < 2 || Height < 2) {
        throw new InvalidOperationException(String.Format("La matrice est trop petite ({0}x{1}) pour être réduite", Height, Width));
      } else if (IndexLine < 0 || IndexLine >= Height) {
        throw new ArgumentOutOfRangeException("IndexLine");
      } else if (IndexColumn < 0 || IndexColumn >= Width) {
        throw new ArgumentOutOfRangeException("IndexColumn");
      } else {
        int idxLine;
        int idxColomn;
        Matrix NewMatrix = new Matrix(Height - 1, Width - 1);
        for (int i = 0; i < Height; i++) {
          if (i != IndexLine) {
            for (int j = 0; j < Width; j++) {
              if (j != IndexColumn) {
                idxLine = (i < IndexLine) ? i : i - 1;
                idxColomn = (j < IndexColumn) ? j : j - 1;
                NewMatrix.SetValue(idxLine, idxColomn, GetValue(i, j));
              }
            }
          }
        }
        return NewMatrix;
      }
    }

    /// <summary>
    /// Assigne une valeur.
    /// </summary>
    /// <param name="IndexLine">L'index de la ligne à assigner.</param>
    /// <param name="IndexColumn">L'index de la colonne à assigner.</param>
    /// <param name="value">La valeur assignée.</param>
    public void SetValue(int IndexLine, int IndexColumn, double value) {
      _matrix[IndexLine, IndexColumn] = value;
    }

    /// <summary>
    /// Soustrait une matrice à la matrice actuelle. Si la matrice données n'est pas de la même taille que la matrice actuelle, lève une exception 'ArgumentException'.
    /// </summary>
    /// <param name="other">La matrice à soustraire de la matrice actuelle.</param>
    /// <returns>Une matrice résultat de la soustraction de la matrice actuelle par la matrice donnée.</returns>
    public Matrix Substract(Matrix other) {
      if (this.Height != other.Height || this.Width != other.Width) {
        throw new ArgumentException("Le deux matrices doivent être de même taille");
      } else {
        Matrix NewMatrix = new Matrix(Height, Width);
        for (int i = 0; i < Height; i++) {
          for (int j = 0; j < Width; j++) {
            NewMatrix.SetValue(i, j, this.GetValue(i, j) - other.GetValue(i, j));
          }
        }
        return NewMatrix;
      }
    }

    /// <summary>
    /// Retourne la matrice actuelle sous forme de tableau.
    /// </summary>
    /// <returns>La matrice actuelle sous forme de tableau.</returns>
    public double[,] ToArray() {
      return _matrix;
    }

    /// <summary>
    /// Retourne la matrice actuelle sous forme de chaine de caractères.
    /// </summary>
    /// <returns>La matrice actuelle sous forme de chaine de caractères.</returns>
    public override string ToString() {
      string strReturn = "";
      for (int i = 0; i < Height; i++) {
        for (int j = 0; j < Width; j++) {
          strReturn += String.Format("  {0,8:#,##0.00}", GetValue(i, j));
        }
        if (i != (Height - 1)) {
          strReturn += Environment.NewLine;
        }
      }
      return strReturn;
    }

    /// <summary>
    /// Transpose la matrice actuelle.
    /// </summary>
    /// <returns>Une matrice résultat de la transposition de la matrice actuelle.</returns>
    public Matrix Transpose() {
      Matrix NewMatrix = new Matrix(Width, Height);
      for (int i = 0; i < Height; i++) {
        for (int j = 0; j < Width; j++) {
          NewMatrix.SetValue(j, i, GetValue(i, j));
        }
      }
      return NewMatrix;
    }
  }
}
