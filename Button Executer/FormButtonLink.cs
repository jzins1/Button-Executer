using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Button_Executer
{
    public class FormButtonLink : FormButton
    {
        public string Label { get; set; }
        public string Type { get; set; }
        public string Destination { get; set; }

        public FormButtonLink(string label, string type, string destination) : base(label, type, destination)
        {
            Label = label;
            Type = type;
            Destination = destination;
        }

        public void ExecuteDestination()
        {
            System.Diagnostics.Process.Start(Destination);
            Console.WriteLine("Destination is " + Destination);
        }
    }
}
