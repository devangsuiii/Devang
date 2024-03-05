using Microsoft.Maui.Controls;
using System;
using System.Threading.Tasks;

namespace LearnEase 
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            NavigateToSignInPage();

        }
        private async Task NavigateToSignInPage()
        {
            // Navigate to the sign-in page
            await Navigation.PushAsync(new SignInPage());
        }
        private async void OnStartLearningClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LearningPage());
        }

    }
}
