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
        string _datum;
        bool _cijepljen;
        bool _kastriran;
        string _napomena;
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

        public string Datum
        {
            get { return _datum; }
            set { _datum = value; }
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

        public string Slika
        {
            get { return _slika; }
            set { _slika = value; }
        }

        public Zivotinja(string ime, string vrsta, string pasmina, string spol, int dob, string datum, bool cijepljen, bool kastriran, string napomena, string slika)
        {
            _ime = ime;
            _vrsta = vrsta;
            _pasmina = pasmina;
            _spol = spol;
            _dob = dob;
            _datum = datum;
            _cijepljen = cijepljen;
            _kastriran = kastriran;
            _napomena = napomena;
            _slika = slika;
        }
    }
}
