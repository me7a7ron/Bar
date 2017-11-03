using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    enum RodzajPiwa
    {
        Koncerniak, Craftowe
    }
    public abstract class Piwo : IAlkochol
    {
       private string _nazwa;
       public string Nazwa { get { return _nazwa; } private set { _nazwa = value; } }


        RodzajPiwa Rodzaj { get; set; }

        private decimal _cena;

        public decimal Cena
        {
            get { return _cena; }
            private set { _cena = value; }
        }

        public Piwo(string pNazwa,decimal pCena)
        {
            Nazwa = pNazwa;
            Cena = pCena;
        }

        public decimal Zamow(int ilosc)
        {
            throw new NotImplementedException();
        }
    }
}
