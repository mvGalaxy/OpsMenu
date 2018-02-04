using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace OpsMenu
{
  public class AppsViewModel: ViewModelBase
    {
        #region Apps
        /// <summary>
        /// The <see cref="Apps" /> property's name.
        /// </summary>
        public const string AppsPropertyName = "Apps";

        private ObservableCollection<AppViewModel> _apps;

        /// <summary>
        /// Sets and gets the Apps property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public ObservableCollection<AppViewModel> Apps
        {
            get
            {
                return _apps;
            }
            set
            {
                Set(() => Apps, ref _apps, value);
            }
        }
        #endregion

        #region SelectedApp
        /// <summary>
        /// The <see cref="SelectedApp" /> property's name.
        /// </summary>
        public const string SelectedAppPropertyName = "SelectedApp";

        private AppViewModel _selectedApp;

        /// <summary>
        /// Sets and gets the SelectedApp property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public AppViewModel SelectedApp
        {
            get
            {
                return _selectedApp;
            }
            set
            {
                Set(() => SelectedApp, ref _selectedApp, value);
            }
        }
        #endregion



        public AppsViewModel()
        {
            Apps=new ObservableCollection<AppViewModel>();
        }
    }
}
