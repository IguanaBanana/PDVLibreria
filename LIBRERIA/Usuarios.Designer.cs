namespace LIBRERIA
{
    partial class Usuarios
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxPassUsuario = new TextBox();
            textBoxCorreoUsuario = new TextBox();
            textBoxNombreUsuario = new TextBox();
            buttonEditarUsuario = new Button();
            buttonAgregarUsuario = new Button();
            buttonEliminarUsuario = new Button();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            label5 = new Label();
            textBoxIDUsuario = new TextBox();
            buttonBuscarUsu = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(281, 59);
            label1.Name = "label1";
            label1.Size = new Size(102, 28);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(65, 145);
            label2.Name = "label2";
            label2.Size = new Size(88, 28);
            label2.TabIndex = 2;
            label2.Text = "Correo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(65, 235);
            label3.Name = "label3";
            label3.Size = new Size(124, 28);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // textBoxPassUsuario
            // 
            textBoxPassUsuario.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassUsuario.Location = new Point(65, 267);
            textBoxPassUsuario.Name = "textBoxPassUsuario";
            textBoxPassUsuario.PasswordChar = '*';
            textBoxPassUsuario.Size = new Size(1197, 36);
            textBoxPassUsuario.TabIndex = 4;
            // 
            // textBoxCorreoUsuario
            // 
            textBoxCorreoUsuario.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCorreoUsuario.Location = new Point(65, 176);
            textBoxCorreoUsuario.Name = "textBoxCorreoUsuario";
            textBoxCorreoUsuario.Size = new Size(1197, 36);
            textBoxCorreoUsuario.TabIndex = 5;
            // 
            // textBoxNombreUsuario
            // 
            textBoxNombreUsuario.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNombreUsuario.Location = new Point(281, 92);
            textBoxNombreUsuario.Name = "textBoxNombreUsuario";
            textBoxNombreUsuario.Size = new Size(981, 36);
            textBoxNombreUsuario.TabIndex = 6;
            // 
            // buttonEditarUsuario
            // 
            buttonEditarUsuario.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEditarUsuario.Location = new Point(202, 329);
            buttonEditarUsuario.Name = "buttonEditarUsuario";
            buttonEditarUsuario.Size = new Size(120, 37);
            buttonEditarUsuario.TabIndex = 11;
            buttonEditarUsuario.Text = "Editar";
            buttonEditarUsuario.UseVisualStyleBackColor = true;
            buttonEditarUsuario.Click += buttonEditarUsuario_Click;
            // 
            // buttonAgregarUsuario
            // 
            buttonAgregarUsuario.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAgregarUsuario.Location = new Point(340, 329);
            buttonAgregarUsuario.Name = "buttonAgregarUsuario";
            buttonAgregarUsuario.Size = new Size(120, 37);
            buttonAgregarUsuario.TabIndex = 12;
            buttonAgregarUsuario.Text = "Agregar";
            buttonAgregarUsuario.UseVisualStyleBackColor = true;
            buttonAgregarUsuario.Click += buttonAgregarUsuario_Click;
            // 
            // buttonEliminarUsuario
            // 
            buttonEliminarUsuario.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEliminarUsuario.Location = new Point(1142, 329);
            buttonEliminarUsuario.Name = "buttonEliminarUsuario";
            buttonEliminarUsuario.Size = new Size(120, 37);
            buttonEliminarUsuario.TabIndex = 13;
            buttonEliminarUsuario.Text = "Eliminar";
            buttonEliminarUsuario.UseVisualStyleBackColor = true;
            buttonEliminarUsuario.Click += buttonEliminarUsuario_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Correo, Password });
            dataGridView1.Location = new Point(69, 384);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1193, 308);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.MinimumWidth = 6;
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            // 
            // Password
            // 
            Password.HeaderText = "Password";
            Password.MinimumWidth = 6;
            Password.Name = "Password";
            Password.ReadOnly = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(69, 59);
            label5.Name = "label5";
            label5.Size = new Size(36, 28);
            label5.TabIndex = 15;
            label5.Text = "ID";
            // 
            // textBoxIDUsuario
            // 
            textBoxIDUsuario.Enabled = false;
            textBoxIDUsuario.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxIDUsuario.Location = new Point(65, 92);
            textBoxIDUsuario.Name = "textBoxIDUsuario";
            textBoxIDUsuario.Size = new Size(181, 36);
            textBoxIDUsuario.TabIndex = 16;
            // 
            // buttonBuscarUsu
            // 
            buttonBuscarUsu.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBuscarUsu.Location = new Point(65, 329);
            buttonBuscarUsu.Name = "buttonBuscarUsu";
            buttonBuscarUsu.Size = new Size(120, 37);
            buttonBuscarUsu.TabIndex = 17;
            buttonBuscarUsu.Text = "Buscar";
            buttonBuscarUsu.UseVisualStyleBackColor = true;
            buttonBuscarUsu.Click += buttonBuscarUsu_Click;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1296, 715);
            Controls.Add(buttonBuscarUsu);
            Controls.Add(textBoxIDUsuario);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(buttonEliminarUsuario);
            Controls.Add(buttonAgregarUsuario);
            Controls.Add(buttonEditarUsuario);
            Controls.Add(textBoxNombreUsuario);
            Controls.Add(textBoxCorreoUsuario);
            Controls.Add(textBoxPassUsuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Usuarios";
            Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxPassUsuario;
        private TextBox textBoxCorreoUsuario;
        private TextBox textBoxNombreUsuario;
        private Button buttonEditarUsuario;
        private Button buttonAgregarUsuario;
        private Button buttonEliminarUsuario;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Password;
        private Label label5;
        private TextBox textBoxIDUsuario;
        private Button buttonBuscarUsu;
    }
}