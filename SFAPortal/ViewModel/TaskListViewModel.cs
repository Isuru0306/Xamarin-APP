using SFAPortal.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SFAPortal.ViewModel
{
    class TaskListViewModel : BaseViewModel
    {

        #region Inits
        public ObservableCollection<Tasks> _tasks;
        public ObservableCollection<Tasks> Tasks
        {
            get { return _tasks; }
            set
            {
                _tasks = value;
                OnPropertyChanged(nameof(_tasks));
            }
        }
        #endregion


        #region Ctor
        public TaskListViewModel()
        {
            Tasks = new ObservableCollection<Tasks>()
            {
                new Tasks(){Id ="1", DateTime ="2011-5-3", Type="type1"},
                new Tasks(){Id ="1", DateTime ="2011-5-3", Type="type1"},
                new Tasks(){Id ="1", DateTime ="2011-5-3", Type="type1"},
                new Tasks(){Id ="1", DateTime ="2011-5-3", Type="type1"},
                new Tasks(){Id ="1", DateTime ="2011-5-3", Type="type1"},
                new Tasks(){Id ="1", DateTime ="2011-5-3", Type="type1"},
                new Tasks(){Id ="1", DateTime ="2011-5-3", Type="type1"},
            };
        }
        #endregion
    }
}
