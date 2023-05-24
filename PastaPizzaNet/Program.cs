
namespace PastaPizzaNet;

public class Program
{
    public static void Main()
    {
        Klant klant = new Klant { KlantID = 1, Naam = "John Doe" };

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

        Console.WriteLine("Bestelling details:");
        Console.WriteLine("Klant: " + (bestelling.Klant != null ? bestelling.Klant.Naam : "Onbekende klant"));
        Console.WriteLine("Gerecht: " + bestelling.Gerecht);
        Console.WriteLine("Drank: " + bestelling.Drank);
        Console.WriteLine("Dessert: " + bestelling.Dessert);
        Console.WriteLine("Aantal: " + bestelling.Aantal);
        Console.WriteLine("Totale kosten: €" + bestelling.BerekenBedrag());
    }
}