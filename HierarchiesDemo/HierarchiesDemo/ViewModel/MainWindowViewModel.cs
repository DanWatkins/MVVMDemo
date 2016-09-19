using System.ComponentModel;

namespace HierarchiesDemo.ViewModel
{
    class MainWindowViewModel : BindableBase
    {
        private CustomerListViewModel _customerListViewModel = new CustomerListViewModel();
        private OrderViewModel _orderViewModel = new OrderViewModel();

        private BindableBase _currentViewModel;
        public BindableBase CurrentViewModel
        {
            get { return _currentViewModel; }
            set { SetProperty(ref _currentViewModel, value); }
        }

        public MyCommand<string> NavigationCommand { get; private set; }

        public MainWindowViewModel()
        {
            NavigationCommand = new MyCommand<string>(OnNavigation);
        }

        private void OnNavigation(string destination)
        {
            switch (destination)
            {
                case "orders":
                    CurrentViewModel = _orderViewModel;
                    break;
                case "customers":
                    CurrentViewModel = _customerListViewModel;
                    break;
                default:
                    throw new InvalidEnumArgumentException();
            }
        }
    }
}