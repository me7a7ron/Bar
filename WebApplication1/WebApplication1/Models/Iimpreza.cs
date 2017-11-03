using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
  public  interface Iimpreza
    {
        decimal podajAlko(string nazwa, int ilosc);
        List<IAlkochol> podajMenu();
        void dodajKlienta(IKlient klient);
        void pozegnajKlienta(IKlient klient);
        void uregulujRachunek();
    }
}
