using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastaPizzaNet;

public class Frisdrank : Drank
{
    public Frisdrank(DrankSoort drankSoort)
    {
        if (drankSoort != DrankSoort.Koffie || drankSoort != DrankSoort.Thee)
        {
            Naam = drankSoort;
            Prijs = 2m;
        }
        else
        {
            throw new InvalidOperationException("Ongeldige DrankSoort opgegeven.");
        }
    }
}