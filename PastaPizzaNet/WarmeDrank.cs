using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PastaPizzaNet;

public class WarmeDrank : Drank
{
    public WarmeDrank(DrankSoort drankSoort)
    {
        if (drankSoort == DrankSoort.Koffie || drankSoort == DrankSoort.Thee)
        {
            Naam = drankSoort;
            Prijs = 2.5m;
        }
        else
        {
            throw new InvalidOperationException("Ongeldige DrankSoort opgegeven.");
        }
    }
}

