namespace club_deportivo
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
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            label1 = new Label();
            btnNuevoSocio = new Button();
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            label5 = new Label();
            txtApellido = new TextBox();
            lblApellido = new Label();
            label7 = new Label();
            txtTel = new TextBox();
            lblDNI = new Label();
            label9 = new Label();
            txtDNI = new TextBox();
            lblTel = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.BackColor = SystemColors.ButtonFace;
            btnLogout.Location = new Point(647, 415);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(141, 23);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Cerrar Sesión";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += BtnLogout_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 218);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(386, 144);
            dataGridView1.TabIndex = 1;
            // 
            // lblBuscarUsuario
            // 
            lblBuscarUsuario.AutoSize = true;
            lblBuscarUsuario.Location = new Point(78, 38);
            lblBuscarUsuario.Name = "lblBuscarUsuario";
            lblBuscarUsuario.Size = new Size(335, 15);
            lblBuscarUsuario.TabIndex = 2;
            lblBuscarUsuario.Text = "Modificar datos socio, registrarle un pago o generar  un carnet";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(78, 87);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(250, 23);
            txtBuscar.TabIndex = 3;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(334, 69);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 41);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += BtnBuscar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, -1);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 5;
            // 
            // btnNuevoSocio
            // 
            btnNuevoSocio.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNuevoSocio.Location = new Point(43, 313);
            btnNuevoSocio.Name = "btnNuevoSocio";
            btnNuevoSocio.Size = new Size(182, 56);
            btnNuevoSocio.TabIndex = 6;
            btnNuevoSocio.Text = "Agregar Socio";
            btnNuevoSocio.UseVisualStyleBackColor = true;
            btnNuevoSocio.Click += BtnNuevoSocio_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(41, 58);
            label2.Name = "label2";
            label2.Size = new Size(156, 25);
            label2.TabIndex = 8;
            label2.Text = "CARGAR NUEVO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(206, 114);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 11;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(41, 115);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(184, 23);
            txtNombre.TabIndex = 10;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(173, 97);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 9;
            lblNombre.Text = "Nombre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(204, 163);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 14;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(41, 163);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(184, 23);
            txtApellido.TabIndex = 13;
            txtApellido.TextChanged += textBox3_TextChanged;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(174, 145);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 12;
            lblApellido.Text = "Apellido";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(202, 267);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 20;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(39, 267);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(184, 23);
            txtTel.TabIndex = 19;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(195, 201);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(27, 15);
            lblDNI.TabIndex = 18;
            lblDNI.Text = "DNI";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(204, 218);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 17;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(39, 219);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(184, 23);
            txtDNI.TabIndex = 16;
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Location = new Point(173, 249);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(52, 15);
            lblTel.TabIndex = 15;
            lblTel.Text = "Telefono";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(78, 69);
            label11.Name = "label11";
            label11.Size = new Size(129, 15);
            label11.TabIndex = 21;
            label11.Text = "Buscar Usuario por DNI";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(23, 200);
            label12.Name = "label12";
            label12.Size = new Size(229, 15);
            label12.TabIndex = 22;
            label12.Text = "Socios con vencimiento de cuota en el dia";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(5, 9);
            label13.Name = "label13";
            label13.Size = new Size(277, 40);
            label13.TabIndex = 23;
            label13.Text = "DASHBOARD CLUB";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Yellow;
            label4.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(7, 14);
            label4.Name = "label4";
            label4.Size = new Size(151, 20);
            label4.TabIndex = 24;
            label4.Text = "EN CONSTRUCCION";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblBuscarUsuario);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(txtBuscar);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(288, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 381);
            panel1.TabIndex = 25;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(label13);
            Controls.Add(label7);
            Controls.Add(txtTel);
            Controls.Add(lblDNI);
            Controls.Add(label9);
            Controls.Add(txtDNI);
            Controls.Add(lblTel);
            Controls.Add(label5);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(label2);
            Controls.Add(btnNuevoSocio);
            Controls.Add(btnLogout);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogout;
        private DataGridView dataGridView1;
        private Label lblBuscarUsuario;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Label label1;
        private Button btnNuevoSocio;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private Label lblNombre;
        private Label label5;
        private TextBox txtApellido;
        private Label lblApellido;
        private Label label7;
        private TextBox txtTel;
        private Label lblDNI;
        private Label label9;
        private TextBox txtDNI;
        private Label lblTel;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label4;
        private Panel panel1;
    }
}