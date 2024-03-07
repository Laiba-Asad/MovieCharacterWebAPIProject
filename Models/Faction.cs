namespace MovieCharacterWebAPIProject.Models
{
    public class Faction
    {
        public int Factionid { get; set; }
        public string factionname { get; set; }
        public List<Character> characters { get; set;}
    }
}
