using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iHunter.Core;
using MobileApp;

namespace iHunter.Services
{
    public class StateService
    {
        private static StateService _s;
        public static StateService GetInstance()
        {
            if (_s == null)
            {
                _s = new StateService();
            }
            return _s;
        }


        public string AppVersion { get; set; }

        private StateService()
        {
        }

        public string AppName
        {
            get
            {
                return "Conference app";
            }
        }

        public string AppBackString
        {
            get { return "back"; }
        }

        //public static int LanguageId
        //{
        //    get
        //    {
        //        return App.AvaibleLanguages.First(x => x.Code == SettingsService.Language).Id;
        //    }
        //    //set
        //    //{
        //    //    GetSettings().AddOrUpdateValue("LanguageId", 297);
        //    //}
        //}
    }
}
