using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BveEx.PluginHost.Plugins;

namespace Automatic9045.BveEx.UpdateChecker
{
    [Plugin(PluginType.MapPlugin)]
    internal class MapPluginMain : AssemblyPluginBase
    {
        public MapPluginMain(PluginBuilder builder) : base(builder)
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
