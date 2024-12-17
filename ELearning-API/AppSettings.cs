namespace ELearning_API
{
    public class AppSettings
    {
        public string AllowedOrigins { get; set; }
        public string AppName { get; set; }
        public JwtTokenConfig AuthSettings { get; set; }

        public class JwtTokenConfig
        {
            public string Issuer { get; set; }
            public string Audience { get; set; }
            public int AccessTokenExpiration { get; set; }
            public int RefreshTokenExpiration { get; set; }
            public string RefreshTokenProvider { get; set; }
            public string RefreshTokenPurpose { get; set; }
            public string SecretKey { get; set; }
        }
    }
}
