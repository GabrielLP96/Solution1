namespace Presentationslager
{
    partial class AlumniMeny
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
            this.btnLogOut = new System.Windows.Forms.Button();
            this.Btn_Activities = new System.Windows.Forms.Button();
            this.Btn_MyProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(705, 412);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(85, 28);
            this.btnLogOut.TabIndex = 18;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // Btn_Activities
            // 
            this.Btn_Activities.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Activities.Location = new System.Drawing.Point(479, 166);
            this.Btn_Activities.Name = "Btn_Activities";
            this.Btn_Activities.Size = new System.Drawing.Size(217, 102);
            this.Btn_Activities.TabIndex = 17;
            this.Btn_Activities.Text = "Activities";
            this.Btn_Activities.UseVisualStyleBackColor = true;
            // 
            // Btn_MyProfile
            // 
            this.Btn_MyProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_MyProfile.Location = new System.Drawing.Point(76, 166);
            this.Btn_MyProfile.Name = "Btn_MyProfile";
            this.Btn_MyProfile.Size = new System.Drawing.Size(217, 102);
            this.Btn_MyProfile.TabIndex = 16;
            this.Btn_MyProfile.Text = "My profile";
            this.Btn_MyProfile.UseVisualStyleBackColor = true;
            // 
            // AlumniMeny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.Btn_Activities);
            this.Controls.Add(this.Btn_MyProfile);
            this.Name = "AlumniMeny";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button Btn_Activities;
        private System.Windows.Forms.Button Btn_MyProfile;
    }
}