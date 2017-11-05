using MVVMHierachiesDemo.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMHierachiesDemo
{

    public class MainWindowViewModel : PropertyChangedNotification
    {

        public MainWindowViewModel()
        {
            NavCommand = new MyICommand<string>(OnNav);
        }

        private CustomerListViewModel custListViewModel = new CustomerListViewModel();

        private OrderViewModel orderViewModelModel = new OrderViewModel();

        private AddEditCustomerViewModel addEditCustomerViewModel = new AddEditCustomerViewModel();

         public PropertyChangedNotification CurrentViewModel
        {
            get { return GetValue(()=>CurrentViewModel); }
            set { SetValue(()=>CurrentViewModel, value); }
        }

        public MyICommand<string> NavCommand { get; private set; }

        private void OnNav(string destination)
        {

            switch (destination)
            {
                case "orders":
                    CurrentViewModel = orderViewModelModel;
                    break;
                case "addCustomer":
                    CurrentViewModel = addEditCustomerViewModel;
                    break;
                default:
                    CurrentViewModel = custListViewModel;
                    break;
            }
        }
    }
}