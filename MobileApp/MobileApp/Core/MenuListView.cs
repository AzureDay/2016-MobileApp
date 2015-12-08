using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iHunter.Views;
using Xamarin.Forms;

namespace iHunter.Core
{
    public class MenuListView : ListView
    {
        public MenuListView()
        {
            //LanguageChanged.Subscribe(this, () => LocalisableData());

            //MessagingCenter.Subscribe<LanguageChanged, string>(this, "Hi", (sender, arg) =>
            //{
            //    LocalisableData();
            //});

            LocalisableData();
            VerticalOptions = LayoutOptions.FillAndExpand;
            BackgroundColor = Color.Transparent;

            SeparatorVisibility = SeparatorVisibility.None;

            var cell = new DataTemplate(typeof(MenuCell));
            cell.SetBinding(MenuCell.TextProperty, "Title");
            cell.SetBinding(MenuCell.ImageSourceProperty, "IconSource");

            ItemTemplate = cell;
        }

        private void LocalisableData()
        {
            List<MenuItem> data = new MenuListData();

            ItemsSource = data;
        }

    }
}
