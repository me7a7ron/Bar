using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public interface IAlkochol
    {
        string Nazwa { get;  }
        decimal Cena { get; }
        decimal Zamow(int ilosc);
    }
}
