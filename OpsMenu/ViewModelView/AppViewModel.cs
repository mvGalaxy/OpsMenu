using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
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

        #region AssociatedImage
        /// <summary>
        /// The <see cref="AssociatedImage" /> property's name.
        /// </summary>
        public const string AssociatedImagePropertyName = "AssociatedImage";

        private ImageSource _associatedImage;

        /// <summary>
        /// Sets and gets the AssociatedImage property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public ImageSource AssociatedImage
        {
            get
            {
                return _associatedImage;
            }
            set
            {
                Set(() => AssociatedImage, ref _associatedImage, value);
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
            ExecutePathCommand=new RelayCommand(()=>ExecutePath(Path),()=>true);
        }

        private void ExecutePath(string path)
        {
            try
            {
                Process.Start(Path);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Unable to Open {path}");
            }
            
        }

        public AppViewModel(string app, string path):this()
        {
            this.App = app;
            this.Path = path;

            try
            {
                this.AssociatedImage = Helpers.ProjectHelpers.GetIcon(this.Path);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                
            }
        }
    }
}
