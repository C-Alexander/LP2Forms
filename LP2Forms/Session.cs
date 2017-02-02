using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LP2Forms.Models;

namespace LP2Forms
{
    public static class Session
    {
        private static bool _isLoggedIn = false;
        private static Gebruiker _gebruiker;

        public static bool IsLoggedIn()
        {
            return _isLoggedIn;
        }

        internal static void IsLoggedIn(bool isLoggedIn, Gebruiker gebruiker)
        {
            _isLoggedIn = isLoggedIn;
            _gebruiker = gebruiker;
        }
    }
}
