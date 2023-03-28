namespace Tarea_4
{
    partial class formPaginaPrincipal
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

        public void listarUsuario(int position, string nombre, string telefono, string correo)
        {
            int Ypos = 33 + (64 * position);

            GroupBox groupBox = new GroupBox();
            Label lblNombre = new Label();
            Label lblNumber = new Label();
            Label lblMail = new Label();

            groupBox.SuspendLayout();
            SuspendLayout();
            groupBox.Location = new Point(12, Ypos);
            groupBox.Name = "groupBox" + Convert.ToString(position);
            groupBox.Size = new Size(524, 58);
            groupBox.AutoSize = true;
            groupBox.Padding = new Padding(0);
            groupBox.Controls.Add(lblNombre);
            groupBox.Controls.Add(lblNumber);
            groupBox.Controls.Add(lblMail);

            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(17, 19);
            lblNombre.Name = "lblNombre" + Convert.ToString(position);
            lblNombre.Size = new Size(66, 21);
            lblNombre.Text = nombre;

            lblNumber.AutoSize = true;
            lblNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumber.Location = new Point(163, 19);
            lblNumber.Name = "lblNumer" + Convert.ToString(position);
            lblNumber.Size = new Size(100, 21);
            lblNumber.Text = telefono;

            lblMail.AutoSize = true;
            lblMail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMail.Location = new Point(336, 19);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(168, 21);
            lblMail.Text = correo;

            Controls.Add(groupBox);

            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ResumeLayout(false);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNombre = new Label();
            lblTelefono = new Label();
            lblCorreo = new Label();
            boxSample = new GroupBox();
            lblSampleMail = new Label();
            lblSampleNumber = new Label();
            lblSampleNombre = new Label();
            button1 = new Button();
            boxSample.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(29, 9);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(73, 21);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTelefono.Location = new Point(189, 9);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(77, 21);
            lblTelefono.TabIndex = 1;
            lblTelefono.Text = "Teléfono";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCorreo.Location = new Point(402, 9);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(61, 21);
            lblCorreo.TabIndex = 2;
            lblCorreo.Text = "Correo";
            // 
            // boxSample
            // 
            boxSample.Controls.Add(lblSampleMail);
            boxSample.Controls.Add(lblSampleNumber);
            boxSample.Controls.Add(lblSampleNombre);
            boxSample.Location = new Point(12, 33);
            boxSample.Name = "boxSample";
            boxSample.Size = new Size(524, 58);
            boxSample.TabIndex = 3;
            boxSample.TabStop = false;
            // 
            // lblSampleMail
            // 
            lblSampleMail.AutoSize = true;
            lblSampleMail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSampleMail.Location = new Point(336, 19);
            lblSampleMail.Name = "lblSampleMail";
            lblSampleMail.Size = new Size(168, 21);
            lblSampleMail.TabIndex = 6;
            lblSampleMail.Text = "20220947@itla.edu.do";
            // 
            // lblSampleNumber
            // 
            lblSampleNumber.AutoSize = true;
            lblSampleNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSampleNumber.Location = new Point(163, 19);
            lblSampleNumber.Name = "lblSampleNumber";
            lblSampleNumber.Size = new Size(100, 21);
            lblSampleNumber.TabIndex = 5;
            lblSampleNumber.Text = "1234567890";
            // 
            // lblSampleNombre
            // 
            lblSampleNombre.AutoSize = true;
            lblSampleNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSampleNombre.Location = new Point(17, 19);
            lblSampleNombre.Name = "lblSampleNombre";
            lblSampleNombre.Size = new Size(66, 21);
            lblSampleNombre.TabIndex = 4;
            lblSampleNombre.Text = "Fulanito";
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(556, 33);
            button1.Name = "button1";
            button1.Size = new Size(110, 58);
            button1.TabIndex = 4;
            button1.Text = "Cerrar Sesión";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // formPaginaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(678, 393);
            Controls.Add(button1);
            Controls.Add(boxSample);
            Controls.Add(lblCorreo);
            Controls.Add(lblTelefono);
            Controls.Add(lblNombre);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "formPaginaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formPaginaPrincipal";
            FormClosing += formPaginaPrincipalClosing;
            boxSample.ResumeLayout(false);
            boxSample.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblTelefono;
        private Label lblCorreo;
        private GroupBox boxSample; // old 12, 33 new 12, 97 || 64
        private Label lblSampleMail; // 336, 19
        private Label lblSampleNumber; // 163, 19 
        private Label lblSampleNombre; // 17, 19 
        private Button button1;
    }
}