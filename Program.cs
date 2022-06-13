List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46,"Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
// IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
// Use Linq to find the first eruption that is in CHile
// IEnumerable<Eruption> chileEruption = eruptions.Where(p => p.Location.Contains( "Chile"));
Eruption? cErupt = eruptions.FirstOrDefault(p => p.Location == "Chile");

// Find Hawaiian Is eruption, if non pringt no hawaiian is found
IEnumerable<Eruption> hawaiiIsland = eruptions.Where(h => h.Location == "Hawaiian Is");
Console.WriteLine(hawaiiIsland.FirstOrDefault()!=null?("Hawaiian Is" + hawaiiIsland.First().Volcano): "No Hawaiian Is Eruption found");
// da

// Find eruption after year 1900 AND is in New Zealand
IEnumerable<Eruption> nz1900 = eruptions.Where(nz => nz.Location =="New Zealand" && nz.Year > 1900);

// All eruptions over 2000m
IEnumerable<Eruption> over2000 = eruptions.Where(e => e.ElevationInMeters > 2000);

// All eruptions wehre volcano name starts with Z
IEnumerable<Eruption> zVolcano = eruptions.Where(z => z.Volcano.StartsWith("Z"));
;

// Highest elevation and print only that integer
int maxElevation = eruptions.Max(eruption => eruption.ElevationInMeters);
Eruption? tallestVolcano = eruptions.FirstOrDefault(big => big.ElevationInMeters == maxElevation);
// Use the highest elevation variable to print name of volcano with elevation
// height? tallestVolcano = eruptions.FirstOrDefault(volcano => volcano.ElevationInMeters = maxElevation);

// Print volcanos names alphabetically
IEnumerable<Eruption> abcVolcano = eruptions.OrderBy(abc=>abc.Volcano).ToList();


// Print all eruptions that happened before the year 1000CE alpabetically by namne
IEnumerable<Eruption> oldAbcVolcano = eruptions.Where(a => a.Year < 1000 ).OrderBy(a => a.Volcano);
// Execute Assignment Tasks here!
// PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");

// PrintEach(chileEruption);
// PrintEach(hawaiiIsland);
// PrintEach(nz1900);
// PrintEach(over2000);
// PrintEach(zVolcano);
// PrintEach(abcVolcano);
PrintEach(oldAbcVolcano);

// First eruption that is in Chile
// The lambda here uses a variable 'prod' which represents a product 
// (although this may be named whatever you like)  
//  The right hand side of the arrow is selecting Price as the thing we want to order by.




// Helper method to print each item in a List or IEnumerable.This should remain at the bottom of your class!
static void PrintEach(IEnumerable<dynamic> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (var item in items)
    {
        Console.WriteLine(item.ToString());
    }
}

