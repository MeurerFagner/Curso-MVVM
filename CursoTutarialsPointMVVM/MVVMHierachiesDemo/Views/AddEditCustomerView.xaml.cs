using MVVMHierachiesDemo.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MVVMHierachiesDemo.Views
{
    /// <summary>
    /// Interação lógica para AddEditCustomerView.xam
    /// </summary>
    public partial class AddEditCustomerView : UserControl
    {
        public AddEditCustomerView()
        {
            InitializeComponent();
            this.DataContext = AddEditCustomerViewModel.SharedViewModel();
            this.Loaded += MainWindow_Loaded;
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //var errors = grid1.GetValue(Validation.ErrorsProperty);
        }

        private void Validation_Error(object sender, ValidationErrorEventArgs e)
        {
            //if (e.Action == ValidationErrorEventAction.Added) AddEditCustomerViewModel.Errors += 1;
            //if (e.Action == ValidationErrorEventAction.Removed) AddEditCustomerViewModel.Errors -= 1;
        }
    }
}
