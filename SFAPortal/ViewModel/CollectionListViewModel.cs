using SFAPortal.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SFAPortal.ViewModel
{
    class CollectionListViewModel : BaseViewModel
    {
        #region Inits
        public ObservableCollection<CollectionLists> _collectionList;
        public ObservableCollection<CollectionLists> CollectionLists
        {
            get { return _collectionList; }
            set
            {
                _collectionList = value;
                OnPropertyChanged(nameof(_collectionList));
            }
        }
        #endregion


        #region Ctor
        public CollectionListViewModel()
        {
            CollectionLists = new ObservableCollection<CollectionLists>()
            {
                new CollectionLists(){customer ="1", due_date ="2022-11-30", inv_no="BI1545"},
                new CollectionLists(){customer ="1", due_date ="2022-11-30", inv_no="BI1545"},
                new CollectionLists(){customer ="1", due_date ="2022-11-30", inv_no="BI1545"},
                new CollectionLists(){customer ="1", due_date ="2022-11-30", inv_no="BI1545"},
                new CollectionLists(){customer ="1", due_date ="2022-11-30", inv_no="BI1545"},
                new CollectionLists(){customer ="1", due_date ="2022-11-30", inv_no="BI1545"},
                new CollectionLists(){customer ="1", due_date ="2022-11-30", inv_no="BI1545"},
               

            };
        }
        #endregion
    }
}
