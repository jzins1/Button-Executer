
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace Button_Executer
{
    partial class FormArguments
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(int numArguments)
        {
            int totalTabs = 2;

            textBoxes = new System.Windows.Forms.TextBox[numArguments];
            labels = new System.Windows.Forms.Label[numArguments];

            for(int i = 0; i < numArguments; i++)
            {
                labels[i] = new System.Windows.Forms.Label();
                textBoxes[i] = new System.Windows.Forms.TextBox();
                labels[i].AutoSize = true;
                //buttons[index].Location = new System.Drawing.Point((int)(35 + Math.Floor((double) (index / 10)) * 175), 35 + ((index % 10) * 40));
                //labels[i].Location = new System.Drawing.Point(42, 36 + (i * 40));
                labels[i].Location = new System.Drawing.Point((int)(42 + Math.Floor((double) (i / 10)) * 400), 25 + ((i % 10) * 40));
                labels[i].Name = "label" + (i + 1);
                labels[i].Size = new System.Drawing.Size(64, 13);
                labels[i].TabIndex = totalTabs;
                totalTabs++;
                labels[i].Text = "Argument " + (i + 1) + ":";
                //textBoxes[i].Location = new System.Drawing.Point(112, 33 + (i * 40));
                textBoxes[i].Location = new System.Drawing.Point((int)(112 + Math.Floor((double) (i / 10)) * 400), 22 + ((i % 10) * 40));
                textBoxes[i].Name = "textBox" + (i + 1);
                textBoxes[i].Size = new System.Drawing.Size(222, 20);
                textBoxes[i].TabIndex = totalTabs;
                totalTabs++;
            }
            /*
            XmlNodeList argumentsList = xmlFile.GetElementsByTagName("");
            int count = destinationList.Count;
            string stringDebug = destinationList[4].InnerText.ToString();
            System.Windows.Forms.Button[] buttons = new System.Windows.Forms.Button[count];



            for (int i = 0; i < count; i++)
            {
                buttons[i] = new System.Windows.Forms.Button();
                buttons[i].Location = new System.Drawing.Point(96, 75 + (i * 40));
                buttons[i].Name = "button" + (i + 1);
                buttons[i].Size = new System.Drawing.Size(150, 23);
                buttons[i].TabIndex = i;
                buttons[i].Text = labelList[i].InnerText.ToString();
                buttons[i].UseVisualStyleBackColor = true;
                
                if (typeList[i].InnerText.ToString() == "Command")
                {
                    buttons[i].Click += new System.EventHandler(buttonx_Click);
                }
                
            }
            */

            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(429, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            /*
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Argument 1:";
            // 
            */
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(312, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormArguments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            for(int i = 0; i < numArguments; i++)
            {
                this.Controls.Add(labels[i]);
                this.Controls.Add(textBoxes[i]);
            }
            /*
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            */
            this.Name = "FormArguments";
            this.Text = "FormArguments";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox[] textBoxes;
        private System.Windows.Forms.Label[] labels;
    }
}