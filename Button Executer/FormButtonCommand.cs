using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Button_Executer
{
    public class FormButtonCommand : FormButton
    {
        public string Label { get; set; }
        public string Type { get; set; }
        public string Destination { get; set; }

        public FormButtonCommand(string label, string type, string destination) : base(label, type, destination)
        {
            this.Label = label;
            this.Type = type;
            this.Destination = destination;
        }

        public override void ExecuteDestination()
        {
            int numArguments = Destination.Count(c => c == '$');
            bool restart = false;
            //string oldDestination = "";
            if (numArguments > 0)
            {
                //oldDestination = Destination;
                ArgumentHolder arguments = new ArgumentHolder(numArguments);
                FormArguments formArguments = new FormArguments(arguments);
                formArguments.ShowDialog();
                StringBuilder stringBuilder = new StringBuilder(Destination);
                int argumentIndex;
                for(int i = 0; i < arguments.Args.Length; i++)
                {
                    string argument = arguments.Args[i];
                    argumentIndex = Destination.IndexOf('$');
                    stringBuilder.Remove(argumentIndex, 1);
                    stringBuilder.Insert(argumentIndex, argument);
                    Destination = stringBuilder.ToString();
                }
                restart = true;
            }
            System.Diagnostics.Process.Start("cmd.exe", "/C start " + Destination);
            if (restart)
            {
                restart = false; 
                Application.Restart();
            }
                
            //Destination = oldDestination;
        }
    }
}
