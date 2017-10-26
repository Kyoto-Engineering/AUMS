namespace AppUserManagementSystem.UI
{
    partial class UpdateApplication
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AppNamelabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AppLoglabel = new System.Windows.Forms.Label();
            this.Updatebutton = new System.Windows.Forms.Button();
            this.UpdateApplabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(228, 179);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 58);
            this.textBox1.TabIndex = 0;
            // 
            // AppNamelabel
            // 
            this.AppNamelabel.AutoSize = true;
            this.AppNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppNamelabel.Location = new System.Drawing.Point(12, 194);
            this.AppNamelabel.Name = "AppNamelabel";
            this.AppNamelabel.Size = new System.Drawing.Size(210, 25);
            this.AppNamelabel.TabIndex = 2;
            this.AppNamelabel.Text = "Application Name :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(492, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(262, 271);
            this.dataGridView1.TabIndex = 3;
            // 
            // AppLoglabel
            // 
            this.AppLoglabel.AutoSize = true;
            this.AppLoglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppLoglabel.Location = new System.Drawing.Point(487, 105);
            this.AppLoglabel.Name = "AppLoglabel";
            this.AppLoglabel.Size = new System.Drawing.Size(189, 25);
            this.AppLoglabel.TabIndex = 4;
            this.AppLoglabel.Text = "Application Log :";
            // 
            // Updatebutton
            // 
            this.Updatebutton.BackgroundImage = global::AppUserManagementSystem.Properties.Resources.whitey_glossy_rectangle_button_md;
            this.Updatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebutton.Location = new System.Drawing.Point(280, 331);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(134, 47);
            this.Updatebutton.TabIndex = 5;
            this.Updatebutton.Text = "Update";
            this.Updatebutton.UseVisualStyleBackColor = true;
            // 
            // UpdateApplabel
            // 
            this.UpdateApplabel.AutoSize = true;
            this.UpdateApplabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateApplabel.Location = new System.Drawing.Point(244, 38);
            this.UpdateApplabel.Name = "UpdateApplabel";
            this.UpdateApplabel.Size = new System.Drawing.Size(295, 33);
            this.UpdateApplabel.TabIndex = 6;
            this.UpdateApplabel.Text = "Update Application :";
            // 
            // UpdateApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 433);
            this.Controls.Add(this.UpdateApplabel);
            this.Controls.Add(this.Updatebutton);
            this.Controls.Add(this.AppLoglabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AppNamelabel);
            this.Controls.Add(this.textBox1);
            this.Name = "UpdateApplication";
            this.Text = "UpdateApplication";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label AppNamelabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label AppLoglabel;
        private System.Windows.Forms.Button Updatebutton;
        private System.Windows.Forms.Label UpdateApplabel;
    }
}