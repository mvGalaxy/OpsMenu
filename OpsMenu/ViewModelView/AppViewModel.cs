using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Command;

namespace OpsMenu
{
    public class AppViewModel : ViewModelBase
    {
        #region App
        /// <summary>
        /// The <see cref="App" /> property's name.
        /// </summary>
        public const string AppPropertyName = "App";

        private string _app;

        /// <summary>
        /// Sets and gets the App property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public string App
        {
            get
            {
                return _app;
            }
            set
            {
                Set(() => App, ref _app, value);
            }
        }
        #endregion

        #region Path
        /// <summary>
        /// The <see cref="Path" /> property's name.
        /// </summary>
        public const string PathPropertyName = "Path";

        private string _path;

        /// <summary>
        /// Sets and gets the Path property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public string Path
        {
            get
            {
                return _path;
            }
            set
            {
                Set(() => Path, ref _path, value);
            }
        }
        #endregion

        private RelayCommand _executePathCommand;

        public RelayCommand ExecutePathCommand
        {
            get { return _executePathCommand; }
            set { _executePathCommand = value; }
        }

        public AppViewModel()
        {
            ExecutePathCommand=new RelayCommand(()=>Process.Start(Path),()=>true);
        }
    }
}
