namespace LinQTesting
{
    partial class frmLogin
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
            this.b_Login = new System.Windows.Forms.Button();
            this.t_UserName = new System.Windows.Forms.TextBox();
            this.t_Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.b_Connect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_Login
            // 
            this.b_Login.Enabled = false;
            this.b_Login.Location = new System.Drawing.Point(472, 259);
            this.b_Login.Name = "b_Login";
            this.b_Login.Size = new System.Drawing.Size(111, 68);
            this.b_Login.TabIndex = 0;
            this.b_Login.Text = "Login";
            this.b_Login.UseVisualStyleBackColor = true;
            this.b_Login.Click += new System.EventHandler(this.b_Login_Click);
            // 
            // t_UserName
            // 
            this.t_UserName.Location = new System.Drawing.Point(315, 161);
            this.t_UserName.Name = "t_UserName";
            this.t_UserName.Size = new System.Drawing.Size(268, 22);
            this.t_UserName.TabIndex = 1;
            // 
            // t_Password
            // 
            this.t_Password.Location = new System.Drawing.Point(315, 203);
            this.t_Password.Name = "t_Password";
            this.t_Password.Size = new System.Drawing.Size(268, 22);
            this.t_Password.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // b_Connect
            // 
            this.b_Connect.Location = new System.Drawing.Point(315, 259);
            this.b_Connect.Name = "b_Connect";
            this.b_Connect.Size = new System.Drawing.Size(107, 68);
            this.b_Connect.TabIndex = 5;
            this.b_Connect.Text = "Connect";
            this.b_Connect.UseVisualStyleBackColor = true;
            this.b_Connect.Click += new System.EventHandler(this.b_Connect_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.b_Connect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.t_Password);
            this.Controls.Add(this.t_UserName);
            this.Controls.Add(this.b_Login);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_Login;
        private System.Windows.Forms.TextBox t_UserName;
        private System.Windows.Forms.TextBox t_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button b_Connect;
    }
}

