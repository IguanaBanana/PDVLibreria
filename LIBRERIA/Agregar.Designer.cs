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
            ID = new DataGridViewTextBoxColumn();
            Titulo = new DataGridViewTextBoxColumn();
            ISSN = new DataGridViewTextBoxColumn();
            Autor = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            label5 = new Label();
            textBoxISSNAgregar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(14, 53);
            label1.Name = "label1";
            label1.Size = new Size(72, 28);
            label1.TabIndex = 1;
            label1.Text = "Titulo";
            // 
            // textBoxTituloAgregar
            // 
            textBoxTituloAgregar.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTituloAgregar.Location = new Point(11, 84);
            textBoxTituloAgregar.Name = "textBoxTituloAgregar";
            textBoxTituloAgregar.Size = new Size(393, 36);
            textBoxTituloAgregar.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(419, 51);
            label2.Name = "label2";
            label2.Size = new Size(72, 28);
            label2.TabIndex = 5;
            label2.Text = "Autor";
            // 
            // textBoxAutorAgregar
            // 
            textBoxAutorAgregar.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAutorAgregar.Location = new Point(419, 84);
            textBoxAutorAgregar.Name = "textBoxAutorAgregar";
            textBoxAutorAgregar.Size = new Size(284, 36);
            textBoxAutorAgregar.TabIndex = 6;
            textBoxAutorAgregar.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(719, 49);
            label3.Name = "label3";
            label3.Size = new Size(121, 28);
            label3.TabIndex = 7;
            label3.Text = "Categoria";
            // 
            // comboBoxCategoriaAgregar
            // 
            comboBoxCategoriaAgregar.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxCategoriaAgregar.FormattingEnabled = true;
            comboBoxCategoriaAgregar.Items.AddRange(new object[] { "Terror", "Romance ", "Fantasia" });
            comboBoxCategoriaAgregar.Location = new Point(719, 83);
            comboBoxCategoriaAgregar.Name = "comboBoxCategoriaAgregar";
            comboBoxCategoriaAgregar.Size = new Size(249, 36);
            comboBoxCategoriaAgregar.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(978, 51);
            label4.Name = "label4";
            label4.Size = new Size(84, 28);
            label4.TabIndex = 9;
            label4.Text = "Precio";
            // 
            // textBoxPrecioAgregar
            // 
            textBoxPrecioAgregar.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPrecioAgregar.Location = new Point(978, 83);
            textBoxPrecioAgregar.Name = "textBoxPrecioAgregar";
            textBoxPrecioAgregar.Size = new Size(284, 36);
            textBoxPrecioAgregar.TabIndex = 10;
            // 
            // buttonAgregarAgregar
            // 
            buttonAgregarAgregar.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAgregarAgregar.Location = new Point(1143, 144);
            buttonAgregarAgregar.Name = "buttonAgregarAgregar";
            buttonAgregarAgregar.Size = new Size(120, 37);
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
            dataGridView1.Location = new Point(14, 221);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1269, 479);
            dataGridView1.TabIndex = 12;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // Titulo
            // 
            Titulo.HeaderText = "Titulo";
            Titulo.MinimumWidth = 6;
            Titulo.Name = "Titulo";
            // 
            // ISSN
            // 
            ISSN.HeaderText = "ISSN";
            ISSN.MinimumWidth = 6;
            ISSN.Name = "ISSN";
            // 
            // Autor
            // 
            Autor.HeaderText = "Autor";
            Autor.MinimumWidth = 6;
            Autor.Name = "Autor";
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.MinimumWidth = 6;
            Categoria.Name = "Categoria";
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(15, 131);
            label5.Name = "label5";
            label5.Size = new Size(70, 28);
            label5.TabIndex = 13;
            label5.Text = "ISSN";
            // 
            // textBoxISSNAgregar
            // 
            textBoxISSNAgregar.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxISSNAgregar.Location = new Point(11, 163);
            textBoxISSNAgregar.Name = "textBoxISSNAgregar";
            textBoxISSNAgregar.Size = new Size(284, 36);
            textBoxISSNAgregar.TabIndex = 14;
            // 
            // Agregar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1296, 715);
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
            Name = "Agregar";
            StartPosition = FormStartPosition.CenterScreen;
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