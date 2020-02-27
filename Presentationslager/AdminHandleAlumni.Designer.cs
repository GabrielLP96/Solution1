namespace Presentationslager
{
    partial class AdminHandleAlumni
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBox_SearchName = new System.Windows.Forms.TextBox();
            this.Btn_search = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Label();
            this.Btn_delete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(612, 339);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "List of registered alumni";
            // 
            // TxtBox_SearchName
            // 
            this.TxtBox_SearchName.Location = new System.Drawing.Point(377, 14);
            this.TxtBox_SearchName.Name = "TxtBox_SearchName";
            this.TxtBox_SearchName.Size = new System.Drawing.Size(168, 20);
            this.TxtBox_SearchName.TabIndex = 2;
            // 
            // Btn_search
            // 
            this.Btn_search.Location = new System.Drawing.Point(551, 12);
            this.Btn_search.Name = "Btn_search";
            this.Btn_search.Size = new System.Drawing.Size(75, 23);
            this.Btn_search.TabIndex = 3;
            this.Btn_search.Text = "Search";
            this.Btn_search.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Location = new System.Drawing.Point(286, 17);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(85, 13);
            this.Search.TabIndex = 4;
            this.Search.Text = "Search for name";
            // 
            // Btn_delete
            // 
            this.Btn_delete.Location = new System.Drawing.Point(18, 415);
            this.Btn_delete.Name = "Btn_delete";
            this.Btn_delete.Size = new System.Drawing.Size(75, 23);
            this.Btn_delete.TabIndex = 5;
            this.Btn_delete.Text = "Delete";
            this.Btn_delete.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Delete one selected activitie";
            // 
            // AdminHandleAlumni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Btn_delete);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Btn_search);
            this.Controls.Add(this.TxtBox_SearchName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminHandleAlumni";
            this.Text = "AdminHandleAlumni";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBox_SearchName;
        private System.Windows.Forms.Button Btn_search;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.Button Btn_delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}