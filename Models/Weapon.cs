using System.Text.Json.Serialization;

namespace MovieCharacterWebAPIProject.Models
{
    public class Weapon
    {
        public int WeaponId{ get; set; }
        public string WeaponName  { get; set; }
        [JsonIgnore]
        public int CharacterId { get; set; }
        public Character? character { get; set; }
    }
}
