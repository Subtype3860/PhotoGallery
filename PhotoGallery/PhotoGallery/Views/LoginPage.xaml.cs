using PhotoGallery.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PhotoGallery.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            BindingContext = new LoginPageViewModel();

            //Appearing += (object sender, EventArgs e) => {
            //    HiddenEntry.Focus();
            //};

            //this.HiddenEntry.Unfocused += (object sender, FocusEventArgs e) => {
            //    HiddenEntry.Focus();
            //    base.OnAppearing();
            //};
        }
    }
}