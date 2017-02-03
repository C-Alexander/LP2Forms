using LP2Forms.DomeinModellen;

namespace LP2Forms
{
    public static class Session
    {
        private static bool _isLoggedIn;
        public static Gebruiker Gebruiker;

        public static bool IsLoggedIn()
        {
            return _isLoggedIn;
        }

        internal static void IsLoggedIn(bool isLoggedIn, Gebruiker gebruiker)
        {
            _isLoggedIn = isLoggedIn;
            Gebruiker = gebruiker;
        }
    }
}
