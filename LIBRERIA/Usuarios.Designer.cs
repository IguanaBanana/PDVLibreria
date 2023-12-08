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
            textBoxDireccion = new TextBox();
            textBoxCorreoUsuario = new TextBox();
            textBoxNombreUsuario = new TextBox();
            buttonEditarUsuario = new Button();
            buttonAgregarUsuario = new Button();
            buttonEliminarUsuario = new Button();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            label5 = new Label();
            textBoxIDUsuario = new TextBox();
            buttonBuscarUsu = new Button();
            textBoxTelefono = new TextBox();
            textBoxPassUsusario = new TextBox();
            label4 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(246, 44);
            label1.Name = "label1";
            label1.Size = new Size(79, 23);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(57, 109);
            label2.Name = "label2";
            label2.Size = new Size(71, 23);
            label2.TabIndex = 2;
            label2.Text = "Correo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(57, 176);
            label3.Name = "label3";
            label3.Size = new Size(91, 23);
            label3.TabIndex = 3;
            label3.Text = "Direccion";
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.Enabled = false;
            textBoxDireccion.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDireccion.Location = new Point(57, 200);
            textBoxDireccion.Margin = new Padding(3, 2, 3, 2);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(429, 30);
            textBoxDireccion.TabIndex = 8;
            // 
            // textBoxCorreoUsuario
            // 
            textBoxCorreoUsuario.Enabled = false;
            textBoxCorreoUsuario.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCorreoUsuario.Location = new Point(57, 132);
            textBoxCorreoUsuario.Margin = new Padding(3, 2, 3, 2);
            textBoxCorreoUsuario.Name = "textBoxCorreoUsuario";
            textBoxCorreoUsuario.Size = new Size(429, 30);
            textBoxCorreoUsuario.TabIndex = 6;
            // 
            // textBoxNombreUsuario
            // 
            textBoxNombreUsuario.Enabled = false;
            textBoxNombreUsuario.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNombreUsuario.Location = new Point(246, 69);
            textBoxNombreUsuario.Margin = new Padding(3, 2, 3, 2);
            textBoxNombreUsuario.Name = "textBoxNombreUsuario";
            textBoxNombreUsuario.Size = new Size(859, 30);
            textBoxNombreUsuario.TabIndex = 5;
            textBoxNombreUsuario.KeyDown += textBoxNombreUsuario_KeyDown;
            // 
            // buttonEditarUsuario
            // 
            buttonEditarUsuario.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEditarUsuario.Location = new Point(177, 247);
            buttonEditarUsuario.Margin = new Padding(3, 2, 3, 2);
            buttonEditarUsuario.Name = "buttonEditarUsuario";
            buttonEditarUsuario.Size = new Size(105, 28);
            buttonEditarUsuario.TabIndex = 2;
            buttonEditarUsuario.Text = "Editar";
            buttonEditarUsuario.UseVisualStyleBackColor = true;
            buttonEditarUsuario.Click += buttonEditarUsuario_Click;
            // 
            // buttonAgregarUsuario
            // 
            buttonAgregarUsuario.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAgregarUsuario.Location = new Point(298, 247);
            buttonAgregarUsuario.Margin = new Padding(3, 2, 3, 2);
            buttonAgregarUsuario.Name = "buttonAgregarUsuario";
            buttonAgregarUsuario.Size = new Size(105, 28);
            buttonAgregarUsuario.TabIndex = 3;
            buttonAgregarUsuario.Text = "Agregar";
            buttonAgregarUsuario.UseVisualStyleBackColor = true;
            buttonAgregarUsuario.Click += buttonAgregarUsuario_Click;
            // 
            // buttonEliminarUsuario
            // 
            buttonEliminarUsuario.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEliminarUsuario.Location = new Point(999, 247);
            buttonEliminarUsuario.Margin = new Padding(3, 2, 3, 2);
            buttonEliminarUsuario.Name = "buttonEliminarUsuario";
            buttonEliminarUsuario.Size = new Size(105, 28);
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Correo, Telefono, Direccion, Password });
            dataGridView1.Location = new Point(60, 288);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1044, 231);
            dataGridView1.TabIndex = 0;
            dataGridView1.TabStop = false;
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
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Direccion";
            Direccion.Name = "Direccion";
            Direccion.ReadOnly = true;
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
            label5.Location = new Point(60, 44);
            label5.Name = "label5";
            label5.Size = new Size(30, 23);
            label5.TabIndex = 15;
            label5.Text = "ID";
            // 
            // textBoxIDUsuario
            // 
            textBoxIDUsuario.Enabled = false;
            textBoxIDUsuario.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxIDUsuario.Location = new Point(57, 69);
            textBoxIDUsuario.Margin = new Padding(3, 2, 3, 2);
            textBoxIDUsuario.Name = "textBoxIDUsuario";
            textBoxIDUsuario.Size = new Size(159, 30);
            textBoxIDUsuario.TabIndex = 4;
            // 
            // buttonBuscarUsu
            // 
            buttonBuscarUsu.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBuscarUsu.Location = new Point(57, 247);
            buttonBuscarUsu.Margin = new Padding(3, 2, 3, 2);
            buttonBuscarUsu.Name = "buttonBuscarUsu";
            buttonBuscarUsu.Size = new Size(105, 28);
            buttonBuscarUsu.TabIndex = 1;
            buttonBuscarUsu.Text = "Buscar";
            buttonBuscarUsu.UseVisualStyleBackColor = true;
            buttonBuscarUsu.Click += buttonBuscarUsu_Click;
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Enabled = false;
            textBoxTelefono.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTelefono.Location = new Point(524, 132);
            textBoxTelefono.Margin = new Padding(3, 2, 3, 2);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(429, 30);
            textBoxTelefono.TabIndex = 7;
            textBoxTelefono.TextChanged += textBox1_TextChanged;
            // 
            // textBoxPassUsusario
            // 
            textBoxPassUsusario.Enabled = false;
            textBoxPassUsusario.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassUsusario.Location = new Point(524, 200);
            textBoxPassUsusario.Margin = new Padding(3, 2, 3, 2);
            textBoxPassUsusario.Name = "textBoxPassUsusario";
            textBoxPassUsusario.PasswordChar = '*';
            textBoxPassUsusario.Size = new Size(429, 30);
            textBoxPassUsusario.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(524, 176);
            label4.Name = "label4";
            label4.Size = new Size(98, 23);
            label4.TabIndex = 19;
            label4.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(524, 109);
            label6.Name = "label6";
            label6.Size = new Size(84, 23);
            label6.TabIndex = 18;
            label6.Text = "Telefono";
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1134, 536);
            Controls.Add(textBoxTelefono);
            Controls.Add(textBoxPassUsusario);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(buttonBuscarUsu);
            Controls.Add(textBoxIDUsuario);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(buttonEliminarUsuario);
            Controls.Add(buttonAgregarUsuario);
            Controls.Add(buttonEditarUsuario);
            Controls.Add(textBoxNombreUsuario);
            Controls.Add(textBoxCorreoUsuario);
            Controls.Add(textBoxDireccion);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Usuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxDireccion;
        private TextBox textBoxCorreoUsuario;
        private TextBox textBoxNombreUsuario;
        private Button buttonEditarUsuario;
        private Button buttonAgregarUsuario;
        private Button buttonEliminarUsuario;
        private DataGridView dataGridView1;
        private Label label5;
        private TextBox textBoxIDUsuario;
        private Button buttonBuscarUsu;
        private TextBox textBoxTelefono;
        private TextBox textBoxPassUsusario;
        private Label label4;
        private Label label6;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Password;
    }
}