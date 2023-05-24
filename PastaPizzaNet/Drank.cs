using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastaPizzaNet;

public abstract class Drank : IBedrag
{
    public DrankSoort Naam { get; set; }
    public decimal Prijs { get; protected set; }

    public decimal BerekenBedrag()
    {
        //switch (Naam)
        //{
        //    case DrankSoort.Water:
        //    case DrankSoort.Limonade:
        //    case DrankSoort.CocaCola:
        //        Prijs = 2m;
        //        break;
        //    case DrankSoort.Koffie:
        //    case DrankSoort.Thee:
        //        Prijs = 2.5m;
        //        break;
        //    default:
        //        throw new InvalidOperationException("Ongeldige DrankSoort opgegeven.");
        //}
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
