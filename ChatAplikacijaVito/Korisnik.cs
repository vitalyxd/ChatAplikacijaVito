using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAplikacijaVito
{
    public class Korisnik: IComparable
    {
        private string id;
        private string ime;
        private string prezime;
        private string username;
        private string password;
        private string email;

        public string Id
        {
            get { return id; }
            set { id = value; } 
        }

        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }

        }

        public int CompareTo(object obj)
        {
            int rez = this.id.CompareTo(((Korisnik)obj).id);
            if (rez == 0) rez = this.username.CompareTo(((Korisnik)obj).username);
            if (rez == 0) rez = this.email.CompareTo(((Korisnik)obj).email); 
            return rez;
        }

        public override string ToString()

            => Username + "," + Email + "->" + Id.ToString();

    }
}
    

    
}
