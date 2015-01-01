using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_Cesar {
  class Cesar {
    protected int offset;
    /// <summary>
    /// Constructeur sans paramètre, la valeur par défaut est -3
    /// </summary>
    public Cesar() : this(-3) { }

    /// <summary>
    /// Constructeur
    /// </summary>
    /// <param name="offset">Décalage des lettres du message</param>
    public Cesar(int offset) {
      this.offset = offset;
    }

    /// <summary>
    /// Chiffrement du texte
    /// </summary>
    /// <param name="text">Le texte à coder</param>
    /// <returns>Le texte codé</returns>
    public string Cipher(string text) {
      text = text.ToLower();
      string ciphered = "";
      for (int i = 0; i < text.Length; i++) {
        ciphered += CipherChar(text[i]);
      }
      return ciphered;
    }

    /// <summary>
    /// Décodage du texte
    /// </summary>
    /// <param name="text">Le texte à décoder</param>
    /// <returns>Le texte décodé</returns>
    public string Decipher(string text) {
      text = text.ToLower();
      string deciphered = "";
      for (int i = 0; i < text.Length; i++) {
        deciphered += DecipherChar(text[i]);
      }
      return deciphered;
    }

    /// <summary>
    /// Codage d'un caractère
    /// </summary>
    /// <param name="character">Le caractère à coder</param>
    /// <returns>Le caractère codé</returns>
    protected char CipherChar(char character) {
      return CharUnoverflow((char)(character + offset));
    }

    /// <summary>
    /// Décodage d'un caractère
    /// </summary>
    /// <param name="character">Le caractère à décoder</param>
    /// <returns>Le caractère décodé</returns>
    protected char DecipherChar(char character) {
      return CharUnoverflow((char)(character - offset));
    }

    /// <summary>
    /// Vérifie si un caractère se trouve en dehors de l'alphabet. Si c'est le cas, le caractère sera
    /// replacé dans l'alphabet
    /// </summary>
    /// <param name="character">Le caractère à vérifier</param>
    /// <returns>Le caractère éventuellement corrigé</returns>
    protected char CharUnoverflow(char character) {
      int minChar = (int)'a';
      int maxChar = (int)'z';
      int valChar = (int)character;
      char charReturn;
      if (valChar < minChar) {
        charReturn = (char)(valChar + (maxChar-minChar+1));
      } else if (valChar > maxChar) {
        charReturn = (char)(valChar - (maxChar-minChar+1));
      } else {
        charReturn = character;
      }
      return charReturn;
    }
  }
}
