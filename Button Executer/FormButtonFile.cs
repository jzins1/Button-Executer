﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Button_Executer
{
    public class FormButtonFile : FormButton
    {
        public string Label { get; set; }
        public string Type { get; set; }
        public string Destination { get; set; }

        public FormButtonFile(string label, string type, string destination) : base(label, type, destination)
        {
            this.Label = label;
            this.Type = type;
            this.Destination = destination;
        }

        public override void ExecuteDestination()
        {
            System.Diagnostics.Process.Start("explorer.exe", Environment.ExpandEnvironmentVariables(Destination));
        }
    }
}
