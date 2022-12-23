using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Button_Executer
{
    public class ArgumentHolder
    {
        public string[] Args { get; set; }

        public ArgumentHolder(int numArgs)
        {
            Args = new string[numArgs];
        }
    }
}
