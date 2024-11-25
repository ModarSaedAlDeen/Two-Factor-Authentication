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
        // التحكم بحالة الصيانة ديناميكياً
        public bool IsUnderMaintenance()
        {
            // تعديل القيمة هنا لتجربة الصيانة
            return false; // true إذا كان التطبيق تحت الصيانة
        }
    }
}