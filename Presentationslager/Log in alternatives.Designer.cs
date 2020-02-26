namespace Presentationslager
{
    partial class LoggInForm
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
            this.Btn_alumni = new System.Windows.Forms.Button();
            this.Btn_admin = new System.Windows.Forms.Button();
            this.Txt_loggainadmin = new System.Windows.Forms.Label();
            this.Txt_loggaInAlumni = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_select = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_alumni
            // 
            this.Btn_alumni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_alumni.Location = new System.Drawing.Point(490, 212);
            this.Btn_alumni.Name = "Btn_alumni";
            this.Btn_alumni.Size = new System.Drawing.Size(217, 102);
            this.Btn_alumni.TabIndex = 1;
            this.Btn_alumni.Text = "Log In";
            this.Btn_alumni.UseVisualStyleBackColor = true;
            // 
            // Btn_admin
            // 
            this.Btn_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_admin.Location = new System.Drawing.Point(91, 212);
            this.Btn_admin.Name = "Btn_admin";
            this.Btn_admin.Size = new System.Drawing.Size(217, 102);
            this.Btn_admin.TabIndex = 2;
            this.Btn_admin.Text = "Log in";
            this.Btn_admin.UseVisualStyleBackColor = true;
            // 
            // Txt_loggainadmin
            // 
            this.Txt_loggainadmin.AutoSize = true;
            this.Txt_loggainadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_loggainadmin.Location = new System.Drawing.Point(154, 184);
            this.Txt_loggainadmin.Name = "Txt_loggainadmin";
            this.Txt_loggainadmin.Size = new System.Drawing.Size(77, 25);
            this.Txt_loggainadmin.TabIndex = 3;
            this.Txt_loggainadmin.Text = "Admin";
            this.Txt_loggainadmin.Click += new System.EventHandler(this.label1_Click);
            // 
            // Txt_loggaInAlumni
            // 
            this.Txt_loggaInAlumni.AutoSize = true;
            this.Txt_loggaInAlumni.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_loggaInAlumni.Location = new System.Drawing.Point(555, 184);
            this.Txt_loggaInAlumni.Name = "Txt_loggaInAlumni";
            this.Txt_loggaInAlumni.Size = new System.Drawing.Size(83, 25);
            this.Txt_loggaInAlumni.TabIndex = 4;
            this.Txt_loggaInAlumni.Text = "Alumni";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(271, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome to the program!";
            // 
            // Txt_select
            // 
            this.Txt_select.AutoSize = true;
            this.Txt_select.Location = new System.Drawing.Point(299, 43);
            this.Txt_select.Name = "Txt_select";
            this.Txt_select.Size = new System.Drawing.Size(177, 13);
            this.Txt_select.TabIndex = 6;
            this.Txt_select.Text = "please select one of the alternatives";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // LoggInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Txt_select);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_loggaInAlumni);
            this.Controls.Add(this.Txt_loggainadmin);
            this.Controls.Add(this.Btn_admin);
            this.Controls.Add(this.Btn_alumni);
            this.Name = "LoggInForm";
            this.Text = "VäljLoggIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_alumni;
        private System.Windows.Forms.Button Btn_admin;
        private System.Windows.Forms.Label Txt_loggainadmin;
        private System.Windows.Forms.Label Txt_loggaInAlumni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Txt_select;
        private System.Windows.Forms.Button button1;
    }
}

