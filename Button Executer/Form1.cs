using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Button_Executer
{
    public partial class Form1 : Form
    {
        IEnumerable<string> labelList;
        IEnumerable<string> destinationList;
        public Form1()
        {
            InitializeComponent();
            ButtonParser buttonParser = new ButtonParser("%userprofile%\\Documents\\Button Executer\\buttons.xml");
            labelList = buttonParser.ParseLabels();
            destinationList = buttonParser.ParseDestinations();
        }

        private void buttonx_Click(object sender, EventArgs e)
        {

            /*
            Button b = sender as Button;
            int iteration = 0;
            foreach (var label in labelList)
            {
                if(label.Equals("Reboot PC"))
                //if(label.Equals(b.Text))
                {
                    FormArguments fA = new FormArguments(3); // However I am keeping track of button index, that goes in parameter
                    fA.ShowDialog();
                    break;
                }
                iteration++;

            }
            */

        }
        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://mail.google.com");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", Environment.ExpandEnvironmentVariables("%userprofile%\\Documents"));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", Environment.ExpandEnvironmentVariables("%userprofile%\\Downloads"));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe", "/C shutdown -r -t 3600");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe", "/C shutdown -a");
        }
    }
}
