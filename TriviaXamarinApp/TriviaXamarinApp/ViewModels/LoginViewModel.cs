using System;
using System.Collections.Generic;
using System.Text;
using TriviaXamarinApp.ViewModels;
namespace TriviaXamarinApp.ViewModels
{
    class LoginViewModel : ModelViewBase
    {
        private string username, password;

        public string UserName { get { return this.username; } set { if (this.username != value) { this.username = value; OnPropertyChange("UserName"); } } }
        public string Password { get { return this.password; } set { if (this.password != value) { this.password = value; OnPropertyChange("Password"); } } }


    }
}
