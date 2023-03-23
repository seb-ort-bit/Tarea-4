namespace Tarea_4
{
    partial class formRegister
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
            lblConstraseña = new Label();
            lblUsuario = new Label();
            linkRegistrate = new LinkLabel();
            lblCuenta = new Label();
            btnEntrar = new Button();
            lblLogin = new Label();
            txtLoginContraseña = new TextBox();
            txtLoginUsuario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            lblWarningRegistro = new Label();
            SuspendLayout();
            // 
            // lblConstraseña
            // 
            lblConstraseña.AutoSize = true;
            lblConstraseña.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblConstraseña.Location = new Point(42, 122);
            lblConstraseña.Name = "lblConstraseña";
            lblConstraseña.Size = new Size(58, 19);
            lblConstraseña.TabIndex = 15;
            lblConstraseña.Text = "Apellido";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.Location = new Point(42, 60);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 19);
            lblUsuario.TabIndex = 14;
            lblUsuario.Text = "Nombre";
            // 
            // linkRegistrate
            // 
            linkRegistrate.AutoSize = true;
            linkRegistrate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkRegistrate.Location = new Point(192, 364);
            linkRegistrate.Name = "linkRegistrate";
            linkRegistrate.Size = new Size(61, 21);
            linkRegistrate.TabIndex = 13;
            linkRegistrate.TabStop = true;
            linkRegistrate.Text = "Ingresa";
            // 
            // lblCuenta
            // 
            lblCuenta.AutoSize = true;
            lblCuenta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCuenta.Location = new Point(29, 364);
            lblCuenta.Name = "lblCuenta";
            lblCuenta.Size = new Size(165, 21);
            lblCuenta.TabIndex = 12;
            lblCuenta.Text = "¿Ya tienes una cuenta?";
            // 
            // btnEntrar
            // 
            btnEntrar.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnEntrar.Location = new Point(40, 327);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(210, 34);
            btnEntrar.TabIndex = 11;
            btnEntrar.Text = "Registrar";
            btnEntrar.UseVisualStyleBackColor = true;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogin.Location = new Point(71, 9);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(147, 47);
            lblLogin.TabIndex = 10;
            lblLogin.Text = "Registro";
            // 
            // txtLoginContraseña
            // 
            txtLoginContraseña.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLoginContraseña.Location = new Point(40, 144);
            txtLoginContraseña.Name = "txtLoginContraseña";
            txtLoginContraseña.Size = new Size(210, 26);
            txtLoginContraseña.TabIndex = 9;
            // 
            // txtLoginUsuario
            // 
            txtLoginUsuario.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLoginUsuario.Location = new Point(40, 85);
            txtLoginUsuario.Name = "txtLoginUsuario";
            txtLoginUsuario.Size = new Size(210, 26);
            txtLoginUsuario.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(42, 240);
            label1.Name = "label1";
            label1.Size = new Size(79, 19);
            label1.TabIndex = 19;
            label1.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(42, 178);
            label2.Name = "label2";
            label2.Size = new Size(129, 19);
            label2.TabIndex = 18;
            label2.Text = "Nombre de Usuario";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(40, 262);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(210, 26);
            textBox1.TabIndex = 17;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(40, 203);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(210, 26);
            textBox2.TabIndex = 16;
            // 
            // lblWarningRegistro
            // 
            lblWarningRegistro.AutoSize = true;
            lblWarningRegistro.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblWarningRegistro.ForeColor = Color.Crimson;
            lblWarningRegistro.Location = new Point(42, 300);
            lblWarningRegistro.Name = "lblWarningRegistro";
            lblWarningRegistro.Size = new Size(221, 20);
            lblWarningRegistro.TabIndex = 20;
            lblWarningRegistro.Text = "Hay campos obligatorios vacíos";
            lblWarningRegistro.Visible = false;
            // 
            // formRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 398);
            Controls.Add(lblWarningRegistro);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(lblConstraseña);
            Controls.Add(lblUsuario);
            Controls.Add(linkRegistrate);
            Controls.Add(lblCuenta);
            Controls.Add(btnEntrar);
            Controls.Add(lblLogin);
            Controls.Add(txtLoginContraseña);
            Controls.Add(txtLoginUsuario);
            Name = "formRegister";
            Text = "Registrarse";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblConstraseña;
        private Label lblUsuario;
        private LinkLabel linkRegistrate;
        private Label lblCuenta;
        private Button btnEntrar;
        private Label lblLogin;
        private TextBox txtLoginContraseña;
        private TextBox txtLoginUsuario;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label lblWarningRegistro;
    }
}