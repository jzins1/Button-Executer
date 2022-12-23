using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Button_Executer
{
    public partial class FormArguments : Form
    {
        private ArgumentHolder arguments;
        public FormArguments(ArgumentHolder argumentHolder)
        {
            arguments = argumentHolder;
            InitializeComponent(arguments.Args.Length);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < arguments.Args.Length; i++)
            {
                arguments.Args[i] = textBoxes[i].Text;
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int buttonIndex;
    }
}
