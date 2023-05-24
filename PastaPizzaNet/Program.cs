
using System.Net.WebSockets;

namespace PastaPizzaNet;

public class Program
{
    public static void Main()
    {
        Klant klant = new Klant { KlantID = 1, Naam = "Nicolas Geeraerts" };

        Pizza pizza = new Pizza { Naam = "Margherita" };
        pizza.Onderdelen.Add("Tomatensaus");
        pizza.Onderdelen.Add("Mozzarella");

        BesteldGerecht besteldGerecht = new BesteldGerecht
        {
            Gerecht = pizza,
            Grootte = GrootteSoort.Groot,
            Extras = new List<ExtraSoort> { ExtraSoort.Brood, ExtraSoort.Kaas }
        };

        Frisdrank frisdrank = new Frisdrank { Naam = DrankSoort.CocaCola };

        Dessert dessert = new Dessert { Naam = DessertSoort.Tiramisu };

        Bestelling bestelling = new Bestelling
        {
            Klant = klant,
            Gerecht = besteldGerecht,
            Drank = frisdrank,
            Dessert = dessert,
            Aantal = 2
        };

        //Console.WriteLine("Bestelling details:");
        //Console.WriteLine("Klant: " + (bestelling.Klant != null ? bestelling.Klant.Naam : "Onbekende klant"));
        //Console.WriteLine("Gerecht: " + bestelling.Gerecht +"  " + bestelling.Gerecht.BerekenBedrag());
        //Console.WriteLine("Drank: " + bestelling.Drank + "  " + bestelling.Drank.BerekenBedrag()) ;
        //Console.WriteLine("Dessert: " + bestelling.Dessert + "  " + bestelling.Dessert.BerekenBedrag()) ;
        //Console.WriteLine("Aantal: " + bestelling.Aantal);
        //Console.WriteLine("Totale kosten: €" + bestelling.BerekenBedrag());
        Console.WriteLine(bestelling.ToString());
    }
}