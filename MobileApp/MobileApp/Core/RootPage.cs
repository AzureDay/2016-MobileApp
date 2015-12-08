using System;
using iHunter.Views;
using Xamarin.Forms;

namespace iHunter.Core
{
    public class RootPage : MasterDetailPage
    {
        MenuPage menuPage;

        public RootPage()
        {
            menuPage = new MenuPage();

            menuPage.Menu.ItemSelected += (sender, e) => NavigateTo(e.SelectedItem as MenuItem);

            Master = menuPage;
            Detail = new NavigationPage(new HomeView());
        }

        void NavigateTo(MenuItem menu)
        {
            if (menu == null)
                return;

            Page displayPage = (Page)Activator.CreateInstance(menu.TargetType);

            Detail = new NavigationPage(displayPage);

            menuPage.Menu.SelectedItem = null;
            IsPresented = false;
        }
    }

    //public class AccountsPage : ContentPage
    //{
    //    public AccountsPage()
    //    {
    //        Title = "Accounts";
    //        Icon = "Accounts.png";
    //    }
    //}

    //public class LeadsPage : ContentPage
    //{
    //    public LeadsPage()
    //    {
    //        Title = "Leads";
    //        Icon = "Leads.png";
    //    }
    //}

    //public class OpportunitiesPage : ContentPage
    //{
    //    public OpportunitiesPage()
    //    {
    //        Title = "Opportunities";
    //        Icon = "Opportunities.png";
    //    }
    //}
}