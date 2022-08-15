using AutoMapper;
using RPG_Game.Dtos.Character;
using RPG_Game.Models;

namespace RPG_Game
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>(); 
            CreateMap<AddCharacterDto, Character>();
            CreateMap<UpdateCharacterDto, Character>();
        }
        
    }
}
