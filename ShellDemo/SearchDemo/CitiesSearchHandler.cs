namespace ShellDemo.SearchDemo;

public class City
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class CitiesSearchHandler : SearchHandler
{
    protected override void OnQueryChanged(string oldValue, string newValue)
    {
        base.OnQueryChanged(oldValue, newValue);

        ItemsSource = cities.Where(city => city.Name.ToLower().Contains(Query.ToLower())).ToList();
    }

    protected override void OnItemSelected(object item)
    {
        base.OnItemSelected(item);
    }

    // A list with all cities in Sweden
    private IReadOnlyList<City> cities = new List<City>
    {
        new City { Id = 1, Name = "Stockholm" },
        new City { Id = 2, Name = "Göteborg" },
        new City { Id = 3, Name = "Malmö" },
        new City { Id = 4, Name = "Uppsala" },
        new City { Id = 5, Name = "Västerås" },
        new City { Id = 6, Name = "Örebro" },
        new City { Id = 7, Name = "Linköping" },
        new City { Id = 8, Name = "Helsingborg" },
        new City { Id = 9, Name = "Jönköping" },
        new City { Id = 10, Name = "Norrköping" },
        new City { Id = 11, Name = "Lund" },
        new City { Id = 12, Name = "Umeå" },
        new City { Id = 13, Name = "Gävle" },
        new City { Id = 14, Name = "Borås" },
        new City { Id = 15, Name = "Eskilstuna" },
        new City { Id = 16, Name = "Södertälje" },
        new City { Id = 17, Name = "Karlstad" },
        new City { Id = 18, Name = "Täby" },
        new City { Id = 19, Name = "Växjö" },
        new City { Id = 20, Name = "Halmstad" },
        new City { Id = 21, Name = "Bromma" },
        new City { Id = 22, Name = "Västerhaninge" },
        new City { Id = 23, Name = "Haninge" },
        new City { Id = 24, Name = "Sollentuna" },
        new City { Id = 25, Name = "Tumba" },
        new City { Id = 26, Name = "Nacka" },
        new City { Id = 27, Name = "Luleå" },
        new City { Id = 28, Name = "Borlänge" },
        new City { Id = 29, Name = "Trollhättan" },
        new City { Id = 30, Name = "Upplands Väsby" },
        new City { Id = 31, Name = "Östersund" },
        new City { Id = 32, Name = "Falun" },
        new City { Id = 33, Name = "Trelleborg" },
        new City { Id = 34, Name = "Ängelholm" },
        new City { Id = 35, Name = "Majorna" },
        new City { Id = 36, Name = "Sandviken" },
        new City { Id = 37, Name = "Kungälv" },
        new City { Id = 38, Name = "Vallentuna" },
        new City { Id = 39, Name = "Kristianstad" },
        new City { Id = 40, Name = "Kalmar" },
        new City { Id = 41, Name = "Skövde" },
        new City { Id = 42, Name = "Karlskrona" },
        new City { Id = 43, Name = "Skellefteå" },
        new City { Id = 44, Name = "Lidingö" },
        new City { Id = 45, Name = "Nyköping" },
        new City { Id = 46, Name = "Partille" },
        new City { Id = 47, Name = "Motala" },
        new City { Id = 48, Name = "Karlskoga" },
        new City { Id = 49, Name = "Piteå" },
        new City { Id = 50, Name = "Falkenberg" },
        new City { Id = 51, Name = "Boden" },
        new City { Id = 52, Name = "Täby kyrkby" },
        new City { Id = 53, Name = "Lerum" },
        new City { Id = 54, Name = "Arboga" },
        new City { Id = 55, Name = "Kungsbacka" },
        new City { Id = 56, Name = "Katrineholm" },
        new City { Id = 57, Name = "Vänersborg" },
        new City { Id = 58, Name = "Enköping" },
        new City { Id = 59, Name = "Falköping" },
        new City { Id = 60, Name = "Mariestad" },
        new City { Id = 61, Name = "Hudiksvall" },
        new City { Id = 62, Name = "Västervik" },
        new City { Id = 63, Name = "Kumla" },
        new City { Id = 64, Name = "Oskarshamn" },
        new City { Id = 65, Name = "Ystad" },
        new City { Id = 66, Name = "Eslöv" },
        new City { Id = 67, Name = "Hässleholm" },
        new City { Id = 68, Name = "Köping" },
        new City { Id = 69, Name = "Härnösand" },
        new City { Id = 70, Name = "Västervik" },
        new City { Id = 71, Name = "Nässjö" },
        new City { Id = 72, Name = "Strängnäs" },
        new City { Id = 73, Name = "Visby" }
    };
}
