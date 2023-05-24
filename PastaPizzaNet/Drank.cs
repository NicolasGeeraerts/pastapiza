using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastaPizzaNet;

public abstract class Drank : IBedrag
{
    public DrankSoort Naam { get; set; }
    public decimal Prijs { get; set; }

    public virtual decimal BerekenBedrag()
    {
        return Prijs;
    }

    public override string ToString()
    {
        return Naam.ToString();
    }
}
public enum DrankSoort
{
    Water,
    Limonade,
    CocaCola,
    Koffie,
    Thee
}
