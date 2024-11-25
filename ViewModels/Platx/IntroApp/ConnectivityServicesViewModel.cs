using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiKit.ViewModels.Platx.IntroApp
{
    public interface IConnectivityService
    {
        bool IsInternetAvailable();
    }

    public class ConnectivityService : IConnectivityService
    {
        public bool IsInternetAvailable()
        {
            return Connectivity.NetworkAccess == NetworkAccess.Internet;
        }
    }
}
