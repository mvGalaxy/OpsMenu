using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpsMenu.Data
{
    public interface IOpsData
    {
        string AppName { get; set; }
        string PathToApplication { get; set; }
        string GroupName { get; set; }
    }

    public interface IOpsDataService
    {
        IEnumerable<IOpsData> OpsApplicationLinks { get; set; }

    }
}
