using ELearning_API.DTOs;
using ELearning_API.Models;
using Mapster;

namespace ELearning_API.Profiles
{
    public class MapsterProfile : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<RegisterDTO, ApplicationUser>()
                .Map(dest => dest.UserName, src => src.Email);
        }
    }
}
