using CursoTutarialsPointMVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoTutarialsPointMVVM.ViewModel
{
    class StudentViewModel
    {
        public ObservableCollection<Student> Students { get; set; }
        public MyCommand DeleteCommand { get; set; }

        private Student selectedStudent;

        public Student SelectedStudent
        {
            get { return selectedStudent; }
            set
            {
                selectedStudent = value;
                DeleteCommand.RaiseCanExecuteChanged();
            }
        }

        public StudentViewModel()
        {
            LoadStudents();
            DeleteCommand = new MyCommand(OnDelete, CanDelete);          
        }

        private bool CanDelete()
        {
            return SelectedStudent != null;
        }

        private void OnDelete()
        {
            Students.Remove(SelectedStudent);
        }

        public void LoadStudents()
        {
            ObservableCollection<Student> students = new ObservableCollection<Student>
            {
                new Student { FirstName = "Mark", LastName = "Allain" },
                new Student { FirstName = "Allen", LastName = "Brown" },
                new Student { FirstName = "Linda", LastName = "Hamerski" }
            };

            Students = students;
        }
    }
}
