using System;

namespace AspNetCoreJwtValidation
{
    public static class Config
    {

        private const string MyUrl = "http://localhost:33143/";

        public static string Issuer => MyUrl;

        public static String Audience => MyUrl;

        public static String Id = "AspNetCoreJwtValidation";

        public static String Name = "AspNetCoreJwtValidation";
    }
}