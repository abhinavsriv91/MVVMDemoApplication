using MVVMDemoApplication.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMDemoApplication.ViewModel
{
    public class UserViewModel : INotifyPropertyChanged
    {
        #region Variables

        private ObservableCollection<User> users;
        private User selectedItem;
        private static User user = new User();

        private ICommand updateCommand;
        private ICommand addCommand;
        private ICommand deleteCommand;

        #endregion

        #region Properties

        public ICommand UpdateCommand
        {
            get
            {
                if (updateCommand == null)
                    updateCommand = new UpdateCommand();
                return updateCommand;
            }
            set
            {
                updateCommand = value;
            }
        }

        public ICommand AddCommand
        {
            get
            {
                if (addCommand == null)
                    addCommand = new RelayCommand(param => AddUser((User)param));
                return addCommand;
            }

            set
            {
                addCommand = value;
            }
        }

        public ICommand DeleteCommand
        {
            get
            {
                if (deleteCommand == null)
                {
                    deleteCommand = new RelayCommand(param => DeleteUser((User)param));
                }
                return deleteCommand;
            }
        }

        public User SelectedItem
        {
            get
            {
                return selectedItem;
            }

            set
            {
                selectedItem = value;
                OnPropertyChanged("SelectedItem");
            }
        }

        public ObservableCollection<User> Users
        {
            get
            {
                return users;
            }

            set
            {
                users = value;
            }
        }

        public static User User
        {
            get
            {
                return user;
            }

            set
            {
                user = value;
            }
        }

        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }


        #region Construcor

        /// <summary>
        /// 
        /// </summary>
        public UserViewModel()
        {
            Users = new ObservableCollection<User>()
            {
                new User{UserId=1,FirstName="Raj",LastName="Sharma",City="Delhi",State="DEL",Country="INDIA"},
                new User{UserId=2,FirstName="Adityanath",LastName="Yogi",City="GKP", State="UP", Country="INDIA"},
                new User{UserId=3,FirstName="Vikash",LastName="Nanda",City="Noida", State="UP", Country="INDIA"},
                new User{UserId=4,FirstName="Harsh",LastName="Kumar",City="Ghaziabad", State="UP", Country="INDIA"},
                new User{UserId=5,FirstName="Deven",LastName="Verma",City="Palwal", State="HP", Country="INDIA"},
                new User{UserId=6,FirstName="Sachin",LastName="Garg",City="CHD", State="DEL", Country="INDIA"},
                new User {UserId=7,FirstName="Roma",LastName="Symaleen",City="BBSR", State="Odisha", Country="INDIA" }
            };
        }

        #endregion

        /// <summary>
        /// Add a new User to the List View
        /// </summary>
        /// <param name="user"></param>
        private void AddUser(User user)
        {
            users.Add(user);
        }

        /// <summary>
        /// Remove the selected user from theList View
        /// </summary>
        /// <param name="user"></param>
        private void DeleteUser(User user)
        {
            if (users.Contains(user))
            {
                users.Remove(user);
            }
        }
    }
}
