using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;
using iHunter.Services;
using Xamarin.Forms;

namespace iHunter.Views
{
    public class HomeView : ContentPage
    {
        public HomeView()
        {
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    new Label
                    {
                        XAlign = TextAlignment.Center,
                        Text = "Welcome to Xamarin Forms!"
                    }
                }

                //this.Title = StateService.GetInstance().AppName;

                //Children.Add(new XAnimalsView());
                //Children.Add(new XCountriesView());
                //Children.Add(new XSeasonsView());
            };
        }
    }
}