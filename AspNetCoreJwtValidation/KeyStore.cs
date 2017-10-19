using System;
using Microsoft.IdentityModel.Tokens;

namespace AspNetCoreJwtValidation
{
    public static class KeyStore
    {
        private static byte[] key = Guid.NewGuid().ToByteArray();

        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(key);
        }
    }
}