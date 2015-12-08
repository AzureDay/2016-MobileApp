using iHunter.Services;
using Xamarin.Forms;

namespace iHunter.Views
{
    public class BaseTabbedPage : TabbedPage
    {
        public BaseTabbedPage()
        {
            if (!HasCustomTitle())
            {
                this.Title = StateService.GetInstance().AppName;
            }

            NavigationPage.SetBackButtonTitle(this, StateService.GetInstance().AppBackString);
        }

        protected virtual bool HasCustomTitle()
        {
            return false;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        protected override bool OnBackButtonPressed()
        {
            //Navigation.PopModalAsync();

            return base.OnBackButtonPressed();
        }
    }
}