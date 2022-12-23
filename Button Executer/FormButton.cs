using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Button_Executer
{
    public class FormButton
    {
        public string Label { get; set; }
        public string Type { get; set; }
        public string Destination { get; set; }

        public FormButton(string label, string type, string destination)
        {
            Label = label;
            Type = type;
            Destination = destination;
        }

        public virtual void ExecuteDestination()
        {

        }
    }
}
