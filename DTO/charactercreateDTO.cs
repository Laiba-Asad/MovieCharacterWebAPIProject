namespace MovieCharacterWebAPIProject.DTO
{

    public record struct charactercreateDTO(string Name, backpackcreateDTO Backpackcreate, List<weaponcreateDTO>  weapon, List<factioncreateDTO> factions);
}
