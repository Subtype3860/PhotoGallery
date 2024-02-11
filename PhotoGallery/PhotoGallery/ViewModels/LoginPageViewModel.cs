using PhotoGallery.Views;
using System;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace PhotoGallery.ViewModels
{
    public class LoginPageViewModel : BindableObject
    {
        private bool _showsError;
        private string _pin = "";
        public LoginPageViewModel() 
        {
            Pin = String.Empty;
            ShowsError = false;
        }
        public Boolean ShowsError
        {
            get => _showsError;
            set => SetProperty(ref _showsError, value);
        }
        public string Pin
        {
            get => _pin;
            set
            {
                SetProperty(ref _pin, value);
                if (IsValidPin(value))
                {
                    //PIN is correct. do whatever you want
                    Application.Current.MainPage.Navigation.PushModalAsync(new CorrectPinPage());
                }
                else
                {
                    ShowsError = (value.Length == 4);
                }
            }
        }
        private Boolean IsValidPin(string pin)
        {
            if (String.IsNullOrEmpty(pin) || pin.Length != 4)
            {
                return false;
            }
            for (var i = 0; i < 4; ++i)
            {
                if (!Char.IsNumber(pin[i]))
                {
                    return false;
                }
            }
            return true;
        }
        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(storage, value))
                return false;
            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
