using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using _018_Matrice;

namespace _018_MatriceTest {
  [TestFixture]
  public class MatrixTest {
    protected double[,] TestArray = new double[,] {{4.0,5.0,6.0,9.0},
                                                   {8.0,7.0,2.0,1.0},
                                                   {3.0,0.0,1.1,1.3}};
    protected Matrix TestMatrix;
    protected Random rnd;
    protected bool Initialized = false;

    [Test]
    public void T001_Matrix_Constructor_Height_Width() {
      int Height = 4;
      int Width = 6;
      TestMatrix = new Matrix(Height, Width);
      Assert.AreEqual(Height, TestMatrix.Height, "Height is not correct!!");
      Assert.AreEqual(Width, TestMatrix.Width, "Width is not correct!!");
    }

    [Test]
    public void T002_Matrix_Constructor_Array() {
      TestMatrix = new Matrix(TestArray);
      Assert.AreEqual(TestArray.GetLength(0), TestMatrix.Height, "Height is not correct!!");
      Assert.AreEqual(TestArray.GetLength(1), TestMatrix.Width, "Width is not correct!!");
    }

    [Test]
    public void T003_Matrix_Init_Followw() {
      TestMatrix = new Matrix(TestArray);
      rnd = new Random();
      Initialized = true;
    }

    [Test]
    public void T004_Matrix_MatrixType_NotNotable() {
      Assert.IsTrue(Initialized, "Please run 'T003_Matrix_Init_Followw' first");
      Assert.AreEqual(TestMatrix.MatrixType, Matrix.EnumMatrixType.NotNotable, "MatrixType does'nt return 'Matrix.EnumMatrixType.NotNotable' with not notable matrix");
    }

    [Test]
    public void T005_Matrix_GetValue() {
      Assert.IsTrue(Initialized, "Please run 'T003_Matrix_Init_Followw' first");
      int GetX = TestArray.GetLength(0) / 2;
      int GetY = TestArray.GetLength(1) / 2;
      Assert.Throws<IndexOutOfRangeException>(() => TestMatrix.GetValue(TestArray.GetLength(0) + 1, GetX), "GetValue does'nt return exception when line index is too hight");
      Assert.Throws<IndexOutOfRangeException>(() => TestMatrix.GetValue(-1, GetX), "GetValue does'nt return exception when line index is too low");
      Assert.Throws<IndexOutOfRangeException>(() => TestMatrix.GetValue(GetY, TestArray.GetLength(0) + 1), "GetValue does'nt return exception when column index is too hight");
      Assert.Throws<IndexOutOfRangeException>(() => TestMatrix.GetValue(GetY, -1), "GetValue does'nt return exception when column index is too low");
      Assert.AreEqual(TestArray[GetX, GetY], TestMatrix.GetValue(GetX, GetY));
      Assert.AreNotEqual(TestArray[GetX - 1, GetY + 1], TestMatrix.GetValue(GetX, GetY));
    }

    [Test]
    public void T006_Matrix_SetValue() {
      Assert.IsTrue(Initialized, "Please run 'T003_Matrix_Init_Followw' first");
      Matrix LocalTestMatrix = new Matrix(TestArray);
      int GetX = TestArray.GetLength(0) / 2;
      int GetY = TestArray.GetLength(1) / 2;
      double Val = LocalTestMatrix.GetValue(GetX, GetY);
      Assert.Throws<IndexOutOfRangeException>(() => LocalTestMatrix.SetValue(TestArray.GetLength(0) + 1, GetX, 5.2), "SetValue does'nt return exception when line index is too hight");
      Assert.Throws<IndexOutOfRangeException>(() => LocalTestMatrix.SetValue(-1, GetX, 5.2), "SetValue does'nt return exception when line index is too low");
      Assert.Throws<IndexOutOfRangeException>(() => LocalTestMatrix.SetValue(GetY, TestArray.GetLength(0) + 1, 5.2), "SetValue does'nt return exception when column index is too hight");
      Assert.Throws<IndexOutOfRangeException>(() => LocalTestMatrix.SetValue(GetY, -1, 5.2), "SetValue does'nt return exception when column index is too low");
      LocalTestMatrix.SetValue(GetX, GetY, Val + 5.2);
      Assert.AreNotEqual(LocalTestMatrix.GetValue(GetX, GetY), Val, "GetValue return old value");
      Assert.AreEqual(LocalTestMatrix.GetValue(GetX, GetY), Val + 5.2, "GetValue do'nt return new value");
    }

