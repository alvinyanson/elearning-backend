using ELearning_API.DTOs;
using Mapster;
using Microsoft.AspNetCore.Identity;

namespace ELearning_API.Profiles
{
    public class MapsterProfile : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<RegisterDTO, IdentityUser>()
                .Map(dest => dest.UserName, src => src.Email);
        }
    }
}
