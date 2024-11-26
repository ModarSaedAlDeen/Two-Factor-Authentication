using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiKit.Services
{
    public interface IMaintenanceService
    {
        bool IsUnderMaintenance();
    }

    public class MaintenanceService : IMaintenanceService
    {
        public bool IsUnderMaintenance()
        {
            return false; // Is there any block for app?
        }
    }
}