using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Koncerniak : Piwo
    {
       // string _nazwa;
       // public string Nazwa { get { return _nazwa; } private set { _nazwa = value; } }
        //private decimal _cena;
        //public decimal Cena
        //{
        //    get { return _cena; }
        //    private set { _cena = value; }
        //}
        

        public Koncerniak(string _Nazwa) : base(_Nazwa,4.32M)
        { 
            RodzajPiwa rodzaj = RodzajPiwa.Koncerniak;
        }

        public decimal Zamow(int ilosc)
        {
            return Cena * ilosc ;
        }
    }
}