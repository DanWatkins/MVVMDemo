using MvvmDemo.Core;
using System.Collections.ObjectModel;

namespace MvvmDemo.ViewModel
{
    public class StudentsViewModel
    {
        private Student _selectedStudent;
        public Student SelectedStudent
        {
            get { return _selectedStudent; }
            set
            {
                _selectedStudent = value;
                DeleteCommand.RaiseCanExecuteChanged();
            }
        }

        public ObservableCollection<Student> Students { get; set; }

        public MyCommand DeleteCommand { get; set; }

        public StudentsViewModel()
        {
            Students = new ObservableCollection<Student>
            {
                new Student { FirstName = "Mark", LastName = "Allain" },
                new Student { FirstName = "Allen", LastName = "Brown" },
                new Student { FirstName = "Linda", LastName = "Hamerski" }
            };

            DeleteCommand = new MyCommand(OnDelete, CanDelete);
        }

        private void OnDelete()
        {
            Students.Remove(SelectedStudent);
        }

        private bool CanDelete()
        {
            return SelectedStudent != null;
        }
    }
}