
using StudentInformationSystemMobile.Views;

namespace StudentInformationSystemMobile
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(StudentLogin), typeof(StudentLogin));
            Routing.RegisterRoute(nameof(StudentDashboard), typeof(StudentDashboard));
            Routing.RegisterRoute(nameof(StudentDirectoryPage), typeof(StudentDirectoryPage));
            Routing.RegisterRoute(nameof(MyProfilePage), typeof(MyProfilePage));
        }
    }
}