    [Test]
    public void T007_Matrix_IsDiagonal() {
      Assert.IsTrue(Initialized, "Please run 'T003_Matrix_Init_Followw' first");
      Matrix LocalTestMatrix = new Matrix(TestArray);
      Assert.IsFalse(LocalTestMatrix.IsDiagonal, "IsDiagonal returns true with not diagonal matrix");
      Assert.AreNotEqual(LocalTestMatrix.MatrixType, Matrix.EnumMatrixType.Diagonal, "MatrixType returns 'Matrix.EnumMatrixType.Diagonal' with not diagonal matrix");
      LocalTestMatrix = new Matrix(new double[,] {{2.0,0.0,0.0,0.0},
                                                 {0.0,4.0,0.0,0.0},
                                                 {0.0,0.0,6.0,0.0}});
      Assert.IsFalse(LocalTestMatrix.IsDiagonal, "IsDiagonal returns true with not diagonal matrix");
      Assert.AreNotEqual(LocalTestMatrix.MatrixType, Matrix.EnumMatrixType.Diagonal, "MatrixType returns 'Matrix.EnumMatrixType.Diagonal' with not diagonal matrix");
      LocalTestMatrix = new Matrix(new double[,] {{2.0,0.0,0.0},
                                                 {0.0,4.0,0.0},
                                                 {0.0,0.0,6.0}});
      Assert.IsTrue(LocalTestMatrix.IsDiagonal, "IsDiagonal returns false with diagonal matrix");
      Assert.AreEqual(LocalTestMatrix.MatrixType, Matrix.EnumMatrixType.Diagonal, "MatrixType does'nt return 'Matrix.EnumMatrixType.Diagonal' with diagonal matrix");
      LocalTestMatrix = new Matrix(new double[,] {{1.0,0.0,0.0},
                                                 {0.0,1.0,0.0},
                                                 {0.0,0.0,1.0}});
      Assert.IsTrue(LocalTestMatrix.IsDiagonal, "IsDiagonal returns false with unity matrix (in double)");
      LocalTestMatrix = new Matrix(new double[,] {{1,0,0},
                                                 {0,1,0},
                                                 {0,0,1}});
      Assert.IsTrue(LocalTestMatrix.IsDiagonal, "IsDiagonal returns false with unity matrix (in int)");
    }

    [Test]
    public void T008_Matrix_IsIdentity() {
      Assert.IsTrue(Initialized, "Please run 'T003_Matrix_Init_Followw' first");
      Matrix LocalTestMatrix = new Matrix(TestArray);
      Assert.IsFalse(LocalTestMatrix.IsIdentity, "IsIdentity returns true with not identity matrix");
      Assert.AreNotEqual(LocalTestMatrix.MatrixType, Matrix.EnumMatrixType.Identity, "MatrixType returns 'Matrix.EnumMatrixType.Identity' with not indentity matrix");
      LocalTestMatrix = new Matrix(new double[,] {{2.0,0.0,0.0},
                                                 {0.0,4.0,0.0},
                                                 {0.0,0.0,6.0}});
      Assert.IsFalse(LocalTestMatrix.IsIdentity, "IsIdentity return true with diagonal matrix");
      Assert.AreNotEqual(LocalTestMatrix.MatrixType, Matrix.EnumMatrixType.Identity, "MatrixType returns 'Matrix.EnumMatrixType.Identity' with diagonal matrix");
      LocalTestMatrix = new Matrix(new double[,] {{1.0,0.0,0.0},
                                                 {0.0,1.0,0.0},
                                                 {0.0,0.0,1.0}});
      Assert.IsTrue(LocalTestMatrix.IsIdentity, "IsIdentity return false with identity matrix");
      Assert.AreEqual(LocalTestMatrix.MatrixType, Matrix.EnumMatrixType.Identity, "MatrixType does'nt return 'Matrix.EnumMatrixType.Identity' with indentity matrix");
    }

