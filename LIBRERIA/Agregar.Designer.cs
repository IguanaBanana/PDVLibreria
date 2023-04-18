namespace LIBRERIA
{
    partial class Agregar
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
            textBoxTituloAgregar = new TextBox();
            label2 = new Label();
            textBoxAutorAgregar = new TextBox();
            label3 = new Label();
            comboBoxCategoriaAgregar = new ComboBox();
            label4 = new Label();
            textBoxPrecioAgregar = new TextBox();
            buttonAgregarAgregar = new Button();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            textBoxISSNAgregar = new TextBox();
            ID = new DataGridViewTextBoxColumn();
            Titulo = new DataGridViewTextBoxColumn();
            ISSN = new DataGridViewTextBoxColumn();
            Autor = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 40);
            label1.Name = "label1";
            label1.Size = new Size(56, 23);
            label1.TabIndex = 1;
            label1.Text = "Titulo";
            // 
            // textBoxTituloAgregar
            // 
            textBoxTituloAgregar.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTituloAgregar.Location = new Point(10, 63);
            textBoxTituloAgregar.Margin = new Padding(3, 2, 3, 2);
            textBoxTituloAgregar.Name = "textBoxTituloAgregar";
            textBoxTituloAgregar.Size = new Size(344, 30);
            textBoxTituloAgregar.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(367, 38);
            label2.Name = "label2";
            label2.Size = new Size(57, 23);
            label2.TabIndex = 5;
            label2.Text = "Autor";
            // 
            // textBoxAutorAgregar
            // 
            textBoxAutorAgregar.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAutorAgregar.Location = new Point(367, 63);
            textBoxAutorAgregar.Margin = new Padding(3, 2, 3, 2);
            textBoxAutorAgregar.Name = "textBoxAutorAgregar";
            textBoxAutorAgregar.Size = new Size(249, 30);
            textBoxAutorAgregar.TabIndex = 6;
            textBoxAutorAgregar.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(629, 37);
            label3.Name = "label3";
            label3.Size = new Size(96, 23);
            label3.TabIndex = 7;
            label3.Text = "Categoria";
            // 
            // comboBoxCategoriaAgregar
            // 
            comboBoxCategoriaAgregar.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxCategoriaAgregar.FormattingEnabled = true;
            comboBoxCategoriaAgregar.Items.AddRange(new object[] { "Terror", "Romance ", "Fantasia" });
            comboBoxCategoriaAgregar.Location = new Point(629, 62);
            comboBoxCategoriaAgregar.Margin = new Padding(3, 2, 3, 2);
            comboBoxCategoriaAgregar.Name = "comboBoxCategoriaAgregar";
            comboBoxCategoriaAgregar.Size = new Size(218, 31);
            comboBoxCategoriaAgregar.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(856, 38);
            label4.Name = "label4";
            label4.Size = new Size(66, 23);
            label4.TabIndex = 9;
            label4.Text = "Precio";
            // 
            // textBoxPrecioAgregar
            // 
            textBoxPrecioAgregar.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPrecioAgregar.Location = new Point(856, 62);
            textBoxPrecioAgregar.Margin = new Padding(3, 2, 3, 2);
            textBoxPrecioAgregar.Name = "textBoxPrecioAgregar";
            textBoxPrecioAgregar.Size = new Size(249, 30);
            textBoxPrecioAgregar.TabIndex = 10;
            // 
            // buttonAgregarAgregar
            // 
            buttonAgregarAgregar.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAgregarAgregar.Location = new Point(1000, 108);
            buttonAgregarAgregar.Margin = new Padding(3, 2, 3, 2);
            buttonAgregarAgregar.Name = "buttonAgregarAgregar";
            buttonAgregarAgregar.Size = new Size(105, 28);
            buttonAgregarAgregar.TabIndex = 11;
            buttonAgregarAgregar.Text = "Agregar";
            buttonAgregarAgregar.UseVisualStyleBackColor = true;
            buttonAgregarAgregar.Click += buttonAgregarAgregar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Titulo, ISSN, Autor, Categoria, Precio });
            dataGridView1.Location = new Point(12, 166);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1110, 359);
            dataGridView1.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(13, 98);
            label5.Name = "label5";
            label5.Size = new Size(55, 23);
            label5.TabIndex = 13;
            label5.Text = "ISSN";
            // 
            // textBoxISSNAgregar
            // 
            textBoxISSNAgregar.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxISSNAgregar.Location = new Point(10, 122);
            textBoxISSNAgregar.Margin = new Padding(3, 2, 3, 2);
            textBoxISSNAgregar.Name = "textBoxISSNAgregar";
            textBoxISSNAgregar.Size = new Size(249, 30);
            textBoxISSNAgregar.TabIndex = 14;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // Titulo
            // 
            Titulo.HeaderText = "Titulo";
            Titulo.Name = "Titulo";
            // 
            // ISSN
            // 
            ISSN.HeaderText = "ISSN";
            ISSN.Name = "ISSN";
            // 
            // Autor
            // 
            Autor.HeaderText = "Autor";
            Autor.Name = "Autor";
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            // 
            // Agregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1134, 536);
            Controls.Add(textBoxISSNAgregar);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(buttonAgregarAgregar);
            Controls.Add(textBoxPrecioAgregar);
            Controls.Add(label4);
            Controls.Add(comboBoxCategoriaAgregar);
            Controls.Add(label3);
            Controls.Add(textBoxAutorAgregar);
            Controls.Add(label2);
            Controls.Add(textBoxTituloAgregar);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Agregar";
            Text = "Agregar";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxTituloAgregar;
        private Label label2;
        private TextBox textBoxAutorAgregar;
        private Label label3;
        private ComboBox comboBoxCategoriaAgregar;
        private Label label4;
        private TextBox textBoxPrecioAgregar;
        private Button buttonAgregarAgregar;
        private DataGridView dataGridView1;
        private Label label5;
        private TextBox textBoxISSNAgregar;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Titulo;
        private DataGridViewTextBoxColumn ISSN;
        private DataGridViewTextBoxColumn Autor;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Precio;
    }
}