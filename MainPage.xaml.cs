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
            
            await Navigation.PushAsync(new SignInPage());
        }

        private async void OnStartLearningClicked(object sender, EventArgs e)
        {
            await NavigateToLearningPage();
        }


        private async Task NavigateToLearningPage()
        {
            // Create a new ContentPage instance for learning content
            ContentPage learningPage = new ContentPage
            {
                Content = new StackLayout
                {
                    
                new StackLayout
                {
                    Orientation = StackOrientation.Vertical,
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    Spacing = 60,
                    Padding = new Thickness(20,0,0,0),

                    
                   
                    
                    Children =
                    {
                        new Label
                        {
                            Text = "Dashboard",
                            FontAttributes = FontAttributes.Bold,
                            HorizontalOptions = LayoutOptions.StartAndExpand,
                            VerticalOptions = LayoutOptions.StartAndExpand

                        },
                        new Label
                        {
                            Text = "My Learning",
                            FontAttributes = FontAttributes.Bold,
                            HorizontalOptions = LayoutOptions.StartAndExpand,
                            VerticalOptions = LayoutOptions.StartAndExpand
                        },
                        new Label
                        {
                            Text = "Premium",
                            FontAttributes = FontAttributes.Bold,
                            HorizontalOptions = LayoutOptions.StartAndExpand,
                            VerticalOptions = LayoutOptions.StartAndExpand
                        },
                        new Label
                        {
                            Text = "All Courses",
                            FontAttributes = FontAttributes.Bold,
                            HorizontalOptions = LayoutOptions.StartAndExpand,
                            VerticalOptions = LayoutOptions.StartAndExpand
                        },
                        new Label
                        {
                            Text = "Wishlist",

                            HorizontalOptions = LayoutOptions.StartAndExpand,
                            VerticalOptions = LayoutOptions.StartAndExpand
                        }
                    }
                }
            
                }
            };

            // Navigate to the new page asynchronously
            await Navigation.PushAsync(learningPage);
        }

    }
}
