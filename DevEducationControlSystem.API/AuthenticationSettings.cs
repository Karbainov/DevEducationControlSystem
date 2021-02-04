using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.API
{
    public class AuthenticationSettings
    {
        public const string Issuer = "DevEd";
        public const string Audience = "Client";
        public const int Lifetime = 60;

        private const string Key = "qqqkeyqqq";

        public static SymmetricSecurityKey SecurityKey
        {
            get
            {
                return new SymmetricSecurityKey(Encoding.UTF32.GetBytes(Key));
            }
        }
    }
}
