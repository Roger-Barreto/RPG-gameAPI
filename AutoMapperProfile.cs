using AutoMapper;
using RPG_game.API.Controllers.Models;
using RPG_game.API.Dtos.Character;


namespace RPG_game.API
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
        }
    }
}