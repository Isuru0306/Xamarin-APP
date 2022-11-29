using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SFAPortal.ViewModel
{
    class CustomerListViewModel : BaseViewModel
    {
        #region Inits
        public ObservableCollection<Customers> _customers;
        public ObservableCollection<Customers> Customers
        {
            get { return _customers; }
            set
            {
                _customers = value;
                OnPropertyChanged(nameof(_customers));
            }
        }
    #endregion


        #region Ctor
        public CustomerListViewModel()
        {
            Customers = new ObservableCollection<Customers>()
            {
                new Customers(){Name="Isuru", Town ="Gampola", ContactNo="0785884231", Email="isuru.bandara0306@gmail.com" },
                new Customers(){Name="Isuru", Town ="Gampola", ContactNo="0785884231", Email="Isuru@gmail.com" },
                new Customers(){Name="Isuru", Town ="Gampola", ContactNo="0785884231", Email="Isuru@gmail.com" },
                new Customers(){Name="Isuru", Town ="Gampola", ContactNo="0785884231", Email="Isuru@gmail.com" },
                new Customers(){Name="Isuru", Town ="Gampola", ContactNo="0785884231", Email="Isuru@gmail.com" },
                new Customers(){Name="Isuru", Town ="Gampola", ContactNo="0785884231", Email="Isuru@gmail.com" },
                new Customers(){Name="Isuru", Town ="Gampola", ContactNo="0785884231", Email="Isuru@gmail.com" },
                new Customers(){Name="Isuru", Town ="Gampola", ContactNo="0785884231", Email="Isuru@gmail.com" },
                new Customers(){Name="Isuru", Town ="Gampola", ContactNo="0785884231", Email="Isuru@gmail.com" },
                new Customers(){Name="Isuru", Town ="Gampola", ContactNo="0785884231", Email="Isuru@gmail.com" },
                new Customers(){Name="Isuru", Town ="Gampola", ContactNo="0785884231", Email="Isuru@gmail.com" },
                new Customers(){Name="Isuru", Town ="Gampola", ContactNo="0785884231", Email="Isuru@gmail.com" },
                new Customers(){Name="Isuru", Town ="Gampola", ContactNo="0785884231", Email="Isuru@gmail.com" },
                new Customers(){Name="Isuru", Town ="Gampola", ContactNo="0785884231", Email="Isuru@gmail.com" },
                new Customers(){Name="Isuru", Town ="Gampola", ContactNo="0785884231", Email="Isuru@gmail.com" },
                new Customers(){Name="Isuru", Town ="Gampola", ContactNo="0785884231", Email="Isuru@gmail.com" },
            };  
        }
        #endregion

    }
}

