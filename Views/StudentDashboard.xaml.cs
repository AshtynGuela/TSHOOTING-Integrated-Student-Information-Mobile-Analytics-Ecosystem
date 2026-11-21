
namespace StudentInformationSystemMobile.Views
{
    public partial class StudentDashboard : ContentPage
    {
        public StudentDashboard()
        {
            InitializeComponent();
        }

        private async void OnStudentDirectoryClicked(object sender, TappedEventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(StudentDirectoryPage));
        }

        private async void OnMyProfileClicked(object sender, TappedEventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(MyProfilePage));
        }

        private async void OnLogoutClicked(object sender, EventArgs e)
        {
            bool confirm = await DisplayAlertAsync(
                "Logout",
                "Are you sure you want to log out?",
                "Yes",
                "Cancel"
            );

            if (confirm)
            {
                await Shell.Current.GoToAsync("//WelcomePage");
            }
        }
    }
}
