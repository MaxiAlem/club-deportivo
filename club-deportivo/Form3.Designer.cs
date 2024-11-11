namespace club_deportivo
{
    partial class Form3
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
            lbltitle = new Label();
            txtDNI = new TextBox();
            lblDNI = new Label();
            txtTel = new TextBox();
            lblTel = new Label();
            txtApellido = new TextBox();
            lblApellido = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            btnGuardar = new Button();
            btnRegistrarPago = new Button();
            label2 = new Label();
            button3 = new Button();
            cmbTPago = new ComboBox();
            label11 = new Label();
            label12 = new Label();
            txtValorPago = new TextBox();
            label4 = new Label();
            label6 = new Label();
            cmbPagode = new ComboBox();
            txtFechaVencimiento = new TextBox();
            lblFechaVencimiento = new Label();
            SuspendLayout();
            // 
            // lbltitle
            // 
            lbltitle.AutoSize = true;
            lbltitle.Location = new Point(9, 43);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(115, 15);
            lbltitle.TabIndex = 0;
            lbltitle.Text = "DATOS PERSONALES";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(64, 191);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(147, 23);
            txtDNI.TabIndex = 31;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(33, 199);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(27, 15);
            lblDNI.TabIndex = 30;
            lblDNI.Text = "DNI";
            // 
            // txtTel
            // 
            txtTel.Location = new Point(64, 151);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(147, 23);
            txtTel.TabIndex = 28;
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Location = new Point(8, 159);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(52, 15);
            lblTel.TabIndex = 27;
            lblTel.Text = "Telefono";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(64, 113);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(147, 23);
            txtApellido.TabIndex = 25;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(9, 121);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 24;
            lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(64, 73);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(147, 23);
            txtNombre.TabIndex = 22;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(9, 81);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 21;
            lblNombre.Text = "Nombre";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(173, 267);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(186, 44);
            btnGuardar.TabIndex = 33;
            btnGuardar.Text = "Guardar Cambios";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarPago
            // 
            btnRegistrarPago.Location = new Point(451, 179);
            btnRegistrarPago.Name = "btnRegistrarPago";
            btnRegistrarPago.Size = new Size(186, 44);
            btnRegistrarPago.TabIndex = 34;
            btnRegistrarPago.Text = "Registar Pago";
            btnRegistrarPago.UseVisualStyleBackColor = true;
            btnRegistrarPago.Click += BtnRegistrarPago_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(267, 43);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 35;
            label2.Text = "Actividades";
            // 
            // button3
            // 
            button3.Location = new Point(451, 267);
            button3.Name = "button3";
            button3.Size = new Size(186, 44);
            button3.TabIndex = 36;
            button3.Text = "Ver Carnet";
            button3.UseVisualStyleBackColor = true;
            // 
            // cmbTPago
            // 
            cmbTPago.FormattingEnabled = true;
            cmbTPago.Location = new Point(516, 78);
            cmbTPago.Name = "cmbTPago";
            cmbTPago.Size = new Size(121, 23);
            cmbTPago.TabIndex = 37;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(451, 46);
            label11.Name = "label11";
            label11.Size = new Size(119, 15);
            label11.TabIndex = 38;
            label11.Text = "REGISTRAR UN PAGO";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(434, 86);
            label12.Name = "label12";
            label12.Size = new Size(76, 15);
            label12.TabIndex = 39;
            label12.Text = "Tipo de pago";
            // 
            // txtValorPago
            // 
            txtValorPago.Location = new Point(516, 136);
            txtValorPago.Name = "txtValorPago";
            txtValorPago.Size = new Size(121, 23);
            txtValorPago.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(458, 144);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 41;
            label4.Text = "Monto $";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(415, 104);
            label6.Name = "label6";
            label6.Size = new Size(95, 15);
            label6.TabIndex = 42;
            label6.Text = "En concepto de :";
            // 
            // cmbPagode
            // 
            cmbPagode.FormattingEnabled = true;
            cmbPagode.Location = new Point(516, 104);
            cmbPagode.Name = "cmbPagode";
            cmbPagode.Size = new Size(121, 23);
            cmbPagode.TabIndex = 43;
            // 
            // txtFechaVencimiento
            // 
            txtFechaVencimiento.Location = new Point(122, 226);
            txtFechaVencimiento.Name = "txtFechaVencimiento";
            txtFechaVencimiento.ReadOnly = true;
            txtFechaVencimiento.Size = new Size(147, 23);
            txtFechaVencimiento.TabIndex = 44;
            // 
            // lblFechaVencimiento
            // 
            lblFechaVencimiento.AutoSize = true;
            lblFechaVencimiento.Location = new Point(9, 229);
            lblFechaVencimiento.Name = "lblFechaVencimiento";
            lblFechaVencimiento.Size = new Size(107, 15);
            lblFechaVencimiento.TabIndex = 45;
            lblFechaVencimiento.Text = "Fecha Vencimiento";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(680, 336);
            Controls.Add(lblFechaVencimiento);
            Controls.Add(txtFechaVencimiento);
            Controls.Add(cmbPagode);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(txtValorPago);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(cmbTPago);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(btnRegistrarPago);
            Controls.Add(btnGuardar);
            Controls.Add(txtDNI);
            Controls.Add(lblDNI);
            Controls.Add(txtTel);
            Controls.Add(lblTel);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(lbltitle);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltitle;
        private TextBox txtDNI;
        private Label lblDNI;
        private TextBox txtTel;
        private Label lblTel;
        private TextBox txtApellido;
        private Label lblApellido;
        private TextBox txtNombre;
        private Label lblNombre;
        private Button btnGuardar;
        private Button btnRegistrarPago;
        private Label label2;
        private Button button3;
        private ComboBox cmbTPago;
        private Label label11;
        private Label label12;
        private TextBox txtValorPago;
        private Label label4;
        private Label label6;
        private ComboBox cmbPagode;
        private TextBox txtFechaVencimiento;
        private Label lblFechaVencimiento;
    }
}