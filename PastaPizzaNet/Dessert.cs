using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastaPizzaNet;

public class Dessert : IBedrag
{
    public DessertSoort Naam { get; set; }
    public decimal Prijs { get; set; }

    public decimal BerekenBedrag()
    {
        switch (Naam)
        {
            case DessertSoort.Tiramisu:
                Prijs = 3;
                break;
            case DessertSoort.Ijs:
                Prijs = 3;
                break;
            case DessertSoort.Cake:
                Prijs = 2;
                break;
        }
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
