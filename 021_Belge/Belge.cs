using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace _021_Belge {
  class Belge : PersonneBase {
    public enum ListeCommunaute { Flamand, Wallon };

    private ListeCommunaute _Communaute;

    public ListeCommunaute Communaute { get { return _Communaute; } protected set { _Communaute = value; } }

    public Belge(string Prenom, string Nom, ListeCommunaute Communaute)
      : base(Prenom, Nom) {
      this.Communaute = Communaute;
    }

    protected string GetCommunauteLabel() {
      string LabelCommunaute;
      switch (Communaute) {
        case ListeCommunaute.Flamand:
          LabelCommunaute = "Flamand";
          break;
        case ListeCommunaute.Wallon:
          LabelCommunaute = "Wallon";
          break;
        default:
          LabelCommunaute = "Klingon";
          break;
      }
      return LabelCommunaute;
    }

    public override string ToString() {
      return String.Format("{0} ({1})", base.ToString(), GetCommunauteLabel());
    }
  }
}
