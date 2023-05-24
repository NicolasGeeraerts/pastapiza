using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastaPizzaNet;

public class Pasta : Gerecht
{
    public string Omschrijving { get; set; }

    public override string ToString()
    {
        return $"{base.ToString} {Omschrijving}";
    }
}
