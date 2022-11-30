using SFAPortal.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SFAPortal.ViewModel
{
    class PriceListViewModel : BaseViewModel
    {

        #region Inits
        public ObservableCollection<PriceLists> _priceLists;
        public ObservableCollection<PriceLists> PriceLists
        {
            get { return _priceLists; }
            set
            {
                _priceLists = value;
                OnPropertyChanged(nameof(_priceLists));
            }
        }
        #endregion


        #region Ctor
        public PriceListViewModel()
        {
            PriceLists = new ObservableCollection<PriceLists>()
            {
                new PriceLists(){Item ="1", Details ="isuru", Price="80.00"},
                new PriceLists(){Item ="2", Details ="isuru", Price="80.00"},
                new PriceLists(){Item ="3", Details ="isuru", Price="80.00"},
                new PriceLists(){Item ="4", Details ="isuru", Price="80.00"},
                new PriceLists(){Item ="5", Details ="isuru", Price="80.00"},
                
            };
        }
        #endregion
    }
}
