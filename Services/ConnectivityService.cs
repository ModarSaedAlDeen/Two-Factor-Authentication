using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Networking;


namespace MauiKit.Services
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