    [Test]
    public void T009_Matrix_IsLowerTriangle() {
      Assert.IsTrue(Initialized, "Please run 'T003_Matrix_Init_Followw' first");
      Matrix LocalTestMatrix = new Matrix(TestArray);
      Assert.IsFalse(LocalTestMatrix.IsLowerTriangle, "IsLowerTriangle returns true with not lower triangle matrix");
      Assert.AreNotEqual(LocalTestMatrix.MatrixType, Matrix.EnumMatrixType.LowerTriangle, "MatrixType returns 'Matrix.EnumMatrixType.LowerTriangle' with not lower triangle matrix");
      LocalTestMatrix = new Matrix(new double[,] {{2.3,4.5,6.7},
                                                 {0.0,4.3,2.1},
                                                 {0.0,0.0,6.5}});
      Assert.IsTrue(LocalTestMatrix.IsLowerTriangle, "IsLowerTriangle return false with lower triangle matrix");
      Assert.AreEqual(LocalTestMatrix.MatrixType, Matrix.EnumMatrixType.LowerTriangle, "MatrixType does'nt return 'Matrix.EnumMatrixType.LowerTriangle' with lower triangle matrix");
    }

    [Test]
    public void T010_Matrix_IsSquare() {
      Assert.IsTrue(Initialized, "Please run 'T003_Matrix_Init_Followw' first");
      Matrix LocalTestMatrix = new Matrix(TestArray);
      Assert.IsFalse(LocalTestMatrix.IsSquare, "IsSquare returns true with not square matrix");
      Assert.AreNotEqual(LocalTestMatrix.MatrixType, Matrix.EnumMatrixType.Square, "MatrixType returns 'Matrix.EnumMatrixType.Square' with not square matrix");
      LocalTestMatrix = new Matrix(new double[,] {{2.3,4.5,6.7},
                                                 {9.9,4.3,2.1},
                                                 {8.7,4.7,6.5}});
      Assert.IsTrue(LocalTestMatrix.IsSquare, "IsSquare return false with lower triangle matrix");
      Assert.AreEqual(LocalTestMatrix.MatrixType, Matrix.EnumMatrixType.Square, "MatrixType does'nt return 'Matrix.EnumMatrixType.Square' with square matrix");
    }

    [Test]
    public void T011_Matrix_IsUpperTriangle() {
      Assert.IsTrue(Initialized, "Please run 'T003_Matrix_Init_Followw' first");
      Matrix LocalTestMatrix = new Matrix(TestArray);
      Assert.IsFalse(LocalTestMatrix.IsUpperTriangle, "IsUpperTriangle returns true with not upper triangle matrix");
      Assert.AreNotEqual(LocalTestMatrix.MatrixType, Matrix.EnumMatrixType.UpperTriangle, "MatrixType returns 'Matrix.EnumMatrixType.UpperTriangle' with not upper triangle matrix");
      LocalTestMatrix = new Matrix(new double[,] {{2.3,0.0,0.0},
                                                 {4.5,4.3,0.0},
                                                 {6.7,2.1,6.5}});
      Assert.IsTrue(LocalTestMatrix.IsUpperTriangle, "IsUpperTriangle return false with upper triangle matrix");
      Assert.AreEqual(LocalTestMatrix.MatrixType, Matrix.EnumMatrixType.UpperTriangle, "MatrixType does'nt return 'Matrix.EnumMatrixType.UpperTriangle' with upper triangle matrix");
    }

    [Test]
    public void T012_Matrix_IsZero() {
      Assert.IsTrue(Initialized, "Please run 'T003_Matrix_Init_Followw' first");
      Matrix LocalTestMatrix = new Matrix(TestArray);
      Assert.IsFalse(LocalTestMatrix.IsZero, "IsZero returns true with not zero matrix");
      Assert.AreNotEqual(LocalTestMatrix.MatrixType, Matrix.EnumMatrixType.Zero, "MatrixType returns 'Matrix.EnumMatrixType.Zero' with not zero matrix");
      LocalTestMatrix = new Matrix(new double[,] {{0.0,0.0,0.0,0.0},
                                                 {0.0,0.0,0.0,0.0},
                                                 {0.0,0.0,0.0,0.0}});
      Assert.IsTrue(LocalTestMatrix.IsZero, "IsZero return false with zero matrix");
      Assert.AreEqual(LocalTestMatrix.MatrixType, Matrix.EnumMatrixType.Zero, "MatrixType does'nt return 'Matrix.EnumMatrixType.Zero' with zero matrix");
    }

