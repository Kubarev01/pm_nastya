
namespace pm_training
{
    partial class FormReg
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonReg = new System.Windows.Forms.Button();
            this.usernameImput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.passwordInputRepeat = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelPasswordRepeat = new System.Windows.Forms.Label();
            this.labelReg = new System.Windows.Forms.Label();
            this.authButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonReg
            // 
            this.buttonReg.Location = new System.Drawing.Point(348, 283);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(165, 23);
            this.buttonReg.TabIndex = 0;
            this.buttonReg.Text = "Зарегистрироваться";
            this.buttonReg.UseVisualStyleBackColor = true;
            this.buttonReg.Click += new System.EventHandler(this.button1_Click);
            // 
            // usernameImput
            // 
            this.usernameImput.Location = new System.Drawing.Point(348, 148);
            this.usernameImput.Name = "usernameImput";
            this.usernameImput.Size = new System.Drawing.Size(100, 22);
            this.usernameImput.TabIndex = 1;
            this.usernameImput.TextChanged += new System.EventHandler(this.usernameImput_TextChanged);
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(348, 186);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '*';
            this.passwordInput.Size = new System.Drawing.Size(100, 22);
            this.passwordInput.TabIndex = 2;
            // 
            // passwordInputRepeat
            // 
            this.passwordInputRepeat.Location = new System.Drawing.Point(348, 226);
            this.passwordInputRepeat.Name = "passwordInputRepeat";
            this.passwordInputRepeat.PasswordChar = 'х';
            this.passwordInputRepeat.Size = new System.Drawing.Size(100, 22);
            this.passwordInputRepeat.TabIndex = 3;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(261, 148);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(51, 17);
            this.labelLogin.TabIndex = 4;
            this.labelLogin.Text = "Логин ";
            this.labelLogin.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(255, 189);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(57, 17);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Пароль";
            // 
            // labelPasswordRepeat
            // 
            this.labelPasswordRepeat.AutoSize = true;
            this.labelPasswordRepeat.Location = new System.Drawing.Point(187, 226);
            this.labelPasswordRepeat.Name = "labelPasswordRepeat";
            this.labelPasswordRepeat.Size = new System.Drawing.Size(123, 17);
            this.labelPasswordRepeat.TabIndex = 6;
            this.labelPasswordRepeat.Text = "Поворите пароль";
            // 
            // labelReg
            // 
            this.labelReg.AutoSize = true;
            this.labelReg.Location = new System.Drawing.Point(345, 80);
            this.labelReg.Name = "labelReg";
            this.labelReg.Size = new System.Drawing.Size(92, 17);
            this.labelReg.TabIndex = 7;
            this.labelReg.Text = "Регистрация";
            this.labelReg.Click += new System.EventHandler(this.label4_Click);
            // 
            // authButton
            // 
            this.authButton.Location = new System.Drawing.Point(348, 325);
            this.authButton.Name = "authButton";
            this.authButton.Size = new System.Drawing.Size(165, 23);
            this.authButton.TabIndex = 8;
            this.authButton.Text = "Уже есть аккаунт";
            this.authButton.UseVisualStyleBackColor = true;
            this.authButton.Click += new System.EventHandler(this.authButton_Click);
            // 
            // FormReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.authButton);
            this.Controls.Add(this.labelReg);
            this.Controls.Add(this.labelPasswordRepeat);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.passwordInputRepeat);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.usernameImput);
            this.Controls.Add(this.buttonReg);
            this.Name = "FormReg";
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.TextBox usernameImput;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.TextBox passwordInputRepeat;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelPasswordRepeat;
        private System.Windows.Forms.Label labelReg;
        private System.Windows.Forms.Button authButton;
    }
}

