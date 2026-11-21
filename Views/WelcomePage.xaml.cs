
namespace StudentInformationSystemMobile.Views
{
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private async void OnSwipedToLogin(object sender, SwipedEventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(StudentLogin));
        }
    }
}
