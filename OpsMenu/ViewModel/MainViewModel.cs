using GalaSoft.MvvmLight;

namespace OpsMenu.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {

        #region OpsApplications
        /// <summary>
        /// The <see cref="OpsApplications" /> property's name.
        /// </summary>
        public const string OpsApplicationsPropertyName = "OpsApplications";

        private AppsViewModel _opsApplications;

        /// <summary>
        /// Sets and gets the OpsApplications property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public AppsViewModel OpsApplications
        {
            get
            {
                return _opsApplications;
            }
            set
            {
                Set(() => OpsApplications, ref _opsApplications, value);
            }
        }
        #endregion

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            this.OpsApplications = new AppsViewModel();
            if (IsInDesignMode)
            {
                // Code runs in Blend --> create design time data.
                

                this.OpsApplications.Apps.Add(new AppViewModel(){App="PowerBI", Path = @"C:\Program Files\Microsoft Power BI Desktop\bin\PBIDesktop.exe" });
                this.OpsApplications.Apps.Add(new AppViewModel(){App = "Test File" , Path = @"C:\Users\mvaysman\Desktop\test.txt" });
                this.OpsApplications.Apps.Add(new AppViewModel(){App = "New Hire Pdf", Path = @"C:\Users\mvaysman\Desktop\New Hire Insider Trading Aptitude Examination.pdf" });
                this.OpsApplications.Apps.Add(new AppViewModel(){App = "Dell Display Manager", Path = @"C:\Program Files (x86)\Dell\Dell Display Manager\ddm.exe" });
                this.OpsApplications.Apps.Add(new AppViewModel(){App = "GeForce Experience", Path = @"C:\Program Files(x86)\NVIDIA Corporation\NVIDIA GeForce Experience\NVIDIA GeForce Experience.exe" });
            }
            else
            {
                // Code runs "for real"
                this.OpsApplications.Apps.Add(new AppViewModel() { App = "PowerBI", Path = @"C:\Program Files\Microsoft Power BI Desktop\bin\PBIDesktop.exe" });
                this.OpsApplications.Apps.Add(new AppViewModel() { App = "Test File", Path = @"C:\Users\mvaysman\Desktop\test.txt" });
                this.OpsApplications.Apps.Add(new AppViewModel() { App = "New Hire Pdf", Path = @"C:\Users\mvaysman\Desktop\New Hire Insider Trading Aptitude Examination.pdf" });
                this.OpsApplications.Apps.Add(new AppViewModel() { App = "Dell Display Manager", Path = @"C:\Program Files (x86)\Dell\Dell Display Manager\ddm.exe" });
                this.OpsApplications.Apps.Add(new AppViewModel() { App = "GeForce Experience", Path = @"C:\Program Files(x86)\NVIDIA Corporation\NVIDIA GeForce Experience\NVIDIA GeForce Experience.exe" });
            }
        }
    }
}