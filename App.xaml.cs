using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Net.Http;

namespace Admin_Client_APL
{
    public partial class App : Application
    {
        // readonly: we don't need to modify the "client" var
        public static readonly HttpClient Client = new();
    }
}
