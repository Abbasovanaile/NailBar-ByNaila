namespace WindowsFormsApp8
{
    partial class AdminPanelcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanelcs));
            this.label1 = new System.Windows.Forms.Label();
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.master_add = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.master_del = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.day_box = new System.Windows.Forms.ComboBox();
            this.month_box = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hours_box = new System.Windows.Forms.ComboBox();
            this.confirm_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(2, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of the Master";
            // 
            // cmb1
            // 
            this.cmb1.FormattingEnabled = true;
            this.cmb1.Location = new System.Drawing.Point(215, 84);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(140, 21);
            this.cmb1.TabIndex = 1;
            this.cmb1.SelectedIndexChanged += new System.EventHandler(this.cmb1_SelectedIndexChanged);
            // 
            // master_add
            // 
            this.master_add.Location = new System.Drawing.Point(471, 86);
            this.master_add.Name = "master_add";
            this.master_add.Size = new System.Drawing.Size(158, 20);
            this.master_add.TabIndex = 2;
            this.master_add.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.Aqua;
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(570, 124);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(59, 33);
            this.add_btn.TabIndex = 3;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // del_btn
            // 
            this.del_btn.BackColor = System.Drawing.Color.Aqua;
            this.del_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_btn.Location = new System.Drawing.Point(570, 223);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(59, 34);
            this.del_btn.TabIndex = 4;
            this.del_btn.Text = "Delete";
            this.del_btn.UseVisualStyleBackColor = false;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // master_del
            // 
            this.master_del.FormattingEnabled = true;
            this.master_del.Location = new System.Drawing.Point(471, 180);
            this.master_del.Name = "master_del";
            this.master_del.Size = new System.Drawing.Size(158, 21);
            this.master_del.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(2, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Master free day";
            // 
            // day_box
            // 
            this.day_box.FormattingEnabled = true;
            this.day_box.Location = new System.Drawing.Point(215, 129);
            this.day_box.Name = "day_box";
            this.day_box.Size = new System.Drawing.Size(53, 21);
            this.day_box.TabIndex = 7;
            this.day_box.SelectedIndexChanged += new System.EventHandler(this.day_SelectedIndexChanged);
            // 
            // month_box
            // 
            this.month_box.FormattingEnabled = true;
            this.month_box.Location = new System.Drawing.Point(298, 128);
            this.month_box.Name = "month_box";
            this.month_box.Size = new System.Drawing.Size(57, 21);
            this.month_box.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(2, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 27);
            this.label3.TabIndex = 9;
            this.label3.Text = "Master free hours";
            // 
            // hours_box
            // 
            this.hours_box.FormattingEnabled = true;
            this.hours_box.Location = new System.Drawing.Point(215, 179);
            this.hours_box.Name = "hours_box";
            this.hours_box.Size = new System.Drawing.Size(121, 21);
            this.hours_box.TabIndex = 10;
            // 
            // confirm_btn
            // 
            this.confirm_btn.BackColor = System.Drawing.Color.Aqua;
            this.confirm_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_btn.Location = new System.Drawing.Point(261, 253);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(94, 34);
            this.confirm_btn.TabIndex = 11;
            this.confirm_btn.Text = "Confirm\r\n\r\n";
            this.confirm_btn.UseVisualStyleBackColor = false;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // AdminPanelcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(646, 350);
            this.Controls.Add(this.confirm_btn);
            this.Controls.Add(this.hours_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.month_box);
            this.Controls.Add(this.day_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.master_del);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.master_add);
            this.Controls.Add(this.cmb1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "AdminPanelcs";
            this.Text = "AdminPanelcs";
            this.Load += new System.EventHandler(this.AdminPanelcs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb1;
        private System.Windows.Forms.TextBox master_add;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.ComboBox master_del;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox day_box;
        private System.Windows.Forms.ComboBox month_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox hours_box;
        private System.Windows.Forms.Button confirm_btn;
    }
}