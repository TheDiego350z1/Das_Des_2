namespace DAS_Desafio_1
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEntrar_Login = new System.Windows.Forms.Button();
            this.txtName_Login = new System.Windows.Forms.TextBox();
            this.txtPass_Login = new System.Windows.Forms.TextBox();
            this.lbName_Login = new System.Windows.Forms.Label();
            this.lbPass_login = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEntrar_Login
            // 
            this.btnEntrar_Login.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEntrar_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar_Login.Location = new System.Drawing.Point(374, 367);
            this.btnEntrar_Login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEntrar_Login.Name = "btnEntrar_Login";
            this.btnEntrar_Login.Size = new System.Drawing.Size(169, 41);
            this.btnEntrar_Login.TabIndex = 0;
            this.btnEntrar_Login.Text = "Entrar";
            this.btnEntrar_Login.UseVisualStyleBackColor = false;
            this.btnEntrar_Login.Click += new System.EventHandler(this.btnEntrar_Login_Click);
            // 
            // txtName_Login
            // 
            this.txtName_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName_Login.Location = new System.Drawing.Point(411, 248);
            this.txtName_Login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName_Login.Name = "txtName_Login";
            this.txtName_Login.Size = new System.Drawing.Size(132, 30);
            this.txtName_Login.TabIndex = 1;
            // 
            // txtPass_Login
            // 
            this.txtPass_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass_Login.Location = new System.Drawing.Point(411, 303);
            this.txtPass_Login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPass_Login.Name = "txtPass_Login";
            this.txtPass_Login.PasswordChar = '*';
            this.txtPass_Login.Size = new System.Drawing.Size(132, 30);
            this.txtPass_Login.TabIndex = 2;
            // 
            // lbName_Login
            // 
            this.lbName_Login.AutoSize = true;
            this.lbName_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName_Login.Location = new System.Drawing.Point(201, 251);
            this.lbName_Login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName_Login.Name = "lbName_Login";
            this.lbName_Login.Size = new System.Drawing.Size(177, 25);
            this.lbName_Login.TabIndex = 3;
            this.lbName_Login.Text = "Nombre de usuario";
            // 
            // lbPass_login
            // 
            this.lbPass_login.AutoSize = true;
            this.lbPass_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass_login.Location = new System.Drawing.Point(201, 303);
            this.lbPass_login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPass_login.Name = "lbPass_login";
            this.lbPass_login.Size = new System.Drawing.Size(114, 25);
            this.lbPass_login.TabIndex = 4;
            this.lbPass_login.Text = "Contraseña";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(206, 367);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "INICIAR SESIÓN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DAS_Desafio_1.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(254, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 459);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbPass_login);
            this.Controls.Add(this.lbName_Login);
            this.Controls.Add(this.txtPass_Login);
            this.Controls.Add(this.txtName_Login);
            this.Controls.Add(this.btnEntrar_Login);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEntrar_Login;
        private System.Windows.Forms.TextBox txtName_Login;
        private System.Windows.Forms.TextBox txtPass_Login;
        private System.Windows.Forms.Label lbName_Login;
        private System.Windows.Forms.Label lbPass_login;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}