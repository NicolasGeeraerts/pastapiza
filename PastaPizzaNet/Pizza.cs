using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastaPizzaNet;

public class Pizza : Gerecht
{
    public List<string> Onderdelen { get; set; }

    public Pizza()
    {
        Onderdelen = new List<string>();
    }

    public override string ToString()
    {
        return $"{base.ToString} ({string.Join(", ", Onderdelen)})";
    }
}
