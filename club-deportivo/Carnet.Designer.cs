namespace club_deportivo
{
    partial class Carnet
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
            lblTitulo = new Label();
            lbl1 = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            label3 = new Label();
            txtVencimiento = new Label();
            lblNombre = new Label();
            lblTel = new Label();
            lblDNI = new Label();
            lblApellido = new Label();
            lblVencimiento = new Label();
            bntPrint = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 86);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(258, 45);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Carnet Asociado";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe MDL2 Assets", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl1.Location = new Point(22, 153);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(68, 21);
            lbl1.TabIndex = 1;
            lbl1.Text = "Nombre:";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Segoe MDL2 Assets", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl2.Location = new Point(22, 194);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(61, 21);
            lbl2.TabIndex = 2;
            lbl2.Text = "Apellido";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Segoe MDL2 Assets", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl3.Location = new Point(22, 236);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(35, 21);
            lbl3.TabIndex = 3;
            lbl3.Text = "DNI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe MDL2 Assets", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(251, 194);
            label3.Name = "label3";
            label3.Size = new Size(68, 21);
            label3.TabIndex = 4;
            label3.Text = "Telefono";
            // 
            // txtVencimiento
            // 
            txtVencimiento.AutoSize = true;
            txtVencimiento.Font = new Font("Segoe MDL2 Assets", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVencimiento.Location = new Point(251, 234);
            txtVencimiento.Name = "txtVencimiento";
            txtVencimiento.Size = new Size(91, 21);
            txtVencimiento.TabIndex = 5;
            txtVencimiento.Text = "Vencimiento";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe MDL2 Assets", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(96, 153);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 21);
            lblNombre.TabIndex = 11;
            lblNombre.Text = "Nombre";
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Font = new Font("Segoe MDL2 Assets", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTel.Location = new Point(350, 194);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(68, 21);
            lblTel.TabIndex = 13;
            lblTel.Text = "Telefono";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Font = new Font("Segoe MDL2 Assets", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDNI.Location = new Point(96, 236);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(85, 21);
            lblDNI.TabIndex = 14;
            lblDNI.Text = "documento";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe MDL2 Assets", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellido.Location = new Point(96, 194);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(61, 21);
            lblApellido.TabIndex = 15;
            lblApellido.Text = "Apellido";
            // 
            // lblVencimiento
            // 
            lblVencimiento.AutoSize = true;
            lblVencimiento.Font = new Font("Segoe MDL2 Assets", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVencimiento.Location = new Point(350, 234);
            lblVencimiento.Name = "lblVencimiento";
            lblVencimiento.Size = new Size(91, 21);
            lblVencimiento.TabIndex = 16;
            lblVencimiento.Text = "Vencimiento";
            // 
            // bntPrint
            // 
            bntPrint.Location = new Point(350, 277);
            bntPrint.Name = "bntPrint";
            bntPrint.Size = new Size(124, 23);
            bntPrint.TabIndex = 17;
            bntPrint.Text = "Imprimir";
            bntPrint.UseVisualStyleBackColor = true;
            bntPrint.Click += bntPrint_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(350, 306);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(124, 23);
            btnClose.TabIndex = 18;
            btnClose.Text = "Cerrar";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += BtnClose_Click;
            // 
            // Carnet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 356);
            Controls.Add(btnClose);
            Controls.Add(bntPrint);
            Controls.Add(lblVencimiento);
            Controls.Add(lblApellido);
            Controls.Add(lblDNI);
            Controls.Add(lblTel);
            Controls.Add(lblNombre);
            Controls.Add(txtVencimiento);
            Controls.Add(label3);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(lblTitulo);
            Name = "Carnet";
            Text = "Carnet";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private Label label3;
        private Label txtVencimiento;
        private TextBox txtTel;
        private TextBox textBox5;
        private Label lblNombre;
        private Label label1;
        private Label lblTel;
        private Label lblDNI;
        private Label lblApellido;
        private Label lblVencimiento;
        private Button bntPrint;
        private Button btnClose;
    }
}