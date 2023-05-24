using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastaPizzaNet;

public class BesteldGerecht
{
    public Gerecht Gerecht { get; set; }
    public GrootteSoort Grootte { get; set; }
    public List<ExtraSoort> Extras { get; set; }

    public BesteldGerecht()
    {
        Extras = new List<ExtraSoort>();
    }

    public decimal BerekenBedrag()
    {
        decimal bedrag = Gerecht.BerekenBedrag();

        if (Grootte == GrootteSoort.Groot)
            bedrag += 3.0m;

        bedrag += Extras.Count * 1.0m;

        return bedrag;
    }

    public override string ToString()
    {
        string gerecht = $"{Gerecht.Naam} ({Grootte})";

        if (Extras.Count > 0)
        {
            string extras = string.Join(", ", Extras);
            gerecht += $" + {extras}";
        }

        return gerecht;
    }


}

public enum GrootteSoort

{
    Klein,
    Groot
}

public enum ExtraSoort
{
    Brood,
    Kaas,
    Look
}