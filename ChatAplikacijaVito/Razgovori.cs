using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ChatAplikacijaVito
{
    public class Razgovori: IComparable
    {
        private string id;
        private Korisnik brojKorisnika;
        private bool aktivan;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public Korisnik BrojKorisnika
        {
            get { return brojKorisnika; }
            set { brojKorisnika = value; }
        }

        public bool Aktivan
        {
            get { return aktivan; }
            set { aktivan = value; }
        }

        public int CompareTo(object obj)
        {
            int rez = this.id.CompareTo(((Razgovori)obj).id);
            if (rez == 0) rez=this.brojKorisnika.CompareTo(((Razgovori)obj).brojKorisnika);
            return rez;
        }

        public override string ToString()

            => BrojKorisnika.ToString() + "," + Aktivan.ToString() + "->" + Id.ToString();
    }      


}
