using System.Windows.Controls;

namespace CursoTutarialsPointMVVM.View
{
    /// <summary>
    /// Interação lógica para StudentView.xam
    /// </summary>
    public partial class StudentView : UserControl
    {
        public StudentView()
        {
            InitializeComponent();
            //Data context autohooked
            //this.DataContext = new ViewModel.StudentViewModel();
        }
    }
}
