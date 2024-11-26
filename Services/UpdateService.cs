using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiKit.Services
{
    public interface IUpdateService
    {
        (bool IsUpdateRequired, bool IsMandatory) CheckForUpdate();
    }

    public class UpdateService : IUpdateService
    {
        public (bool IsUpdateRequired, bool IsMandatory) CheckForUpdate()
        {
            
            bool isUpdateRequired = true; // Is there optimal update?
            bool isMandatory = false;    // Is there force update?

            return (isUpdateRequired, isMandatory);
        }
    }
}