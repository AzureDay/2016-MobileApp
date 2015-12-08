using iHunter.Services;
using iHunter.Views;
using Xamarin.Forms;

namespace iHunter.Core
{
    public class BaseNavigationPage : NavigationPage
    {
        public BaseNavigationPage()
        {
            this.Title = StateService.GetInstance().AppName;
        }

        public BaseNavigationPage(Xamarin.Forms.Page root):base(root)
        {
            this.Title = StateService.GetInstance().AppName;
        }
    }
}
