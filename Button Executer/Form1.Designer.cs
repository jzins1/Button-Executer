
using System;
using System.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Button_Executer
{
    partial class Form1
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
        private void InitializeComponent()
        {
            // XML Initialization code
            ButtonParser buttonParser = new ButtonParser("%userprofile%\\Documents\\Button Executer\\buttons.xml");

            IEnumerable<string> labelList = buttonParser.ParseLabels();
            IEnumerable<string> typeList = buttonParser.ParseTypes();
            IEnumerable<string> destinationList = buttonParser.ParseDestinations();
            int count = destinationList.Count();

            System.Windows.Forms.Button[] buttons = new System.Windows.Forms.Button[count];
            FormButton[] formButtons = new FormButton[count];

            int index = 0;
            foreach ((string label, string type, string destination) in labelList.Zip(typeList, (l, t) => (l, t)).Zip(destinationList, (t, d) => (t.Item1, t.Item2, d)))
            {
                if (type.Equals("File"))  formButtons[index] = new FormButtonFile(label, type, destination);
                if (type.Equals("Link"))  formButtons[index] = new FormButtonLink(label, type, destination);
                if (type.Equals("Command")) formButtons[index] = new FormButtonCommand(label, type, destination);
                buttons[index] = new System.Windows.Forms.Button();
                buttons[index].Location = new System.Drawing.Point((int)(35 + Math.Floor((double) (index / 10)) * 175), 35 + ((index % 10) * 40));
                buttons[index].Name = "button" + (index + 1);
                buttons[index].Size = new System.Drawing.Size(150, 23);
                buttons[index].TabIndex = index;
                buttons[index].Text = formButtons[index].Label;
                buttons[index].UseVisualStyleBackColor = true;
                buttons[index].Click += (sender, e) =>
                {
                    Button clickedButton = sender as Button;
                    for(int i = 0; i < count; i++)
                    {
                        if(clickedButton == buttons[i])
                        {
                            formButtons[i].ExecuteDestination();
                        }
                    }
                };
                /*
                if(type == "Command")
                {
                    //buttons[index].Click += new System.EventHandler(buttonx_Click);
                    buttons[index].Click += (sender, e) =>
                    {

                    }new System.EventHandler(buttonx_Click);
                }
                */
                index++;
            }

            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "GMail";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(96, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Documents";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(96, 182);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Downloads";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(96, 238);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(159, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Shutdown Test";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(96, 293);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(136, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Cancel Shutdown";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(444, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            for(int i = 0; i < count; i++)
            {
                this.Controls.Add(buttons[i]);
            }
            /*
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            */
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
    }
}

