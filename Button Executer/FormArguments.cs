﻿using System;
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
        public FormArguments(int buttonIndex)
        {
            InitializeComponent();
            this.buttonIndex = buttonIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int buttonIndex;
    }
}