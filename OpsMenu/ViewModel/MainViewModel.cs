using DevExpress.Xpf.Editors.Helpers;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using OpsMenu.Data;
using System.Linq;

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

        public IOpsDataService OpsLinksData { get; }
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
                

                this.OpsApplications.Apps.Add(new AppViewModel("PowerBI",@"C:\Program Files\Microsoft Power BI Desktop\bin\PBIDesktop.exe" ));
                this.OpsApplications.Apps.Add(new AppViewModel("Test File",@"C:\Users\mvaysman\Desktop\test.txt" ));
                this.OpsApplications.Apps.Add(new AppViewModel("New Hire Pdf", @"C:\Users\mvaysman\Desktop\New Hire Insider Trading Aptitude Examination.pdf"));
                this.OpsApplications.Apps.Add(new AppViewModel("Dell Display Manager", @"C:\Program Files (x86)\Dell\Dell Display Manager\ddm.exe"));
                this.OpsApplications.Apps.Add(new AppViewModel("GeForce Experience", @"C:\Program Files(x86)\NVIDIA Corporation\NVIDIA GeForce Experience\NVIDIA GeForce Experience.exe" ));
            }
            else
            {
                // Code runs "for real"


                this.OpsApplications.Apps.Add(new AppViewModel("PowerBI", @"C:\Program Files\Microsoft Power BI Desktop\bin\PBIDesktop.exe"));
                this.OpsApplications.Apps.Add(new AppViewModel("Test File", @"C:\Users\mvaysman\Desktop\test.txt"));
                this.OpsApplications.Apps.Add(new AppViewModel("New Hire Pdf", @"C:\Users\mvaysman\Desktop\New Hire Insider Trading Aptitude Examination.pdf"));
                this.OpsApplications.Apps.Add(new AppViewModel("Dell Display Manager", @"C:\Program Files (x86)\Dell\Dell Display Manager\ddm.exe"));
                this.OpsApplications.Apps.Add(new AppViewModel("GeForce Experience", @"C:\Program Files(x86)\NVIDIA Corporation\NVIDIA GeForce Experience\NVIDIA GeForce Experience.exe"));
            }
        }

        [PreferredConstructor]
        public MainViewModel(IOpsDataService opsLinksData)
        {
            this.OpsApplications = new AppsViewModel();
            this.OpsLinksData = opsLinksData;

            this.OpsLinksData.OpsApplicationLinks
                .ToList()
                .ForEach(i=>
                    this.OpsApplications.Apps.Add(
                new AppViewModel(i.AppName,i.PathToApplication))
                );

        }
    }
}