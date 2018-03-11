namespace WindowsFormsApp8
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.user_name = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.user_box = new System.Windows.Forms.TextBox();
            this.pass_box = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user_name
            // 
            this.user_name.AutoSize = true;
            this.user_name.BackColor = System.Drawing.Color.Transparent;
            this.user_name.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_name.Location = new System.Drawing.Point(32, 78);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(114, 31);
            this.user_name.TabIndex = 0;
            this.user_name.Text = "UserName";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.BackColor = System.Drawing.Color.Transparent;
            this.password.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(32, 139);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(108, 31);
            this.password.TabIndex = 1;
            this.password.Text = "Password";
            // 
            // user_box
            // 
            this.user_box.Location = new System.Drawing.Point(193, 86);
            this.user_box.Name = "user_box";
            this.user_box.Size = new System.Drawing.Size(133, 20);
            this.user_box.TabIndex = 2;
            this.user_box.TextChanged += new System.EventHandler(this.txtbox1_TextChanged);
            // 
            // pass_box
            // 
            this.pass_box.Location = new System.Drawing.Point(193, 147);
            this.pass_box.Name = "pass_box";
            this.pass_box.Size = new System.Drawing.Size(133, 20);
            this.pass_box.TabIndex = 3;
            this.pass_box.TextChanged += new System.EventHandler(this.txtbox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(250, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sign";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(520, 371);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pass_box);
            this.Controls.Add(this.user_box);
            this.Controls.Add(this.password);
            this.Controls.Add(this.user_name);
            this.Name = "Form1";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label user_name;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox user_box;
        private System.Windows.Forms.TextBox pass_box;
        private System.Windows.Forms.Button button1;
    }
}

