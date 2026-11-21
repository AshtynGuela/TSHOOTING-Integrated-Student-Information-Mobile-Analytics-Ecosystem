
using System;
using Microsoft.Maui.Controls;

namespace StudentInformationSystemMobile.Views
{
    public partial class MyProfilePage : ContentPage
    {
        public MyProfilePage()
        {
            InitializeComponent();

            SetFieldsEnabled(false);
            SaveButton.IsEnabled = false;
        }

        private async void OnBackClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("..");
        }

        private void OnEditClicked(object sender, EventArgs e)
        {
            SetFieldsEnabled(true);

            EditButton.IsEnabled = false;
            SaveButton.IsEnabled = true;
        }

        private async void OnSaveClicked(object sender, EventArgs e)
        {
            SetFieldsEnabled(false);

            EditButton.IsEnabled = true;
            SaveButton.IsEnabled = false;

            await DisplayAlertAsync(
                "Profile Updated",
                "Your profile changes have been saved temporarily. Database saving will be connected later.",
                "OK"
            );
        }

        private void SetFieldsEnabled(bool enabled)
        {
            FirstNameEntry.IsEnabled = enabled;
            MiddleNameEntry.IsEnabled = enabled;
            LastNameEntry.IsEnabled = enabled;
            ContactEntry.IsEnabled = enabled;
            EmailEntry.IsEnabled = enabled;
            DobEntry.IsEnabled = enabled;
            GenderEntry.IsEnabled = enabled;
        }
    }
}
