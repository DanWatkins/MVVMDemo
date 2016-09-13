using MvvmDemo.Core;
using System.Collections.ObjectModel;

namespace MvvmDemo.ViewModel
{
    public class StudentsViewModel
    {
        public ObservableCollection<Student> Students { get; set; }

        public void LoadStudents()
        {
            Students = new ObservableCollection<Student>
            {
                new Student { FirstName = "Mark", LastName = "Allain" },
                new Student { FirstName = "Allen", LastName = "Brown" },
                new Student { FirstName = "Linda", LastName = "Hamerski" }
            };
        }
    }
}