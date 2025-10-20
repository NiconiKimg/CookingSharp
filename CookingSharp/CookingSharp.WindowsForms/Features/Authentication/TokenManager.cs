namespace CookingSharp.WindowsForms
{
    public static class TokenManager
    {
        public static string? CurrentToken { get; private set; }

        public static void SetToken(string token)
        {
            CurrentToken = token;
        }

        public static void ClearToken()
        {
            CurrentToken = null;
        }
    }
}