    [Test]
    public void T013_Matrix_IsSame() {
      Assert.IsTrue(Initialized, "Please run 'T003_Matrix_Init_Followw' first");
      Matrix LocalTestMatrix = new Matrix(TestArray);
      int GetX = TestArray.GetLength(0) / 2;
      int GetY = TestArray.GetLength(1) / 2;
      Assert.IsTrue(TestMatrix.Equals(LocalTestMatrix), "EqualsValues returns false with same matrix" + Environment.NewLine + TestMatrix + Environment.NewLine + LocalTestMatrix);
      LocalTestMatrix.SetValue(GetX, GetY, LocalTestMatrix.GetValue(GetX, GetY) + 2.4);
      Assert.IsFalse(TestMatrix.Equals(LocalTestMatrix), "EqualsValues returns true with not same matrix");
    }

    [Test]
    public void T014_Matrix_Multiply_Double() {
      Assert.IsTrue(Initialized, "Please run 'T003_Matrix_Init_Followw' first");
      double val = rnd.NextDouble() * 8.0;
      double[,] LocalTestArray = new double[TestArray.GetLength(0), TestArray.GetLength(1)];
      for (int i = 0; i < LocalTestArray.GetLength(0); i++) {
        for (int j = 0; j < LocalTestArray.GetLength(1); j++) {
          LocalTestArray[i, j] = TestArray[i, j] * val;
        }
      }
      Matrix LocalTestMatrix = new Matrix(LocalTestArray);
      Assert.IsTrue(LocalTestMatrix.Equals(TestMatrix.Multiply(val)), "Multiply error");
    }

    [Test]
    public void T015_Matrix_Add() {
      Assert.IsTrue(Initialized, "Please run 'T003_Matrix_Init_Followw' first");
      double[,] LocalTestArray = new double[,] {{4.0,5.0,6.0},
                                               {8.0,7.0,2.0},
                                               {3.0,0.0,1.1},
                                               {9.0,1.0,1.3}};
      Matrix LocalTestMatrix = new Matrix(LocalTestArray);
      Assert.Throws<ArgumentException>(() => LocalTestMatrix.Add(TestMatrix), "Add does'nt throw an axception with matrix of different sizes");
      LocalTestArray = new double[,] {{1.5,4.0,5.0,6.0},
                                     {4.3,3.0,0.0,1.1},
                                     {2.8,9.0,1.0,1.3}};
      LocalTestMatrix = new Matrix(LocalTestArray);
      double[,] ThisTestArrayAdd = new double[LocalTestArray.GetLength(0), LocalTestArray.GetLength(1)];
      for (int i = 0; i < LocalTestArray.GetLength(0); i++) {
        for (int j = 0; j < LocalTestArray.GetLength(1); j++) {
          ThisTestArrayAdd[i, j] = LocalTestArray[i, j] + TestArray[i, j];
        }
      }
      Matrix LocalTestMatrixAdd = new Matrix(ThisTestArrayAdd);
      Assert.DoesNotThrow(() => { LocalTestMatrix = LocalTestMatrix.Add(TestMatrix); }, "Add throws an axception with matrix of same size");
      Assert.IsTrue(LocalTestMatrixAdd.Equals(LocalTestMatrix), "Result of Add is not correct");
    }

