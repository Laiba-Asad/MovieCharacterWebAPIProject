using Microsoft.EntityFrameworkCore.Storage.Internal;
using System.Text.Json.Serialization;

namespace MovieCharacterWebAPIProject.Models
{
    public class Backpack
    {
        public int backpackid { get; set; }
        public string Description { get; set;}
        public int CharacterId { get; set; }
        [JsonIgnore]
        public Character character { get; set; }
    }
}
