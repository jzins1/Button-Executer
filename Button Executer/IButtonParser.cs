using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Button_Executer
{
    public interface IButtonParser
    {
        IEnumerable<string> ParseLabels();
        IEnumerable<string> ParseTypes();
        IEnumerable<string> ParseDestinations();
    }
}
