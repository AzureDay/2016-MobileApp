using System;
using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace iHunter.Services
{
    public class SettingsService
    {
        public SettingsService()
        {

        }

        static ISettings GetSettings()
        {
            return CrossSettings.Current;
        }

        public static string Language
        {
            get
            {
                return GetSettings().GetValueOrDefault("Language", String.Empty);
            }
            set
            {
                GetSettings().AddOrUpdateValue("Language", value);
            }
        }
    }
}

