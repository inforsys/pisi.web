using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.ServiceModel;
using Pisi.Services;

namespace Pisi.MasterData.WinServiceApp
{
    public partial class MasterDataApp : ServiceBase
    {
        ServiceHost serviceHost;

        public MasterDataApp()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            serviceHost = new ServiceHost(typeof(PisiServices));
            serviceHost.Open();
        }

        protected override void OnStop()
        {
            serviceHost.Close();
        }
    }
}