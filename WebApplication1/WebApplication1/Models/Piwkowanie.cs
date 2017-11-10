using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Piwkowanie : Iimpreza
    {

        private static Piwkowanie piwkowanieInstancja;
        List<IAlkochol> piwka;
        List<IKlient> listaKlientow;
        private decimal _rachunek;
        public decimal Rachunek { get {return _rachunek; } private set { _rachunek = value; } }
        public Piwkowanie(List<IAlkochol> listaPiw)
        {
            piwka = listaPiw;
            Rachunek = 0;
        }
        private Piwkowanie()
        {
            piwka =  new List<IAlkochol>()
            {
                 new Koncerniak("Zubr",4.53M), new Koncerniak("Tyskie",6.54M), new Koncerniak("Ksiazece",4.54M)
            };
            Rachunek = 0;

        }

        public static Piwkowanie PiwkowanieInstancja
        {
            get
            {
                if (piwkowanieInstancja == null)
                    piwkowanieInstancja = new Piwkowanie();
                return piwkowanieInstancja;
            }
        }

        public decimal podajAlko(string nazwa,int ilosc)
        {
            return piwka.FirstOrDefault(x => x.Nazwa == nazwa).Cena * ilosc;            
        }
        
        public List<IAlkochol> podajMenu()
        {
            return piwka;
        }

        public void dodajKlienta(IKlient klient)
        {
            listaKlientow.Add(klient);
        }

        public void pozegnajKlienta(IKlient klient)
        {
            listaKlientow.Remove(klient);
        }

        public void uregulujRachunek()
        {
            foreach (var item in listaKlientow)
            {
                item.Zaplac();
            }
        }
    }
}