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
            textBoxIdAgregar = new TextBox();
            label2 = new Label();
            textBoxNombreAgregar = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBoxPrecioAgregar = new TextBox();
            buttonAgregarAgregar = new Button();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            textBoxCantidadAgregar = new TextBox();
            textBoxDescripcion = new TextBox();
            ID = new DataGridViewTextBoxColumn();
            Titulo = new DataGridViewTextBoxColumn();
            ISSN = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Autor = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 40);
            label1.Name = "label1";
            label1.Size = new Size(30, 23);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // textBoxIdAgregar
            // 
            textBoxIdAgregar.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxIdAgregar.Location = new Point(10, 63);
            textBoxIdAgregar.Margin = new Padding(3, 2, 3, 2);
            textBoxIdAgregar.Name = "textBoxIdAgregar";
            textBoxIdAgregar.Size = new Size(344, 30);
            textBoxIdAgregar.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(367, 38);
            label2.Name = "label2";
            label2.Size = new Size(79, 23);
            label2.TabIndex = 5;
            label2.Text = "Nombre";
            // 
            // textBoxNombreAgregar
            // 
            textBoxNombreAgregar.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNombreAgregar.Location = new Point(367, 63);
            textBoxNombreAgregar.Margin = new Padding(3, 2, 3, 2);
            textBoxNombreAgregar.Name = "textBoxNombreAgregar";
            textBoxNombreAgregar.Size = new Size(249, 30);
            textBoxNombreAgregar.TabIndex = 6;
            textBoxNombreAgregar.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(629, 37);
            label3.Name = "label3";
            label3.Size = new Size(112, 23);
            label3.TabIndex = 7;
            label3.Text = "Descripcion";
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Titulo, ISSN, Precio, Autor });
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
            label5.Size = new Size(88, 23);
            label5.TabIndex = 13;
            label5.Text = "Cantidad";
            // 
            // textBoxCantidadAgregar
            // 
            textBoxCantidadAgregar.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCantidadAgregar.Location = new Point(10, 122);
            textBoxCantidadAgregar.Margin = new Padding(3, 2, 3, 2);
            textBoxCantidadAgregar.Name = "textBoxCantidadAgregar";
            textBoxCantidadAgregar.Size = new Size(249, 30);
            textBoxCantidadAgregar.TabIndex = 14;
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDescripcion.Location = new Point(622, 62);
            textBoxDescripcion.Margin = new Padding(3, 2, 3, 2);
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.Size = new Size(228, 30);
            textBoxDescripcion.TabIndex = 15;
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
            ISSN.HeaderText = "Descripcion";
            ISSN.MinimumWidth = 6;
            ISSN.Name = "ISSN";
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            // 
            // Autor
            // 
            Autor.HeaderText = "Cantidad";
            Autor.MinimumWidth = 6;
            Autor.Name = "Autor";
            // 
            // Agregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1134, 536);
            Controls.Add(textBoxDescripcion);
            Controls.Add(textBoxCantidadAgregar);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(buttonAgregarAgregar);
            Controls.Add(textBoxPrecioAgregar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxNombreAgregar);
            Controls.Add(label2);
            Controls.Add(textBoxIdAgregar);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Agregar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxIdAgregar;
        private Label label2;
        private TextBox textBoxNombreAgregar;
        private Label label3;
        private Label label4;
        private TextBox textBoxPrecioAgregar;
        private Button buttonAgregarAgregar;
        private DataGridView dataGridView1;
        private Label label5;
        private TextBox textBoxCantidadAgregar;
        private TextBox textBoxDescripcion;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Titulo;
        private DataGridViewTextBoxColumn ISSN;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Autor;
    }
}