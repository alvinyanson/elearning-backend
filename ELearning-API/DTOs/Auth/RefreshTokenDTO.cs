namespace ELearning_API.DTOs.Auth
{
    public class RefreshTokenDTO
    {
        public string UserName { get; set; }
        public string TokenString { get; set; }
        public DateTime ExpireAt { get; set; }
    }
}
