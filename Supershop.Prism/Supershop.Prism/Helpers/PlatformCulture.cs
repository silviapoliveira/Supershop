using System;

namespace Supershop.Prism.Helpers
{
    public class PlatformCulture
    {
        public string PlatformString { get; private set; }

        public string LanguageCode { get; private set; }

        public string LocaleCode { get; private set; }


        public PlatformCulture(string platformString)
        {
            if (string.IsNullOrEmpty(platformString))
            {
                throw new ArgumentException("Expected culture identifier", "platformCultureString"); // In C# 6 use nameof(platformCultureString)
            }

            PlatformString = platformString.Replace("_", "-"); // .NET expects dash, not underscore
            int dashIndex = PlatformString.IndexOf("-", StringComparison.Ordinal);
            if(dashIndex > 0)
            {
                string[] parts = PlatformString.Split('-');
                LanguageCode = parts[0];
                LocaleCode = parts[1];
            } else
            {
                LanguageCode = PlatformString;
                LocaleCode = "";
            }
        }

        public override string ToString()
        {
            return PlatformString;
        }
    }
}
