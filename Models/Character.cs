using System.Text.Json.Serialization;

namespace MovieCharacterWebAPIProject.Models
{
    public class Character
    {
        public int CharacterId { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public Backpack backpack { get; set; }
        public List<Weapon> weapon { get; set; }
        public List<Faction> faction { get; set; }
    }
}
