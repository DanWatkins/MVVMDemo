using MvvmDemo.ViewModel;
using System.Windows;

namespace MvvmDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StudentViewControl_Loaded(object sender, RoutedEventArgs e)
        {
            var studentViewModel = new StudentsViewModel();
            studentViewModel.LoadStudents();

            StudentViewControl.DataContext = studentViewModel;
        }
    }
}
