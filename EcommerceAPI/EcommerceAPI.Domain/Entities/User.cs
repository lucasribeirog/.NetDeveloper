using EcommerceAPI.Domain.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Domain.Entities
{
    public class User : Base
    {
        #region Member Variables

        private string _name;
        private string _login;
        private string _password;
        private string _email;
        private EnumsEcommerce.UserStatus _status;
        private string _address;

        #endregion Member Variables

        #region Public Properties

        public virtual string Name { get => _name; set => _name = value; }
        public virtual string Login { get => _login; set => _login = value; }
        public virtual string Password { get => _password; set => _password = value; }
        public virtual string Email { get => _email; set => _email = value; }

        public virtual EnumsEcommerce.UserStatus Status { get => _status; set => _status = value; }
        public virtual string Address { get => _address; set => _address = value; }

        #endregion Public Properties

        public User()
        {
        }

        public User(string name, string login, string password, string email)
        {
            this._name = name;
            this._login = login;
            this._password = password;
            this._email = email;
        }
    }
}