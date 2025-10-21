using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azil
{
    internal class Zivotinja
    {
        string _ime;
        string _vrsta;
        string _pasmina;
        string _spol;
        int _dob;
        string _datumD;
        string _datumU;
        bool _cijepljen = false;
        bool _kastriran = false;
        string _napomena;
        string _udomitelj = "";
        string _kontakt = "";
        string _slika;

        public string Ime
        {
            get { return _ime; }
            set { _ime = value; }
        }

        public string Vrsta
        {
            get { return _vrsta; }
            set { _vrsta = value; }
        }

        public string Pasmina
        {
            get { return _pasmina; }
            set { _pasmina = value; }
        }

        public string Spol
        {
            get { return _spol; }
            set { _spol = value; }
        }

        public int Dob 
        { 
            get { return _dob; }
            set { _dob = value; }
        }

        public string DatumD
        {
            get { return _datumD; }
            set { _datumD = value; }
        }

        public string DatumU
        {
            get { return _datumU; }
            set { _datumU = value; }
        }

        public bool Cijepljen
        {
            get { return _cijepljen; }
            set { _cijepljen = value; }
        }

        public bool Kastriran
        {
            get { return _kastriran; }
            set { _kastriran = value; }
        }

        public string Napomena
        {
            get { return _napomena; }
            set { _napomena = value; }
        }

        public string Udomitelj
        {
            get { return _udomitelj; }
            set { _udomitelj = value; }
        }

        public string Kontakt
        {
            get { return _kontakt; }
            set { _kontakt = value;}
        }

        public string Slika
        {
            get { return _slika; }
            set { _slika = value; }
        }

        public Zivotinja(string ime, string vrsta, string pasmina, string spol, int dob, string datumD,string datumU, bool cijepljen, bool kastriran, string napomena, string udomitelj, string kontakt, string slika)
        {
            _ime = ime;
            _vrsta = vrsta;
            _pasmina = pasmina;
            _spol = spol;
            _dob = dob;
            _datumD = datumD;
            _datumU = datumU;
            _cijepljen = cijepljen;
            _kastriran = kastriran;
            _napomena = napomena;
            _udomitelj = udomitelj;
            _kontakt = kontakt;
            _slika = slika;
        }
    }
}
