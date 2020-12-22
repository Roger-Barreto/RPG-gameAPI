using RPG_game.API.Controllers.Models;

namespace RPG_game.API.Dtos.Character
{
    public class AddCharacterDto
    {
        public string Name { get; set;} = "Frodo";
        public int HitPoints { get; set;} = 100;
        public int Strenght { get; set;} = 10;
        public int Defense { get; set;} = 10;
        public int Intelligence { get; set;} = 10;
        public RpgClass Class { get; set;} = RpgClass.Knight;
    }
}