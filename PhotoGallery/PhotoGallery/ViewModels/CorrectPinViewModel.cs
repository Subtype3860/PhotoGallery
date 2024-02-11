using System.Windows.Input;
using Xamarin.Forms;

namespace PhotoGallery.ViewModels
{
    public class CorrectPinViewModel : ContentPage
    {
        public CorrectPinViewModel()
        {
            NavigateBackCommand = new Command(NavigateBack);
        }
        public ICommand NavigateBackCommand { get; }
        private void NavigateBack()
        {
            Application.Current.MainPage.Navigation.PopModalAsync();
        }
    }
}
