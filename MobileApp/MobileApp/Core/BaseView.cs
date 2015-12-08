using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iHunter.Services;
using Xamarin.Forms;

namespace iHunter.Views
{
    public class BaseView : ContentPage
    {
        public BaseView()
        {
            //if (!HasCustomTitle())
            //{
            //    this.Title = StateService.GetInstance().AppName;
            //}
            NavigationPage.SetBackButtonTitle(this, StateService.GetInstance().AppBackString);
        }

        protected virtual bool HasCustomTitle()
        {
            return false;
        }

        #region Overrides
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        protected override bool OnBackButtonPressed()
        {
            //Navigation.PopModalAsync();

            return base.OnBackButtonPressed();
        }

        #endregion
    }
}
