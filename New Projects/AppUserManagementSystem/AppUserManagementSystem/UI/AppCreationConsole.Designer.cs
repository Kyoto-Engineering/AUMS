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
            this.LabelAppCreation = new System.Windows.Forms.Label();
            this.AppGrid = new System.Windows.Forms.DataGridView();
            this.labelActiveApp = new System.Windows.Forms.Label();
            this.labelNewAppName = new System.Windows.Forms.Label();
            this.ApptextBox = new System.Windows.Forms.TextBox();
            this.InsertAppbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AppGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelAppCreation
            // 
            this.LabelAppCreation.AutoSize = true;
            this.LabelAppCreation.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAppCreation.Location = new System.Drawing.Point(160, 27);
            this.LabelAppCreation.Name = "LabelAppCreation";
            this.LabelAppCreation.Size = new System.Drawing.Size(419, 33);
            this.LabelAppCreation.TabIndex = 0;
            this.LabelAppCreation.Text = "Application Creation Console\r\n";
            this.LabelAppCreation.Click += new System.EventHandler(this.label1_Click);
            // 
            // AppGrid
            // 
            this.AppGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppGrid.Location = new System.Drawing.Point(428, 111);
            this.AppGrid.Name = "AppGrid";
            this.AppGrid.Size = new System.Drawing.Size(310, 326);
            this.AppGrid.TabIndex = 1;
            // 
            // labelActiveApp
            // 
            this.labelActiveApp.AutoSize = true;
            this.labelActiveApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActiveApp.Location = new System.Drawing.Point(423, 83);
            this.labelActiveApp.Name = "labelActiveApp";
            this.labelActiveApp.Size = new System.Drawing.Size(204, 25);
            this.labelActiveApp.TabIndex = 2;
            this.labelActiveApp.Text = "All Active App List";
            // 
            // labelNewAppName
            // 
            this.labelNewAppName.AutoSize = true;
            this.labelNewAppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewAppName.Location = new System.Drawing.Point(12, 213);
            this.labelNewAppName.Name = "labelNewAppName";
            this.labelNewAppName.Size = new System.Drawing.Size(162, 48);
            this.labelNewAppName.TabIndex = 3;
            this.labelNewAppName.Text = "New Application\r\nName :";
            // 
            // ApptextBox
            // 
            this.ApptextBox.Location = new System.Drawing.Point(180, 213);
            this.ApptextBox.Multiline = true;
            this.ApptextBox.Name = "ApptextBox";
            this.ApptextBox.Size = new System.Drawing.Size(207, 48);
            this.ApptextBox.TabIndex = 4;
            this.ApptextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // InsertAppbutton
            // 
            this.InsertAppbutton.BackgroundImage = global::AppUserManagementSystem.Properties.Resources.whitey_glossy_rectangle_button_md;
            this.InsertAppbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertAppbutton.Location = new System.Drawing.Point(166, 368);
            this.InsertAppbutton.Name = "InsertAppbutton";
            this.InsertAppbutton.Size = new System.Drawing.Size(142, 48);
            this.InsertAppbutton.TabIndex = 5;
            this.InsertAppbutton.Text = "Insert App";
            this.InsertAppbutton.UseVisualStyleBackColor = true;
            // 
            // AppCreationConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(766, 471);
            this.Controls.Add(this.InsertAppbutton);
            this.Controls.Add(this.ApptextBox);
            this.Controls.Add(this.labelNewAppName);
            this.Controls.Add(this.labelActiveApp);
            this.Controls.Add(this.AppGrid);
            this.Controls.Add(this.LabelAppCreation);
            this.Name = "AppCreationConsole";
            this.Text = "AppCreationConsole";
            ((System.ComponentModel.ISupportInitialize)(this.AppGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelAppCreation;
        private System.Windows.Forms.DataGridView AppGrid;
        internal System.Windows.Forms.Label labelActiveApp;
        private System.Windows.Forms.Label labelNewAppName;
        private System.Windows.Forms.TextBox ApptextBox;
        private System.Windows.Forms.Button InsertAppbutton;
    }
}