using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastaPizzaNet;

public class Bestelling : IBedrag
{
    public Klant Klant { get; set; }
    public BesteldGerecht Gerecht { get; set; }
    public Drank Drank { get; set; }
    public Dessert Dessert { get; set; }
    public int Aantal { get; set; }

    public Bestelling()
    {
        Aantal = 1;
    }

    public decimal BerekenBedrag()
    {
        decimal gerechtBedrag = Gerecht != null ? Gerecht.BerekenBedrag() : 0.0m;
        decimal drankBedrag = Drank != null ? Drank.BerekenBedrag() : 0.0m;
        decimal dessertBedrag = Dessert != null ? Dessert.BerekenBedrag() : 0.0m;

        decimal totaalBedrag = gerechtBedrag + drankBedrag + dessertBedrag;

        if (Gerecht != null && Drank != null && Dessert != null)
            totaalBedrag *= 0.9m; 

        return totaalBedrag * Aantal;
    }
    public virtual string ToString()
    {
        string result = "Bestelling details:\n";
        result += "Klant: " + (Klant != null ? Klant.Naam : "Onbekende klant") + "\n";
        result += "Gerecht: " + Gerecht + "  " + Gerecht.BerekenBedrag() + "\n";
        result += "Drank: " + Drank + "  " + Drank.BerekenBedrag() + "\n";
        result += "Dessert: " + Dessert + "  " + Dessert.BerekenBedrag() + "\n";
        result += "Aantal: " + Aantal + "\n";
        result += "Totale kosten: " + BerekenBedrag().ToString("0.00") + "\n";

        return result;
    }
}
