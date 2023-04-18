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
            ID = new DataGridViewTextBoxColumn();
            Titulo = new DataGridViewTextBoxColumn();
            ISSN = new DataGridViewTextBoxColumn();
            Autor = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            buttonSeleccionarEditar = new Button();
            label1 = new Label();
            textBoxTituloEditar = new TextBox();
            label2 = new Label();
            textBoxAutorEditar = new TextBox();
            label3 = new Label();
            comboBoxCategoriaEditar = new ComboBox();
            label4 = new Label();
            textBoxPrecioEditar = new TextBox();
            buttonEditarEditar = new Button();
            textBoxTituloEditarBuscar = new TextBox();
            label5 = new Label();
            textBoxISSNEditar = new TextBox();
            label6 = new Label();
            label7 = new Label();
            textBoxIDEditar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Titulo, ISSN, Autor, Categoria, Precio });
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
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Titulo
            // 
            Titulo.HeaderText = "Titulo";
            Titulo.Name = "Titulo";
            Titulo.ReadOnly = true;
            // 
            // ISSN
            // 
            ISSN.HeaderText = "ISSN";
            ISSN.Name = "ISSN";
            ISSN.ReadOnly = true;
            // 
            // Autor
            // 
            Autor.HeaderText = "Autor";
            Autor.Name = "Autor";
            Autor.ReadOnly = true;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
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
            label1.Location = new Point(330, 291);
            label1.Name = "label1";
            label1.Size = new Size(56, 23);
            label1.TabIndex = 14;
            label1.Text = "Titulo";
            // 
            // textBoxTituloEditar
            // 
            textBoxTituloEditar.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTituloEditar.Location = new Point(330, 321);
            textBoxTituloEditar.Margin = new Padding(3, 2, 3, 2);
            textBoxTituloEditar.Name = "textBoxTituloEditar";
            textBoxTituloEditar.Size = new Size(382, 30);
            textBoxTituloEditar.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 384);
            label2.Name = "label2";
            label2.Size = new Size(57, 23);
            label2.TabIndex = 16;
            label2.Text = "Autor";
            // 
            // textBoxAutorEditar
            // 
            textBoxAutorEditar.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAutorEditar.Location = new Point(21, 409);
            textBoxAutorEditar.Margin = new Padding(3, 2, 3, 2);
            textBoxAutorEditar.Name = "textBoxAutorEditar";
            textBoxAutorEditar.Size = new Size(486, 30);
            textBoxAutorEditar.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(578, 374);
            label3.Name = "label3";
            label3.Size = new Size(96, 23);
            label3.TabIndex = 18;
            label3.Text = "Categoria";
            // 
            // comboBoxCategoriaEditar
            // 
            comboBoxCategoriaEditar.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxCategoriaEditar.FormattingEnabled = true;
            comboBoxCategoriaEditar.Items.AddRange(new object[] { "Terror", "Romance", "Fantasia" });
            comboBoxCategoriaEditar.Location = new Point(578, 408);
            comboBoxCategoriaEditar.Margin = new Padding(3, 2, 3, 2);
            comboBoxCategoriaEditar.Name = "comboBoxCategoriaEditar";
            comboBoxCategoriaEditar.Size = new Size(218, 31);
            comboBoxCategoriaEditar.TabIndex = 19;
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
            textBoxTituloEditarBuscar.Location = new Point(83, 36);
            textBoxTituloEditarBuscar.Margin = new Padding(3, 2, 3, 2);
            textBoxTituloEditarBuscar.Name = "textBoxTituloEditarBuscar";
            textBoxTituloEditarBuscar.Size = new Size(600, 30);
            textBoxTituloEditarBuscar.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(21, 39);
            label5.Name = "label5";
            label5.Size = new Size(56, 23);
            label5.TabIndex = 25;
            label5.Text = "Titulo";
            // 
            // textBoxISSNEditar
            // 
            textBoxISSNEditar.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxISSNEditar.Location = new Point(750, 321);
            textBoxISSNEditar.Margin = new Padding(3, 2, 3, 2);
            textBoxISSNEditar.Name = "textBoxISSNEditar";
            textBoxISSNEditar.Size = new Size(344, 30);
            textBoxISSNEditar.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(750, 291);
            label6.Name = "label6";
            label6.Size = new Size(55, 23);
            label6.TabIndex = 27;
            label6.Text = "ISSN";
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
            textBoxIDEditar.Size = new Size(249, 30);
            textBoxIDEditar.TabIndex = 29;
            // 
            // Editarcs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1134, 536);
            Controls.Add(textBoxIDEditar);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBoxISSNEditar);
            Controls.Add(label5);
            Controls.Add(textBoxTituloEditarBuscar);
            Controls.Add(buttonEditarEditar);
            Controls.Add(textBoxPrecioEditar);
            Controls.Add(label4);
            Controls.Add(comboBoxCategoriaEditar);
            Controls.Add(label3);
            Controls.Add(textBoxAutorEditar);
            Controls.Add(label2);
            Controls.Add(textBoxTituloEditar);
            Controls.Add(label1);
            Controls.Add(buttonSeleccionarEditar);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Editarcs";
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
        private TextBox textBoxAutorEditar;
        private Label label3;
        private ComboBox comboBoxCategoriaEditar;
        private Label label4;
        private TextBox textBoxPrecioEditar;
        private Button buttonEditarEditar;
        private TextBox textBoxTituloEditarBuscar;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Titulo;
        private DataGridViewTextBoxColumn ISSN;
        private DataGridViewTextBoxColumn Autor;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Precio;
        private Label label5;
        private TextBox textBoxISSNEditar;
        private Label label6;
        private Label label7;
        private TextBox textBoxIDEditar;
    }
}