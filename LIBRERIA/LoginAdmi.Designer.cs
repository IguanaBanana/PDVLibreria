namespace LIBRERIA
{
    partial class LoginAdmi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginAdmi));
            pictureBox1 = new PictureBox();
            LabelPassword = new Label();
            textBoxPasswordLoginAdmi = new TextBox();
            buttonAceptarLoginAdmi = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(222, 23);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(165, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // LabelPassword
            // 
            LabelPassword.AutoSize = true;
            LabelPassword.Font = new Font("Arial", 20F, FontStyle.Regular, GraphicsUnit.Point);
            LabelPassword.Location = new Point(43, 214);
            LabelPassword.Name = "LabelPassword";
            LabelPassword.Size = new Size(132, 32);
            LabelPassword.TabIndex = 3;
            LabelPassword.Text = "Password";
            // 
            // textBoxPasswordLoginAdmi
            // 
            textBoxPasswordLoginAdmi.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPasswordLoginAdmi.Location = new Point(202, 214);
            textBoxPasswordLoginAdmi.Margin = new Padding(3, 2, 3, 2);
            textBoxPasswordLoginAdmi.Name = "textBoxPasswordLoginAdmi";
            textBoxPasswordLoginAdmi.PasswordChar = '*';
            textBoxPasswordLoginAdmi.Size = new Size(292, 30);
            textBoxPasswordLoginAdmi.TabIndex = 5;
            // 
            // buttonAceptarLoginAdmi
            // 
            buttonAceptarLoginAdmi.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAceptarLoginAdmi.Location = new Point(247, 262);
            buttonAceptarLoginAdmi.Margin = new Padding(3, 2, 3, 2);
            buttonAceptarLoginAdmi.Name = "buttonAceptarLoginAdmi";
            buttonAceptarLoginAdmi.Size = new Size(127, 32);
            buttonAceptarLoginAdmi.TabIndex = 6;
            buttonAceptarLoginAdmi.Text = "Aceptar";
            buttonAceptarLoginAdmi.UseVisualStyleBackColor = true;
            buttonAceptarLoginAdmi.Click += buttonAceptarLoginAdmi_Click;
            // 
            // LoginAdmi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(608, 326);
            Controls.Add(buttonAceptarLoginAdmi);
            Controls.Add(textBoxPasswordLoginAdmi);
            Controls.Add(LabelPassword);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginAdmi";
            Text = "LoginAdmi";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label LabelPassword;
        private TextBox textBoxPasswordLoginAdmi;
        private Button buttonAceptarLoginAdmi;
    }
}