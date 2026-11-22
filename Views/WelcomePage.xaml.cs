
namespace StudentInformationSystemMobile.Views
{
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private async void OnLoginRequested(object? sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(StudentLogin));
        }
    }
}
