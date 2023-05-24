using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastaPizzaNet;
public abstract class Gerecht : IBedrag
{
    public string Naam { get; set; }
    public decimal Prijs { get; set; }

    public  decimal BerekenBedrag()
    {
        return Prijs;
    }

    public override string ToString()
    {
        return Naam;
    }
}
