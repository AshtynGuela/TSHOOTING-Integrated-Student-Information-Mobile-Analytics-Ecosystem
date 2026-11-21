
using System.Collections.ObjectModel;
using System.Linq;
using StudentInformationSystemMobile.Models;

namespace StudentInformationSystemMobile.Views
{
    public partial class StudentDirectoryPage : ContentPage
    {
        private ObservableCollection<Student> students;
        private ObservableCollection<Student> filteredStudents;

        public StudentDirectoryPage()
        {
            InitializeComponent();

            students = new ObservableCollection<Student>
            {
                new Student
                {
                    StudentId = "2026-001",
                    FirstName = "Juan",
                    LastName = "Dela Cruz",
                    Program = "BS Computer Science",
                    YearLevel = "1st Year",
                    EnrollmentStatus = "Enrolled"
                },
                new Student
                {
                    StudentId = "2026-002",
                    FirstName = "Maria",
                    LastName = "Santos",
                    Program = "BS Information Technology",
                    YearLevel = "1st Year",
                    EnrollmentStatus = "Enrolled"
                },
                new Student
                {
                    StudentId = "2026-003",
                    FirstName = "Alex",
                    LastName = "Reyes",
                    Program = "BS Computer Science",
                    YearLevel = "2nd Year",
                    EnrollmentStatus = "Enrolled"
                },
                new Student
                {
                    StudentId = "2026-004",
                    FirstName = "Sofia",
                    LastName = "Garcia",
                    Program = "BS Information Technology",
                    YearLevel = "2nd Year",
                    EnrollmentStatus = "Enrolled"
                }
            };

            filteredStudents = new ObservableCollection<Student>(students);
            StudentsCollectionView.ItemsSource = filteredStudents;
        }

        private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = e.NewTextValue?.Trim() ?? string.Empty;

            var results = students.Where(student =>
                student.FullName.Contains(
                    searchText,
                    StringComparison.OrdinalIgnoreCase
                ) ||
                student.StudentId.Contains(
                    searchText,
                    StringComparison.OrdinalIgnoreCase
                )
            ).ToList();

            filteredStudents.Clear();

            foreach (Student student in results)
            {
                filteredStudents.Add(student);
            }
        }

        private void OnStudentSelected(object sender, SelectionChangedEventArgs e)
        {
            StudentsCollectionView.SelectedItem = null;
        }
    }
}
