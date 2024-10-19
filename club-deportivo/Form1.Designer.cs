namespace club_deportivo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            txtUser = new TextBox();
            txtPass = new TextBox();
            lblUser = new Label();
            lblPass = new Label();
            btnLogin = new Button();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 83);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 207);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(251, 153);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(338, 23);
            txtUser.TabIndex = 1;
            txtUser.Text = "USUARIO";
            txtUser.Enter += txtUser_Enter;
            txtUser.Leave += txtUser_Leave;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(251, 212);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(338, 23);
            txtPass.TabIndex = 2;
            txtPass.Text = "CONTRASEÑA";
            txtPass.Enter += txtPass_Enter;
            txtPass.Leave += txtPass_Leave;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(251, 126);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(47, 15);
            lblUser.TabIndex = 3;
            lblUser.Text = "Usuario";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(251, 194);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(67, 15);
            lblPass.TabIndex = 4;
            lblPass.Text = "Contraseña";
            // 
            // btnLogin
            // 
            btnLogin.AutoEllipsis = true;
            btnLogin.Location = new Point(251, 256);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(338, 34);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Acceder";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(12, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(208, 32);
            lblTitle.TabIndex = 6;
            lblTitle.Text = "CLUB DEPORTIVO";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 338);
            Controls.Add(lblTitle);
            Controls.Add(btnLogin);
            Controls.Add(lblPass);
            Controls.Add(lblUser);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Acceso al  sistema";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtUser;
        private TextBox txtPass;
        private Label lblUser;
        private Label lblPass;
        private Button btnLogin;
        private Label lblTitle;
    }
}
