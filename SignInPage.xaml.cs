using Microsoft.Maui.Controls;
using System;

namespace LearnEase
{
    public partial class SignInPage : ContentPage
    {
        public SignInPage()
        {
            InitializeComponent();
        }
        private async void OnSignInClicked(object sender, EventArgs e)
        {
            // Perform sign-in logic here
            // For example, validate email and password
            string enteredEmail = EmailEntry.Text;
            string enteredPassword = PasswordEntry.Text;

            // Define the allowed email and password
            string allowedEmail = "A00272941";
            string allowedPassword = "1234";

            bool isSignInSuccessful = true; // Replace this with your actual sign-in logic

            if (enteredEmail == allowedEmail && enteredPassword == allowedPassword)
            {
                // Navigate to the main page after successful sign-in
                await Navigation.PushAsync(new MainPage());
            }
            else
            {
                // Show an error message if sign-in fails
                await DisplayAlert("Sign-In Failed", "Invalid email or password", "OK");
            }
        }
    }
}
