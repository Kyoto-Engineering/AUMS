namespace AppUserManagementSystem.UI
{
    partial class AppCreationConsole
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
            this.labelNewAppName = new System.Windows.Forms.Label();
            this.ApptextBox = new System.Windows.Forms.TextBox();
            this.InsertAppbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelActiveApp = new System.Windows.Forms.Label();
            this.AppGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNewAppName
            // 
            this.labelNewAppName.BackColor = System.Drawing.SystemColors.Control;
            this.labelNewAppName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelNewAppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewAppName.Location = new System.Drawing.Point(81, 196);
            this.labelNewAppName.Name = "labelNewAppName";
            this.labelNewAppName.Size = new System.Drawing.Size(203, 35);
            this.labelNewAppName.TabIndex = 3;
            this.labelNewAppName.Text = "New Application Name :";
            this.labelNewAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ApptextBox
            // 
            this.ApptextBox.Location = new System.Drawing.Point(81, 243);
            this.ApptextBox.Multiline = true;
            this.ApptextBox.Name = "ApptextBox";
            this.ApptextBox.Size = new System.Drawing.Size(392, 35);
            this.ApptextBox.TabIndex = 4;
            this.ApptextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // InsertAppbutton
            // 
            this.InsertAppbutton.BackgroundImage = global::AppUserManagementSystem.Properties.Resources.whitey_glossy_rectangle_button_md;
            this.InsertAppbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertAppbutton.ForeColor = System.Drawing.Color.DarkGreen;
            this.InsertAppbutton.Location = new System.Drawing.Point(189, 333);
            this.InsertAppbutton.Name = "InsertAppbutton";
            this.InsertAppbutton.Size = new System.Drawing.Size(142, 48);
            this.InsertAppbutton.TabIndex = 5;
            this.InsertAppbutton.Text = "Insert App";
            this.InsertAppbutton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelActiveApp);
            this.groupBox1.Controls.Add(this.AppGrid);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(583, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 443);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // labelActiveApp
            // 
            this.labelActiveApp.AutoSize = true;
            this.labelActiveApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActiveApp.Location = new System.Drawing.Point(15, 16);
            this.labelActiveApp.Name = "labelActiveApp";
            this.labelActiveApp.Size = new System.Drawing.Size(119, 15);
            this.labelActiveApp.TabIndex = 4;
            this.labelActiveApp.Text = "All Active App List";
            // 
            // AppGrid
            // 
            this.AppGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.AppGrid.Location = new System.Drawing.Point(18, 37);
            this.AppGrid.Name = "AppGrid";
            this.AppGrid.Size = new System.Drawing.Size(325, 383);
            this.AppGrid.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "App ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Application Name";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(395, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "App Creation Console";
            // 
            // AppCreationConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1005, 571);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.InsertAppbutton);
            this.Controls.Add(this.ApptextBox);
            this.Controls.Add(this.labelNewAppName);
            this.Name = "AppCreationConsole";
            this.Text = "AppCreationConsole";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNewAppName;
        private System.Windows.Forms.TextBox ApptextBox;
        private System.Windows.Forms.Button InsertAppbutton;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Label labelActiveApp;
        private System.Windows.Forms.DataGridView AppGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label1;
    }
}