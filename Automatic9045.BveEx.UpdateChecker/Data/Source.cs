using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Automatic9045.BveEx.UpdateChecker.Data
{
    public class Source
    {

        [XmlElement(typeof(GitHubRepository))]
        [XmlElement(typeof(HttpRequest))]
        public SourceBase Value = new HttpRequest();
    }
}
