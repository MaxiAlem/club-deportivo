﻿namespace club_deportivo
{
    partial class Form2
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
            btnLogout = new Button();
            dataGridView1 = new DataGridView();
            lblBuscarUsuario = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            btnNuevoUser = new Button();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            textBox4 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            textBox5 = new TextBox();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(647, 415);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(141, 23);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Cerrar Sesión";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += BtnLogout_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 58);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(519, 290);
            dataGridView1.TabIndex = 1;
            // 
            // lblBuscarUsuario
            // 
            lblBuscarUsuario.AutoSize = true;
            lblBuscarUsuario.Location = new Point(28, 28);
            lblBuscarUsuario.Name = "lblBuscarUsuario";
            lblBuscarUsuario.Size = new Size(129, 15);
            lblBuscarUsuario.TabIndex = 2;
            lblBuscarUsuario.Text = "Buscar Usuario por DNI";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(163, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 23);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(419, 28);
            button1.Name = "button1";
            button1.Size = new Size(75, 24);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(394, 28);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 5;
            // 
            // btnNuevoUser
            // 
            btnNuevoUser.Location = new Point(577, 296);
            btnNuevoUser.Name = "btnNuevoUser";
            btnNuevoUser.Size = new Size(182, 67);
            btnNuevoUser.TabIndex = 6;
            btnNuevoUser.Text = "Nuevo User";
            btnNuevoUser.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(565, 39);
            label2.Name = "label2";
            label2.Size = new Size(211, 25);
            label2.TabIndex = 8;
            label2.Text = "CARGAR NUEVO SOCIO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(746, 91);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(581, 92);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(184, 23);
            textBox2.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(581, 74);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 9;
            label4.Text = "Nombre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(744, 140);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 14;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(581, 140);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(184, 23);
            textBox3.TabIndex = 13;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(579, 123);
            label6.Name = "label6";
            label6.Size = new Size(27, 15);
            label6.TabIndex = 12;
            label6.Text = "DNI";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(742, 244);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 20;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(579, 244);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(184, 23);
            textBox4.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(577, 227);
            label8.Name = "label8";
            label8.Size = new Size(27, 15);
            label8.TabIndex = 18;
            label8.Text = "DNI";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(744, 195);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 17;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(579, 196);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(184, 23);
            textBox5.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(579, 178);
            label10.Name = "label10";
            label10.Size = new Size(52, 15);
            label10.TabIndex = 15;
            label10.Text = "Telefono";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(textBox4);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(textBox5);
            Controls.Add(label10);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(btnNuevoUser);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(lblBuscarUsuario);
            Controls.Add(dataGridView1);
            Controls.Add(btnLogout);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogout;
        private DataGridView dataGridView1;
        private Label lblBuscarUsuario;
        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private Button btnNuevoUser;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
        private TextBox textBox3;
        private Label label6;
        private Label label7;
        private TextBox textBox4;
        private Label label8;
        private Label label9;
        private TextBox textBox5;
        private Label label10;
    }
}