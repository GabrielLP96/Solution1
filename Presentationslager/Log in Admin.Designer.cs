namespace Presentationslager
{
    partial class LogInadmin
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
            this.textBoxLogInAdminPassword = new System.Windows.Forms.TextBox();
            this.textBoxLoginadmin = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.Label();
            this.txt_adminId = new System.Windows.Forms.Label();
            this.btn_LogInAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxLogInAdminPassword
            // 
            this.textBoxLogInAdminPassword.Location = new System.Drawing.Point(176, 145);
            this.textBoxLogInAdminPassword.Name = "textBoxLogInAdminPassword";
            this.textBoxLogInAdminPassword.Size = new System.Drawing.Size(159, 20);
            this.textBoxLogInAdminPassword.TabIndex = 17;
            this.textBoxLogInAdminPassword.UseSystemPasswordChar = true;
            // 
            // textBoxLoginadmin
            // 
            this.textBoxLoginadmin.Location = new System.Drawing.Point(176, 93);
            this.textBoxLoginadmin.Name = "textBoxLoginadmin";
            this.textBoxLoginadmin.Size = new System.Drawing.Size(159, 20);
            this.textBoxLoginadmin.TabIndex = 16;
            // 
            // txt_password
            // 
            this.txt_password.AutoSize = true;
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(97, 145);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(76, 16);
            this.txt_password.TabIndex = 15;
            this.txt_password.Text = "Password";
            // 
            // txt_adminId
            // 
            this.txt_adminId.AutoSize = true;
            this.txt_adminId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_adminId.Location = new System.Drawing.Point(104, 93);
            this.txt_adminId.Name = "txt_adminId";
            this.txt_adminId.Size = new System.Drawing.Size(66, 16);
            this.txt_adminId.TabIndex = 14;
            this.txt_adminId.Text = "AdminID";
            // 
            // btn_LogInAdmin
            // 
            this.btn_LogInAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogInAdmin.Location = new System.Drawing.Point(176, 183);
            this.btn_LogInAdmin.Name = "btn_LogInAdmin";
            this.btn_LogInAdmin.Size = new System.Drawing.Size(159, 61);
            this.btn_LogInAdmin.TabIndex = 13;
            this.btn_LogInAdmin.Text = "Log in";
            this.btn_LogInAdmin.UseVisualStyleBackColor = true;
            // 
            // LogInadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxLogInAdminPassword);
            this.Controls.Add(this.textBoxLoginadmin);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_adminId);
            this.Controls.Add(this.btn_LogInAdmin);
            this.Name = "LogInadmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log in Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLogInAdminPassword;
        private System.Windows.Forms.TextBox textBoxLoginadmin;
        private System.Windows.Forms.Label txt_password;
        private System.Windows.Forms.Label txt_adminId;
        private System.Windows.Forms.Button btn_LogInAdmin;
    }
}