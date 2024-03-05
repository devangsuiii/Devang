using Microsoft.Maui.Controls;

namespace LearnEase
{
    public partial class LearningPage : ContentPage
    {
        public LearningPage()
        {
            InitializeComponent();
        }

        private async void OnMoreClicked(object sender, EventArgs e)
        {
            // Handle the click event of the toolbar item
            // For example, display a catalog or perform any other action
            await DisplayAlert("More Options", "This is the overflow menu", "OK");
        }
    }
}
