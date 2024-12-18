namespace ELearning_API
{
    public class GlobalConstants
    {
        public static class RegexPatterns
        {
            public const string EmailPattern = @"^[a-zA-Z0-9.!#$%&’*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)+$";
        }

        public static class SuccessResponseMessage
        {
            public const string RegisterInstructor = "You've successfully registered as an instructor. Please check your email to activate your account.";

            public const string RegisterStudent = "You've successfully registered as a student. Please check your email to activate your account.";

            public const string RegisterAdmin = "You've successfully registered as an admin. Please check your email to activate your account.";

        }
    }
}