    [Test]
    public void T016_Matrix_Substract() {
      Assert.IsTrue(Initialized, "Please run 'T003_Matrix_Init_Followw' first");
      double[,] LocalTestArray = new double[,] {{4.0,5.0,6.0},
                                               {8.0,7.0,2.0},
                                               {3.0,0.0,1.1},
                                               {9.0,1.0,1.3}};
      Matrix LocalTestMatrix = new Matrix(LocalTestArray);
      Assert.Throws<ArgumentException>(() => LocalTestMatrix.Substract(TestMatrix), "Substract does'nt throw an axception with matrix of different sizes");
      LocalTestArray = new double[,] {{1.5,4.0,5.0,6.0},
                                     {4.3,3.0,0.0,1.1},
                                     {2.8,9.0,1.0,1.3}};
      LocalTestMatrix = new Matrix(LocalTestArray);
      double[,] ThisTestArraySubstract = new double[LocalTestArray.GetLength(0), LocalTestArray.GetLength(1)];
      for (int i = 0; i < LocalTestArray.GetLength(0); i++) {
        for (int j = 0; j < LocalTestArray.GetLength(1); j++) {
          ThisTestArraySubstract[i, j] = LocalTestArray[i, j] - TestArray[i, j];
        }
      }
      Matrix LocalTestMatrixSubstract = new Matrix(ThisTestArraySubstract);
      Assert.DoesNotThrow(() => { LocalTestMatrix = LocalTestMatrix.Substract(TestMatrix); }, "Substract throws an axception with matrix of same size");
      Assert.IsTrue(LocalTestMatrixSubstract.Equals(LocalTestMatrix), "Result of Substract is not correct");
    }

    [Test]
    public void T017_Matrix_Transpose() {
      Assert.IsTrue(Initialized, "Please run 'T003_Matrix_Init_Followw' first");
      double[,] LocalTestArray = new double[TestArray.GetLength(1), TestArray.GetLength(0)];
      for (int i = 0; i < TestArray.GetLength(0); i++) {
        for (int j = 0; j < TestArray.GetLength(1); j++) {
          LocalTestArray[j, i] = TestArray[i, j];
        }
      }
      Matrix LocalTestMatrix = new Matrix(LocalTestArray);
      Assert.IsTrue(LocalTestMatrix.Equals(TestMatrix.Transpose()), "Transpose does'nt return right values");
    }

    [Test]
    public void T018_Matrix_Reduce() {
      Assert.IsTrue(Initialized, "Please run 'T003_Matrix_Init_Followw' first");
      double[,] LocalTestArray;
      Matrix LocalTestMatrix;
      LocalTestArray = new double[,] { { 4.6 } };
      LocalTestMatrix = new Matrix(LocalTestArray);
      Assert.Throws<InvalidOperationException>(() => LocalTestMatrix.Reduce(0, 0), "Reduce does'nt throw an axception when it is to small to be reduced");
      LocalTestArray = new double[,] {{4.0,5.0,9.0},
                                     {3.0,0.0,1.3}};
      LocalTestMatrix = new Matrix(LocalTestArray);
      Assert.Throws<ArgumentOutOfRangeException>(() => LocalTestMatrix.Reduce(10, 2), "Reduce does'nt throw an axception when line index is too hight");
      Assert.Throws<ArgumentOutOfRangeException>(() => LocalTestMatrix.Reduce(1, 20), "Reduce does'nt throw an axception when column index is too hight");
      Assert.DoesNotThrow(() => TestMatrix.Reduce(1, 2), "Reduce throws an axception in normal operation");
      Assert.IsTrue(LocalTestMatrix.Equals(TestMatrix.Reduce(1, 2)), "Reduce does'nt return right values");
    }

    [Test]
    public void T019_Matrix_Determinant() {
      Assert.IsTrue(Initialized, "Please run 'T003_Matrix_Init_Followw' first");
      double[,] LocalTestArray;
      Matrix LocalTestMatrix;
      double determinant;
      Assert.Throws<InvalidOperationException>(() => { determinant = TestMatrix.Determinant; }, "Determinant does'nt throw an axception with a non square matrix");
      LocalTestArray = new double[,] { { 3.5 } };
      LocalTestMatrix = new Matrix(LocalTestArray);
      Assert.AreEqual(3.5, LocalTestMatrix.Determinant, "Determinant does'nt retrun right value on 1x1 matrix");
      LocalTestArray = new double[,] {{3.5,7.8},
                                     {4.1,2.5}};
      LocalTestMatrix = new Matrix(LocalTestArray);
      determinant = LocalTestArray[0, 0] * LocalTestArray[1, 1] - LocalTestArray[1, 0] * LocalTestArray[0, 1];
      Assert.AreEqual(determinant, LocalTestMatrix.Determinant, "Determinant does'nt retrun right value on 2x2 matrix");
      LocalTestArray = new double[,] {{5.43,-0.57,4.86,-0.29},
                                     {1.57,2.43,9.14,4},
                                     {-9.14,4.86,-5.57,-9.86},
                                     {6.57,4.43,4.29,1.14}};
      LocalTestMatrix = new Matrix(LocalTestArray);
      determinant = -3080.33254928;
      Assert.AreEqual(determinant, LocalTestMatrix.Determinant, "Determinant does'nt retrun right value on 4x4 matrix");
    }

