using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMDemoApplication.Model
{

    public class User : INotifyPropertyChanged
    {
        #region Variables

        private int userId;
        private string firstName;
        private string lastName;
        private string city;
        private string state;
        private string country;

        private User selectedItem;

        #endregion

        #region Properties

        public int UserId
        {
            get
            {
                return userId;
            }
            set
            {
                userId = value;
                if (SelectedItem != null)
                {
                    SelectedItem.UserId = userId;
                }
                OnPropertyChanged("UserId");
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
                if (SelectedItem != null)
                {
                    SelectedItem.FirstName = firstName;
                }
                OnPropertyChanged("FirstName");
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
                if (SelectedItem != null)
                {
                    SelectedItem.LastName = lastName;
                }
                OnPropertyChanged("LastName");
            }
        }
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
                if (SelectedItem != null)
                {
                    SelectedItem.City = city;
                }
                OnPropertyChanged("City");
            }
        }
        public string State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
                if (SelectedItem != null)
                {
                    SelectedItem.State = state;
                }
                OnPropertyChanged("State");
            }
        }
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
                if (SelectedItem != null)
                {
                    SelectedItem.Country = country;
                }
                OnPropertyChanged("Country");
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

                UserId = selectedItem != null ? selectedItem.userId : 0;
                FirstName = selectedItem != null ? selectedItem.firstName : "";
                LastName = selectedItem != null ? selectedItem.lastName : "";
                City = selectedItem != null ? selectedItem.city : "";
                State = selectedItem != null ? selectedItem.state : "";
                Country = selectedItem != null ? selectedItem.country : "";

                OnPropertyChanged("SelectedItem");
            }
        }


        #endregion

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }
}
