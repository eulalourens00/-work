using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.view
{
    public interface IView
    {
        ObservableCollection<User> Users { get; set; }
    }
}