    [Test]
    public void T020_Matrix_Multiply_Matrix() {
      Assert.IsTrue(Initialized, "Please run 'T003_Matrix_Init_Followw' first");
      double[,] LocalTestArray = new double[,] {{-2.1,-5.0,-8.3},
                                               { 4.8, 4.7,-8.7},
                                               { 1.7, 8.7, 8.7},
                                               { 2.4,-9.1,-3.5}};
      Matrix LocalTestMatrix = new Matrix(LocalTestArray);
      Matrix ExpectedResult = new Matrix(new double[,] {{  47.40, -26.20, -56.00},
                                                        {  22.60,   1.20,-113.40},
                                                        {  -1.31, -17.26, -19.88}});
      Assert.Throws<ArgumentException>(() => TestMatrix.Multiply(TestMatrix), "Multiply does'nt throw an exception when multiplying a matrice with number of column different of number of lines of the other");
      Assert.DoesNotThrow(() => TestMatrix.Multiply(LocalTestMatrix), "Multiply throws an exception when multiplying a matrice with number of column equal of number of lines of the other");
      Assert.IsTrue(ExpectedResult.Equals(TestMatrix.Multiply(LocalTestMatrix)), "Matrix multiplication does'nt return right values:\n" + TestMatrix.Multiply(LocalTestMatrix) + "\n" + ExpectedResult);
    }

    [Test]
    public void T021_Matrix_invert() {
      Assert.IsTrue(Initialized, "Please run 'T003_Matrix_Init_Followw' first");
      Matrix LocalTestMatrix;
      Matrix ExpectedResultMatrix;
      Matrix UnitaryMatrix;
      Assert.Throws<InvalidOperationException>(() => TestMatrix.Invert(), "Invert does'nt throw an exception when inverting a non square matrix");
      LocalTestMatrix = new Matrix(new double[,] {{1,1},{3,3}});
      Assert.Throws<InvalidOperationException>(() => TestMatrix.Invert(), "Invert does'nt throw an exception when matrix has a null determinant");
      LocalTestMatrix = new Matrix(new double[,] { { -2.8, 6.2, 7.5, 4.7 },    
                                                   { -9.0, 0.0, 6.3, 4.4 },
                                                   {  0.2, 5.8, 8.7,-6.1 },
                                                   { -1.1,-7.8,-1.8, 1.3 } });
      ExpectedResultMatrix = new Matrix(new double[,] { {  0.16,-0.18, 0.02, 0.14 },    
                                                        { -0.02, 0.03,-0.04,-0.17 },
                                                        {  0.12,-0.05, 0.09, 0.16 },
                                                        {  0.15,-0.06,-0.08, 0.06 } });
      UnitaryMatrix = new Matrix(new double[,] { { 1.0, 0.0, 0.0, 0.0 },    
                                                 { 0.0, 1.0, 0.0, 0.0 },
                                                 { 0.0, 0.0, 1.0, 0.0 },
                                                 { 0.0, 0.0, 0.0, 1.0 } });

      Assert.IsTrue(ExpectedResultMatrix.Equals(LocalTestMatrix.Invert()), "Invert does'nt return expected values" + Environment.NewLine + LocalTestMatrix.Invert() + Environment.NewLine + "=>" + Environment.NewLine + ExpectedResultMatrix);
      Assert.IsTrue(UnitaryMatrix.Equals(LocalTestMatrix.Multiply(LocalTestMatrix.Invert())), "Multiplication of matrix with its inverted does'nt return unitary matrix");
    }
  }
}
