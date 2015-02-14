using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Configuration;

namespace ReplaceUkr2Eng
{
    class AppSettings
    {
        public static IDictionary Translations = new Hashtable();

        //static AppSettings()
        //{
        //    var appSettings = ConfigurationManager.AppSettings;

        //    foreach (var key in appSettings.AllKeys)
        //    {
        //        Translations.Add(key, appSettings[key]);
        //    }
        //}
    }
}
