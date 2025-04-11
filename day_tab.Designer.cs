using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class day_tab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Event3 = new System.Windows.Forms.Label();
            this.Event2 = new System.Windows.Forms.Label();
            this.Event1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Event3);
            this.panel1.Controls.Add(this.Event2);
            this.panel1.Controls.Add(this.Event1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1);
            this.panel1.Size = new System.Drawing.Size(131, 102);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.Clk);
            // 
            // Event3
            // 
            this.Event3.AutoSize = true;
            this.Event3.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Event3.Location = new System.Drawing.Point(12, 71);
            this.Event3.Margin = new System.Windows.Forms.Padding(2);
            this.Event3.Name = "Event3";
            this.Event3.Size = new System.Drawing.Size(82, 28);
            this.Event3.TabIndex = 4;
            this.Event3.Text = "Event3";
            // 
            // Event2
            // 
            this.Event2.AutoSize = true;
            this.Event2.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Event2.Location = new System.Drawing.Point(12, 52);
            this.Event2.Margin = new System.Windows.Forms.Padding(2);
            this.Event2.Name = "Event2";
            this.Event2.Size = new System.Drawing.Size(48, 17);
            this.Event2.TabIndex = 3;
            this.Event2.Text = "Event2";
            // 
            // Event1
            // 
            this.Event1.AutoSize = true;
            this.Event1.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Event1.Location = new System.Drawing.Point(12, 33);
            this.Event1.Margin = new System.Windows.Forms.Padding(2);
            this.Event1.Name = "Event1";
            this.Event1.Size = new System.Drawing.Size(45, 17);
            this.Event1.TabIndex = 2;
            this.Event1.Text = "Event1";
            this.Event1.Click += new System.EventHandler(this.Event1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(119, 4);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "00";
            // 
            // day_tab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "day_tab";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Size = new System.Drawing.Size(133, 104);
            this.Load += new System.EventHandler(this.Day_tab);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private Label Event3;
        private Label Event2;
        private Label Event1;
    }
}
