﻿namespace Presentationslager
{
    partial class AdminEditActivities
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_save = new System.Windows.Forms.Button();
            this.Btn_Previous = new System.Windows.Forms.Button();
            this.Txtbox_activitieName = new System.Windows.Forms.TextBox();
            this.Txtbox_description = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Txtbox_description);
            this.groupBox1.Controls.Add(this.Txtbox_activitieName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit activitie";
            // 
            // Btn_save
            // 
            this.Btn_save.Location = new System.Drawing.Point(233, 269);
            this.Btn_save.Name = "Btn_save";
            this.Btn_save.Size = new System.Drawing.Size(75, 23);
            this.Btn_save.TabIndex = 1;
            this.Btn_save.Text = "Save";
            this.Btn_save.UseVisualStyleBackColor = true;
            this.Btn_save.Click += new System.EventHandler(this.Btn_save_Click);
            // 
            // Btn_Previous
            // 
            this.Btn_Previous.Location = new System.Drawing.Point(342, 269);
            this.Btn_Previous.Name = "Btn_Previous";
            this.Btn_Previous.Size = new System.Drawing.Size(75, 23);
            this.Btn_Previous.TabIndex = 2;
            this.Btn_Previous.Text = "Previous";
            this.Btn_Previous.UseVisualStyleBackColor = true;
            this.Btn_Previous.Click += new System.EventHandler(this.Btn_Previous_Click);
            // 
            // Txtbox_activitieName
            // 
            this.Txtbox_activitieName.Location = new System.Drawing.Point(108, 44);
            this.Txtbox_activitieName.Name = "Txtbox_activitieName";
            this.Txtbox_activitieName.Size = new System.Drawing.Size(261, 20);
            this.Txtbox_activitieName.TabIndex = 0;
            // 
            // Txtbox_description
            // 
            this.Txtbox_description.Location = new System.Drawing.Point(108, 79);
            this.Txtbox_description.Multiline = true;
            this.Txtbox_description.Name = "Txtbox_description";
            this.Txtbox_description.Size = new System.Drawing.Size(291, 150);
            this.Txtbox_description.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Activitie name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Activitie description";
            // 
            // AdminEditActivities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 331);
            this.Controls.Add(this.Btn_Previous);
            this.Controls.Add(this.Btn_save);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdminEditActivities";
            this.Text = "EditActivities";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txtbox_description;
        private System.Windows.Forms.TextBox Txtbox_activitieName;
        private System.Windows.Forms.Button Btn_save;
        private System.Windows.Forms.Button Btn_Previous;
    }
}