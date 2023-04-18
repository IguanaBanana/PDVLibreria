namespace LIBRERIA
{
    partial class Consulta
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
            label1 = new Label();
            textBoxTituloConsulta = new TextBox();
            label2 = new Label();
            textBoxAutorConsulta = new TextBox();
            buttonBuscarConsulta = new Button();
            buttonBuscarxAutor = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Titulo, ISSN, Autor, Categoria, Precio });
            dataGridView1.Location = new Point(438, 11);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(693, 502);
            dataGridView1.TabIndex = 0;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(31, 35);
            label1.Name = "label1";
            label1.Size = new Size(56, 23);
            label1.TabIndex = 26;
            label1.Text = "Titulo";
            // 
            // textBoxTituloConsulta
            // 
            textBoxTituloConsulta.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTituloConsulta.Location = new Point(31, 60);
            textBoxTituloConsulta.Margin = new Padding(3, 2, 3, 2);
            textBoxTituloConsulta.Name = "textBoxTituloConsulta";
            textBoxTituloConsulta.Size = new Size(373, 30);
            textBoxTituloConsulta.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(31, 175);
            label2.Name = "label2";
            label2.Size = new Size(57, 23);
            label2.TabIndex = 28;
            label2.Text = "Autor";
            // 
            // textBoxAutorConsulta
            // 
            textBoxAutorConsulta.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAutorConsulta.Location = new Point(31, 209);
            textBoxAutorConsulta.Margin = new Padding(3, 2, 3, 2);
            textBoxAutorConsulta.Name = "textBoxAutorConsulta";
            textBoxAutorConsulta.Size = new Size(373, 30);
            textBoxAutorConsulta.TabIndex = 29;
            // 
            // buttonBuscarConsulta
            // 
            buttonBuscarConsulta.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBuscarConsulta.Location = new Point(299, 104);
            buttonBuscarConsulta.Margin = new Padding(3, 2, 3, 2);
            buttonBuscarConsulta.Name = "buttonBuscarConsulta";
            buttonBuscarConsulta.Size = new Size(105, 28);
            buttonBuscarConsulta.TabIndex = 34;
            buttonBuscarConsulta.Text = "Buscar";
            buttonBuscarConsulta.UseVisualStyleBackColor = true;
            buttonBuscarConsulta.Click += buttonBuscarConsulta_Click;
            // 
            // buttonBuscarxAutor
            // 
            buttonBuscarxAutor.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBuscarxAutor.Location = new Point(299, 258);
            buttonBuscarxAutor.Margin = new Padding(3, 2, 3, 2);
            buttonBuscarxAutor.Name = "buttonBuscarxAutor";
            buttonBuscarxAutor.Size = new Size(105, 28);
            buttonBuscarxAutor.TabIndex = 35;
            buttonBuscarxAutor.Text = "Buscar";
            buttonBuscarxAutor.UseVisualStyleBackColor = true;
            buttonBuscarxAutor.Click += buttonBuscarxAutor_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(250, 485);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(182, 28);
            button1.TabIndex = 36;
            button1.Text = "Mostar Inventario";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Consulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1134, 536);
            Controls.Add(button1);
            Controls.Add(buttonBuscarxAutor);
            Controls.Add(buttonBuscarConsulta);
            Controls.Add(textBoxAutorConsulta);
            Controls.Add(label2);
            Controls.Add(textBoxTituloConsulta);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Consulta";
            Text = "Consulta";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBoxTituloConsulta;
        private Label label2;
        private TextBox textBoxAutorConsulta;
        private Button buttonBuscarConsulta;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Titulo;
        private DataGridViewTextBoxColumn ISSN;
        private DataGridViewTextBoxColumn Autor;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Precio;
        private Button buttonBuscarxAutor;
        private Button button1;
    }
}