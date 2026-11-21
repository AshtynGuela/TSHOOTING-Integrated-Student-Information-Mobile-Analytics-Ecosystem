
namespace StudentInformationSystemMobile.Views
{
    public partial class StudentLogin : ContentPage
    {
        public StudentLogin()
        {
            InitializeComponent();
        }

        private async void OnSupportTapped(object sender, TappedEventArgs e)
        {
            await DisplayAlertAsync(
                "Support",
                "Please contact the system administrator for assistance.",
                "OK"
            );
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            string username = UsernameEntry.Text?.Trim() ?? string.Empty;
            string password = PasswordEntry.Text ?? string.Empty;

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                await DisplayAlertAsync(
                    "Login Required",
                    "Please enter your username and password.",
                    "OK"
                );

                return;
            }

            // Temporary navigation until database authentication is connected.
            await Shell.Current.GoToAsync(nameof(StudentDashboard));
        }
    }
}
