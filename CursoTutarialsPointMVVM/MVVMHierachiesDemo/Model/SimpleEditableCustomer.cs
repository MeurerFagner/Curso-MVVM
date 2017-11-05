using System;
using System.ComponentModel.DataAnnotations;

namespace MVVMHierachiesDemo.Model
{
    public class SimpleEditableCustomer : PropertyChangedNotification
    {
        public Guid Id
        {
            get { return GetValue(() => Id); }
            set { SetValue(() => Id, value); }
        }

        [Required(ErrorMessage = "Teste")]
        public string FirstName
        {
            get { return GetValue(() => FirstName); }
            set { SetValue(()=> FirstName, value); }
        }

        [Required]
        public string LastName
        {
            get { return GetValue(() => LastName); }
            set { SetValue(()=> LastName, value); }
        }

        [Required]
        [EmailAddress]
        public string Email
        {
            get { return GetValue(()=> Email); }
            set { SetValue(()=> Email, value); }
        }

        [Required]
        [Phone]
        public string Phone
        {
            get { return GetValue(()=>Phone); }
            set { SetValue(()=> Phone, value); }
        }
    }
}
