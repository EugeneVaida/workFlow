using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowBusinessLogic
{
    public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
    {
        public User(string login, string password, int companyId)
        {
            this.Login = login;
            this.Password = password;
            this.CompanyId = companyId;
        }
    }
}
