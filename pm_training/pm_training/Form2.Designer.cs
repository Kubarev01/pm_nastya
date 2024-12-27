
namespace pm_training
{
    partial class FormAuth
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
            this.buttonSignin = new System.Windows.Forms.Button();
            this.labelAuth = new System.Windows.Forms.Label();
            this.labelUsernam = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelPasswordrep = new System.Windows.Forms.Label();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSignin
            // 
            this.buttonSignin.Location = new System.Drawing.Point(367, 261);
            this.buttonSignin.Name = "buttonSignin";
            this.buttonSignin.Size = new System.Drawing.Size(75, 23);
            this.buttonSignin.TabIndex = 0;
            this.buttonSignin.Text = "Войти";
            this.buttonSignin.UseVisualStyleBackColor = true;
            this.buttonSignin.Click += new System.EventHandler(this.buttonSignin_Click);
            // 
            // labelAuth
            // 
            this.labelAuth.AutoSize = true;
            this.labelAuth.Location = new System.Drawing.Point(364, 62);
            this.labelAuth.Name = "labelAuth";
            this.labelAuth.Size = new System.Drawing.Size(94, 17);
            this.labelAuth.TabIndex = 1;
            this.labelAuth.Text = "Авторизация";
            // 
            // labelUsernam
            // 
            this.labelUsernam.AutoSize = true;
            this.labelUsernam.Location = new System.Drawing.Point(224, 119);
            this.labelUsernam.Name = "labelUsernam";
            this.labelUsernam.Size = new System.Drawing.Size(104, 17);
            this.labelUsernam.TabIndex = 2;
            this.labelUsernam.Text = "Введите логин";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(206, 169);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(122, 17);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Введиете пароль";
            // 
            // labelPasswordrep
            // 
            this.labelPasswordrep.AutoSize = true;
            this.labelPasswordrep.Location = new System.Drawing.Point(206, 223);
            this.labelPasswordrep.Name = "labelPasswordrep";
            this.labelPasswordrep.Size = new System.Drawing.Size(0, 17);
            this.labelPasswordrep.TabIndex = 4;
            // 
            // textUsername
            // 
            this.textUsername.Location = new System.Drawing.Point(367, 114);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(100, 22);
            this.textUsername.TabIndex = 5;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(367, 164);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(100, 22);
            this.textPassword.TabIndex = 6;
            // 
            // FormAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.labelPasswordrep);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsernam);
            this.Controls.Add(this.labelAuth);
            this.Controls.Add(this.buttonSignin);
            this.Name = "FormAuth";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSignin;
        private System.Windows.Forms.Label labelAuth;
        private System.Windows.Forms.Label labelUsernam;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelPasswordrep;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.TextBox textPassword;
    }
}