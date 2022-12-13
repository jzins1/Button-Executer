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
        XmlDocument xmlFile;
        XmlNodeList labelList;
        XmlNodeList destinationList;
        public Form1()
        {
            InitializeComponent();
            xmlFile = new XmlDocument();
            xmlFile.Load(Environment.ExpandEnvironmentVariables("%userprofile%\\Documents\\Button Executer\\buttons.xml"));
            labelList = xmlFile.GetElementsByTagName("ButtonLabel");
            destinationList = xmlFile.GetElementsByTagName("ButtonDestination");
        }

        private void buttonx_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            for(int i = 0; i < destinationList.Count; i++)
            {
                if(labelList[i].InnerText.ToString().Equals(b.Text))
                {
                    FormArguments fA = new FormArguments(i);
                    fA.ShowDialog();
                    break;
                }
            }

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
