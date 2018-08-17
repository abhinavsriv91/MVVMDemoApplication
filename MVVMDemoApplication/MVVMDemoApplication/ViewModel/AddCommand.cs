using MVVMDemoApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMDemoApplication.ViewModel
{
    public class AddCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var type = parameter.GetType();
            switch (type.Name)
            {
                case "Button":
                    //UserViewModel vm = new UserViewModel();
                    //vm.Users.Add(new User {UserId= });
                    break;
            }
        }
    }
}
