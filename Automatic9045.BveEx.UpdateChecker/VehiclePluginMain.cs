using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BveEx.PluginHost.Plugins;

namespace Automatic9045.BveEx.UpdateChecker
{
    [Plugin(PluginType.VehiclePlugin)]
    internal class VehiclePluginMain : AssemblyPluginBase
    {
        public VehiclePluginMain(PluginBuilder builder) : base(builder)
        {
            Hosting.UpdateChecker.CheckUpdates();
        }

        public override void Dispose()
        {
        }

        public override void Tick(TimeSpan elapsed)
        {
        }
    }
}
