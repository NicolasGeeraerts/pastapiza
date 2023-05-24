using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastaPizzaNet;

public class Dessert : IBedrag
{
    public DessertSoort Naam { get; set; }
    public decimal Prijs
    {
        get
        {
            switch (Naam)
            {
                case DessertSoort.Tiramisu:
                    return 3;
                case DessertSoort.Ijs:
                    return 3;
                case DessertSoort.Cake:
                    return 2;
                default:
                    throw new ArgumentException();
            }
        }
    }

    public decimal BerekenBedrag()
    {
        return Prijs;
    }

    public override string ToString()
    {
        return Naam.ToString();
    }
}
public enum DessertSoort
{
    Tiramisu,
    Ijs,
    Cake
}
