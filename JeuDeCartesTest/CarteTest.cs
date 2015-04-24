using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JeuDeCartes;

namespace JeuDeCartesTest {
  [TestClass]
  public class CarteTest {
    [TestMethod]
    public void ToStringTest() {
      Carte Carte = new Carte(Valeur.Dame, Couleur.Pique);
      Assert.AreEqual(Carte.ToString(), "dame de pique");
    }
  }
}
