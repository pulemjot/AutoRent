using System;
using System.ComponentModel.DataAnnotations;

namespace AutoRent.Models {
    class LoginModel : ViewModelBase {
        String userName, pwd;

        [Required]
        public String UserName
        {
            get => userName;
            set
            {
                userName = value;
                OnPropertyChanged(nameof(UserName));
            }
        }
        [Required]
        public String Password {
            get => pwd;
            set {
                pwd = value;
                OnPropertyChanged(nameof(Password));
            }
        }
    }
}
