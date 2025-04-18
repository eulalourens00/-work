using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.view
{
    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public User(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
    public class View : IView, INotifyPropertyChanged
    {
        private ObservableCollection<User> _users;
        public ObservableCollection<User> Users
        {
            get => _users;
            set
            {
                _users = value;
                OnPropertyChanged();
            }
        }
        public View()
        { Users = new ObservableCollection<User>(); }

        public void AddUser(User user)
        { Users.Add(user); }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {  PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName)); }
    }
}
