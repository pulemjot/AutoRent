using System.ComponentModel.DataAnnotations;

namespace AutoRent.Models {
    class LoginModel : ViewModelBase {
        string userName, pwd;

        [Required]
        public string UserName
        {
            get => userName;
            set
            {
                userName = value;
                OnPropertyChanged(nameof(UserName));
            }
        }
        [Required]
        public string Password {
            get => pwd;
            set {
                pwd = value;
                OnPropertyChanged(nameof(Password));
            }
        }
    }
}
