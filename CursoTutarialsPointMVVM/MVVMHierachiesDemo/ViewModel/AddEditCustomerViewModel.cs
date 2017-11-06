using MVVMHierachiesDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MVVMHierachiesDemo.ViewModel
{
    public class AddEditCustomerViewModel : PropertyChangedNotification
    {

        public AddEditCustomerViewModel()
        {
            Customer = new SimpleEditableCustomer();
            CancelCommand = new MyIcommand(OnCancel);
            SaveCommand = new MyIcommand(OnSave, CanSave);
        }

        private static AddEditCustomerViewModel addEditCustomerViewModel;

        public bool EditMode
        {
            get { return GetValue(()=> EditMode); }
            set { SetValue(()=>EditMode, value); }
        }

        public SimpleEditableCustomer Customer
        {
            get { return GetValue(()=>Customer); }
            set { SetValue(()=>Customer, value); }
        }

        private void RaiseCanExecuteChanged(object sender, EventArgs e)
        {
            SaveCommand.RaiseCanExecuteChanged();
        }

        public static AddEditCustomerViewModel SharedViewModel()
        {
            return addEditCustomerViewModel ?? (addEditCustomerViewModel = new AddEditCustomerViewModel());
        }

        public MyIcommand CancelCommand { get; private set; }
        public MyIcommand SaveCommand { get; private set; }

        public event Action Done = delegate { };

        private void OnCancel()
        {
            Done();
        }

        private async void OnSave()
        {
            Done();
        }
        public static int Errors { get; set; }
        public bool CanSave()
        {
            if (Errors == 0)
                return true;
            else
                return false;
        }

        //private void Validation_Error(object sender, ValidationErrorEventArgs e)
        //{
        //    if (e.Action == ValidationErrorEventAction.Added) AddEditCustomerViewModel.Errors += 1;
        //    if (e.Action == ValidationErrorEventAction.Removed) AddEditCustomerViewModel.Errors -= 1;
        //}
    }
}
