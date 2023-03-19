namespace OnlineMovieDownloaderApp.Forms.Login
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button LoginBtn;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.titleHeader = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            LoginBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = System.Drawing.Color.White;
            LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            LoginBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            LoginBtn.FlatAppearance.BorderSize = 10;
            LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            LoginBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LoginBtn.ForeColor = System.Drawing.Color.Black;
            LoginBtn.Location = new System.Drawing.Point(208, 272);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new System.Drawing.Size(113, 31);
            LoginBtn.TabIndex = 19;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(194)))), ((int)(((byte)(193)))), ((int)(((byte)(192)))));
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel.Controls.Add(LoginBtn);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.passwordInput);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.emailInput);
            this.panel.Controls.Add(this.titleHeader);
            this.panel.Controls.Add(this.label3);
            this.panel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.ForeColor = System.Drawing.Color.Red;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Margin = new System.Windows.Forms.Padding(0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(535, 344);
            this.panel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(118, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Password:";
            // 
            // passwordInput
            // 
            this.passwordInput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.passwordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordInput.Location = new System.Drawing.Point(207, 210);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '*';
            this.passwordInput.Size = new System.Drawing.Size(212, 26);
            this.passwordInput.TabIndex = 17;
            this.passwordInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordInput_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(118, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Email:";
            // 
            // emailInput
            // 
            this.emailInput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.emailInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailInput.Location = new System.Drawing.Point(207, 176);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(212, 26);
            this.emailInput.TabIndex = 16;
            this.emailInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.emailInput_KeyDown);
            // 
            // titleHeader
            // 
            this.titleHeader.AutoSize = true;
            this.titleHeader.BackColor = System.Drawing.Color.Transparent;
            this.titleHeader.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleHeader.ForeColor = System.Drawing.Color.Black;
            this.titleHeader.Location = new System.Drawing.Point(204, 108);
            this.titleHeader.Name = "titleHeader";
            this.titleHeader.Size = new System.Drawing.Size(108, 21);
            this.titleHeader.TabIndex = 15;
            this.titleHeader.Text = "Admin Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(47, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(441, 39);
            this.label3.TabIndex = 21;
            this.label3.Text = "Online Movie Downloader App";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(535, 344);
            this.Controls.Add(this.panel);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Login";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.Label titleHeader;
        private System.Windows.Forms.Label label3;
    }
}