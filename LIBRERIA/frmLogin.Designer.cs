namespace LIBRERIA
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            pictureBox1 = new PictureBox();
            LabelUsuario = new Label();
            LabelPassword = new Label();
            textBoxUsuarioLoginUsu = new TextBox();
            textBoxPasswordLoginUsu = new TextBox();
            buttonAceptarLoginUsu = new Button();
            btnAdmiLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(206, 19);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(165, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LabelUsuario
            // 
            LabelUsuario.AutoSize = true;
            LabelUsuario.Font = new Font("Arial", 20F, FontStyle.Regular, GraphicsUnit.Point);
            LabelUsuario.Location = new Point(46, 218);
            LabelUsuario.Name = "LabelUsuario";
            LabelUsuario.Size = new Size(107, 32);
            LabelUsuario.TabIndex = 1;
            LabelUsuario.Text = "Usuario";
            // 
            // LabelPassword
            // 
            LabelPassword.AutoSize = true;
            LabelPassword.Font = new Font("Arial", 20F, FontStyle.Regular, GraphicsUnit.Point);
            LabelPassword.Location = new Point(46, 284);
            LabelPassword.Name = "LabelPassword";
            LabelPassword.Size = new Size(132, 32);
            LabelPassword.TabIndex = 2;
            LabelPassword.Text = "Password";
            // 
            // textBoxUsuarioLoginUsu
            // 
            textBoxUsuarioLoginUsu.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUsuarioLoginUsu.Location = new Point(206, 221);
            textBoxUsuarioLoginUsu.Margin = new Padding(3, 2, 3, 2);
            textBoxUsuarioLoginUsu.Name = "textBoxUsuarioLoginUsu";
            textBoxUsuarioLoginUsu.Size = new Size(292, 30);
            textBoxUsuarioLoginUsu.TabIndex = 3;
            textBoxUsuarioLoginUsu.TextChanged += textBoxUsuarioLoginUsu_TextChanged;
            // 
            // textBoxPasswordLoginUsu
            // 
            textBoxPasswordLoginUsu.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPasswordLoginUsu.Location = new Point(206, 284);
            textBoxPasswordLoginUsu.Margin = new Padding(3, 2, 3, 2);
            textBoxPasswordLoginUsu.Name = "textBoxPasswordLoginUsu";
            textBoxPasswordLoginUsu.PasswordChar = '*';
            textBoxPasswordLoginUsu.Size = new Size(292, 30);
            textBoxPasswordLoginUsu.TabIndex = 4;
            // 
            // buttonAceptarLoginUsu
            // 
            buttonAceptarLoginUsu.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAceptarLoginUsu.Location = new Point(223, 332);
            buttonAceptarLoginUsu.Margin = new Padding(3, 2, 3, 2);
            buttonAceptarLoginUsu.Name = "buttonAceptarLoginUsu";
            buttonAceptarLoginUsu.Size = new Size(127, 32);
            buttonAceptarLoginUsu.TabIndex = 5;
            buttonAceptarLoginUsu.Text = "Aceptar";
            buttonAceptarLoginUsu.UseVisualStyleBackColor = true;
            buttonAceptarLoginUsu.Click += buttonAceptarLoginUsu_Click;
            // 
            // btnAdmiLogin
            // 
            btnAdmiLogin.BackColor = Color.SteelBlue;
            btnAdmiLogin.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdmiLogin.Location = new Point(223, 384);
            btnAdmiLogin.Margin = new Padding(3, 2, 3, 2);
            btnAdmiLogin.Name = "btnAdmiLogin";
            btnAdmiLogin.Size = new Size(127, 32);
            btnAdmiLogin.TabIndex = 6;
            btnAdmiLogin.Text = "Administrador";
            btnAdmiLogin.UseVisualStyleBackColor = false;
            btnAdmiLogin.Click += btnAdmiLogin_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(584, 427);
            Controls.Add(btnAdmiLogin);
            Controls.Add(buttonAceptarLoginUsu);
            Controls.Add(textBoxPasswordLoginUsu);
            Controls.Add(textBoxUsuarioLoginUsu);
            Controls.Add(LabelPassword);
            Controls.Add(LabelUsuario);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmLogin";
            Text = "Usuario";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label LabelUsuario;
        private Label LabelPassword;
        private TextBox textBoxUsuarioLoginUsu;
        private TextBox textBoxPasswordLoginUsu;
        private Button buttonAceptarLoginUsu;
        private Button btnAdmiLogin;
    }
}