using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iHunter.Core;

namespace iHunter.Views
{
    public class MenuListData : List<MenuItem>
    {
        public MenuListData()
        {
            this.Add(new MenuItem()
            {
                Title = "Home",
                IconSource = "home.png",
                TargetType = typeof(HomeView)
            });

            this.Add(new MenuItem()
            {
                Title = "Settings",
                IconSource = "settings.png",
                TargetType = typeof(HomeView)
            });

            this.Add(new MenuItem()
            {
                Title = "About",
                IconSource = "info.png",
                TargetType = typeof(HomeView)
            });
        }
    }
}
