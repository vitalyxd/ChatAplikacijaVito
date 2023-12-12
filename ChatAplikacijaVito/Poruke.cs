using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAplikacijaVito
{
    public class Poruke: IComparable
    {
        private string id;
        private Korisnik primatelj;
        private Korisnik posiljatelj;
        private string poruka;
        private DateTime posaljiPoruku;
        private bool privatnaPoruka;
        private bool grupnaPosiljka;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public Korisnik Primatelj
        {
            get { return primatelj; }
            set { primatelj = value; }
        }

        public Korisnik Posiljatelj
        {
            get { return posiljatelj; }
            set { posiljatelj = value; }
        }

        public string Poruka
        {
            get { return poruka; }
            set { poruka = value; }
        }

        public DateTime PosaljiPoruku
        {
            get { return posaljiPoruku; }
            set { posaljiPoruku = value; }
        }

        public bool PrivatnaPoruka
        {
            get { return privatnaPoruka; }
            set { privatnaPoruka = value; }
        }

        public bool GrupnaPosiljka
        {
            get { return grupnaPosiljka; }
            set { grupnaPosiljka = value; }
        }

        public int CompareTo(object obj)
        {
            int rez = this.id.CompareTo(((Poruke)obj).id);
            if (rez == 0) rez = this.primatelj.CompareTo(((Poruke)obj).primatelj);
        
            return rez;
        }

        public override string ToString()

            => Poruka + "," + Posiljatelj + "->" + Id.ToString();
    }

}
