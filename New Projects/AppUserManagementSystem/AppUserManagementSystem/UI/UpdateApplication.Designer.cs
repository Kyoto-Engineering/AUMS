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
            this.exappname = new System.Windows.Forms.TextBox();
            this.AppNamelabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AppLoglabel = new System.Windows.Forms.Label();
            this.Updatebutton = new System.Windows.Forms.Button();
            this.UpdateApplabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.upname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.appid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // exappname
            // 
            this.exappname.Location = new System.Drawing.Point(23, 90);
            this.exappname.Multiline = true;
            this.exappname.Name = "exappname";
            this.exappname.ReadOnly = true;
            this.exappname.Size = new System.Drawing.Size(332, 35);
            this.exappname.TabIndex = 0;
            // 
            // AppNamelabel
            // 
            this.AppNamelabel.AutoSize = true;
            this.AppNamelabel.BackColor = System.Drawing.SystemColors.Control;
            this.AppNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppNamelabel.Location = new System.Drawing.Point(18, 45);
            this.AppNamelabel.Name = "AppNamelabel";
            this.AppNamelabel.Size = new System.Drawing.Size(225, 25);
            this.AppNamelabel.TabIndex = 2;
            this.AppNamelabel.Text = "Existing App Name :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appid,
            this.appname});
            this.dataGridView1.Location = new System.Drawing.Point(23, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(452, 341);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // AppLoglabel
            // 
            this.AppLoglabel.AutoSize = true;
            this.AppLoglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppLoglabel.Location = new System.Drawing.Point(18, 14);
            this.AppLoglabel.Name = "AppLoglabel";
            this.AppLoglabel.Size = new System.Drawing.Size(167, 24);
            this.AppLoglabel.TabIndex = 4;
            this.AppLoglabel.Text = "Application Log :";
            // 
            // Updatebutton
            // 
            this.Updatebutton.BackgroundImage = global::AppUserManagementSystem.Properties.Resources.whitey_glossy_rectangle_button_md;
            this.Updatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebutton.Location = new System.Drawing.Point(243, 452);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(134, 47);
            this.Updatebutton.TabIndex = 5;
            this.Updatebutton.Text = "Update";
            this.Updatebutton.UseVisualStyleBackColor = true;
            this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            // 
            // UpdateApplabel
            // 
            this.UpdateApplabel.AutoSize = true;
            this.UpdateApplabel.BackColor = System.Drawing.SystemColors.Control;
            this.UpdateApplabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateApplabel.Location = new System.Drawing.Point(244, 38);
            this.UpdateApplabel.Name = "UpdateApplabel";
            this.UpdateApplabel.Size = new System.Drawing.Size(295, 33);
            this.UpdateApplabel.TabIndex = 6;
            this.UpdateApplabel.Text = "Update Application :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.upname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.AppNamelabel);
            this.groupBox1.Controls.Add(this.exappname);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 289);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // upname
            // 
            this.upname.Location = new System.Drawing.Point(23, 212);
            this.upname.Multiline = true;
            this.upname.Name = "upname";
            this.upname.Size = new System.Drawing.Size(332, 40);
            this.upname.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Update Name :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AppLoglabel);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(435, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 408);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // appid
            // 
            this.appid.HeaderText = "App Id";
            this.appid.Name = "appid";
            this.appid.Width = 70;
            // 
            // appname
            // 
            this.appname.HeaderText = "App Name";
            this.appname.Name = "appname";
            this.appname.Width = 350;
            // 
            // UpdateApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(976, 523);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UpdateApplabel);
            this.Controls.Add(this.Updatebutton);
            this.Name = "UpdateApplication";
            this.Text = "UpdateApplication";
            this.Load += new System.EventHandler(this.UpdateApplication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox exappname;
        private System.Windows.Forms.Label AppNamelabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label AppLoglabel;
        private System.Windows.Forms.Button Updatebutton;
        private System.Windows.Forms.Label UpdateApplabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox upname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn appid;
        private System.Windows.Forms.DataGridViewTextBoxColumn appname;
    }
}