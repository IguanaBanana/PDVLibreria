namespace LIBRERIA
{
    partial class Editarcs
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
            dataGridView1 = new DataGridView();
            buttonSeleccionarEditar = new Button();
            label1 = new Label();
            textBoxTituloEditar = new TextBox();
            label2 = new Label();
            textBoxDescEditar = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBoxPrecioEditar = new TextBox();
            buttonEditarEditar = new Button();
            textBoxTituloEditarBuscar = new TextBox();
            label5 = new Label();
            label7 = new Label();
            textBoxIDEditar = new TextBox();
            textBoxCantidadEditar = new TextBox();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Autor = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Descripcion, Autor, Categoria });
            dataGridView1.Location = new Point(21, 72);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1104, 187);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // buttonSeleccionarEditar
            // 
            buttonSeleccionarEditar.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSeleccionarEditar.Location = new Point(713, 36);
            buttonSeleccionarEditar.Margin = new Padding(3, 2, 3, 2);
            buttonSeleccionarEditar.Name = "buttonSeleccionarEditar";
            buttonSeleccionarEditar.Size = new Size(105, 28);
            buttonSeleccionarEditar.TabIndex = 13;
            buttonSeleccionarEditar.Text = "Seleccionar";
            buttonSeleccionarEditar.UseVisualStyleBackColor = true;
            buttonSeleccionarEditar.Click += buttonSeleccionarEditar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(565, 291);
            label1.Name = "label1";
            label1.Size = new Size(79, 23);
            label1.TabIndex = 14;
            label1.Text = "Nombre";
            // 
            // textBoxTituloEditar
            // 
            textBoxTituloEditar.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTituloEditar.Location = new Point(565, 321);
            textBoxTituloEditar.Margin = new Padding(3, 2, 3, 2);
            textBoxTituloEditar.Name = "textBoxTituloEditar";
            textBoxTituloEditar.Size = new Size(529, 30);
            textBoxTituloEditar.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 384);
            label2.Name = "label2";
            label2.Size = new Size(112, 23);
            label2.TabIndex = 16;
            label2.Text = "Descripcion";
            // 
            // textBoxDescEditar
            // 
            textBoxDescEditar.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDescEditar.Location = new Point(21, 409);
            textBoxDescEditar.Margin = new Padding(3, 2, 3, 2);
            textBoxDescEditar.Name = "textBoxDescEditar";
            textBoxDescEditar.Size = new Size(523, 30);
            textBoxDescEditar.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(578, 374);
            label3.Name = "label3";
            label3.Size = new Size(88, 23);
            label3.TabIndex = 18;
            label3.Text = "Cantidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(845, 374);
            label4.Name = "label4";
            label4.Size = new Size(66, 23);
            label4.TabIndex = 20;
            label4.Text = "Precio";
            // 
            // textBoxPrecioEditar
            // 
            textBoxPrecioEditar.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPrecioEditar.Location = new Point(845, 409);
            textBoxPrecioEditar.Margin = new Padding(3, 2, 3, 2);
            textBoxPrecioEditar.Name = "textBoxPrecioEditar";
            textBoxPrecioEditar.Size = new Size(249, 30);
            textBoxPrecioEditar.TabIndex = 21;
            // 
            // buttonEditarEditar
            // 
            buttonEditarEditar.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEditarEditar.Location = new Point(1005, 455);
            buttonEditarEditar.Margin = new Padding(3, 2, 3, 2);
            buttonEditarEditar.Name = "buttonEditarEditar";
            buttonEditarEditar.Size = new Size(105, 28);
            buttonEditarEditar.TabIndex = 22;
            buttonEditarEditar.Text = "Editar";
            buttonEditarEditar.UseVisualStyleBackColor = true;
            buttonEditarEditar.Click += buttonEditarEditar_Click;
            // 
            // textBoxTituloEditarBuscar
            // 
            textBoxTituloEditarBuscar.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTituloEditarBuscar.Location = new Point(106, 36);
            textBoxTituloEditarBuscar.Margin = new Padding(3, 2, 3, 2);
            textBoxTituloEditarBuscar.Name = "textBoxTituloEditarBuscar";
            textBoxTituloEditarBuscar.Size = new Size(577, 30);
            textBoxTituloEditarBuscar.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(21, 39);
            label5.Name = "label5";
            label5.Size = new Size(79, 23);
            label5.TabIndex = 25;
            label5.Text = "Nombre";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(21, 291);
            label7.Name = "label7";
            label7.Size = new Size(30, 23);
            label7.TabIndex = 28;
            label7.Text = "ID";
            // 
            // textBoxIDEditar
            // 
            textBoxIDEditar.Enabled = false;
            textBoxIDEditar.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxIDEditar.Location = new Point(21, 321);
            textBoxIDEditar.Margin = new Padding(3, 2, 3, 2);
            textBoxIDEditar.Name = "textBoxIDEditar";
            textBoxIDEditar.Size = new Size(523, 30);
            textBoxIDEditar.TabIndex = 29;
            // 
            // textBoxCantidadEditar
            // 
            textBoxCantidadEditar.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCantidadEditar.Location = new Point(569, 409);
            textBoxCantidadEditar.Margin = new Padding(3, 2, 3, 2);
            textBoxCantidadEditar.Name = "textBoxCantidadEditar";
            textBoxCantidadEditar.Size = new Size(249, 30);
            textBoxCantidadEditar.TabIndex = 30;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // Autor
            // 
            Autor.HeaderText = "Precio";
            Autor.Name = "Autor";
            Autor.ReadOnly = true;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Cantidad";
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            // 
            // Editarcs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1134, 536);
            Controls.Add(textBoxCantidadEditar);
            Controls.Add(textBoxIDEditar);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(textBoxTituloEditarBuscar);
            Controls.Add(buttonEditarEditar);
            Controls.Add(textBoxPrecioEditar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxDescEditar);
            Controls.Add(label2);
            Controls.Add(textBoxTituloEditar);
            Controls.Add(label1);
            Controls.Add(buttonSeleccionarEditar);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Editarcs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editarcs";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonSeleccionarEditar;
        private Label label1;
        private TextBox textBoxTituloEditar;
        private Label label2;
        private TextBox textBoxDescEditar;
        private Label label3;
        private Label label4;
        private TextBox textBoxPrecioEditar;
        private Button buttonEditarEditar;
        private TextBox textBoxTituloEditarBuscar;
        private Label label5;
        private Label label7;
        private TextBox textBoxIDEditar;
        private TextBox textBoxCantidadEditar;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Autor;
        private DataGridViewTextBoxColumn Categoria;
    }
}