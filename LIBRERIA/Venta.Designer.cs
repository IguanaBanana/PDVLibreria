namespace LIBRERIA
{
    partial class Venta
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            textBoxTituloVenta = new TextBox();
            label4 = new Label();
            label5 = new Label();
            dataGridLista = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridVenta = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Titulo = new DataGridViewTextBoxColumn();
            ISSN = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cant = new DataGridViewTextBoxColumn();
            buttonAgregarVenta = new Button();
            textBoxSubVenta = new TextBox();
            textBoxTotalVenta = new TextBox();
            label6 = new Label();
            label7 = new Label();
            buttonPagarVenta = new Button();
            label8 = new Label();
            textBoxEfectivoVenta = new TextBox();
            productoBindingSource = new BindingSource(components);
            label3 = new Label();
            numericCantVentas = new NumericUpDown();
            label2 = new Label();
            buttonBuscVenta = new Button();
            buttonSalirVenta = new Button();
            textBoxIVA = new TextBox();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridLista).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericCantVentas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(43, 12);
            label1.Name = "label1";
            label1.Size = new Size(72, 28);
            label1.TabIndex = 0;
            label1.Text = "Titulo";
            // 
            // textBoxTituloVenta
            // 
            textBoxTituloVenta.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTituloVenta.Location = new Point(43, 45);
            textBoxTituloVenta.Name = "textBoxTituloVenta";
            textBoxTituloVenta.Size = new Size(491, 36);
            textBoxTituloVenta.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(597, 37);
            label4.Name = "label4";
            label4.Size = new Size(77, 28);
            label4.TabIndex = 6;
            label4.Text = "Venta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(43, 115);
            label5.Name = "label5";
            label5.Size = new Size(177, 28);
            label5.TabIndex = 7;
            label5.Text = "Lista de Libros";
            // 
            // dataGridLista
            // 
            dataGridLista.AllowUserToAddRows = false;
            dataGridLista.AllowUserToDeleteRows = false;
            dataGridLista.AllowUserToOrderColumns = true;
            dataGridLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridLista.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridLista.Location = new Point(43, 147);
            dataGridLista.Name = "dataGridLista";
            dataGridLista.ReadOnly = true;
            dataGridLista.RowHeadersWidth = 51;
            dataGridLista.RowTemplate.Height = 29;
            dataGridLista.Size = new Size(491, 365);
            dataGridLista.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Titulo";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "ISSN";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Precio";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridVenta
            // 
            dataGridVenta.AllowUserToDeleteRows = false;
            dataGridVenta.AllowUserToOrderColumns = true;
            dataGridVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridVenta.Columns.AddRange(new DataGridViewColumn[] { ID, Titulo, ISSN, Precio, Cant });
            dataGridVenta.Location = new Point(597, 71);
            dataGridVenta.Name = "dataGridVenta";
            dataGridVenta.ReadOnly = true;
            dataGridVenta.RowHeadersWidth = 51;
            dataGridVenta.RowTemplate.Height = 29;
            dataGridVenta.Size = new Size(666, 332);
            dataGridVenta.TabIndex = 9;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Titulo
            // 
            Titulo.HeaderText = "Titulo";
            Titulo.MinimumWidth = 6;
            Titulo.Name = "Titulo";
            Titulo.ReadOnly = true;
            // 
            // ISSN
            // 
            ISSN.HeaderText = "ISSN";
            ISSN.MinimumWidth = 6;
            ISSN.Name = "ISSN";
            ISSN.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Cant
            // 
            Cant.HeaderText = "Cant";
            Cant.MinimumWidth = 6;
            Cant.Name = "Cant";
            Cant.ReadOnly = true;
            // 
            // buttonAgregarVenta
            // 
            buttonAgregarVenta.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAgregarVenta.Location = new Point(415, 567);
            buttonAgregarVenta.Name = "buttonAgregarVenta";
            buttonAgregarVenta.Size = new Size(120, 37);
            buttonAgregarVenta.TabIndex = 10;
            buttonAgregarVenta.Text = "Agregar";
            buttonAgregarVenta.UseVisualStyleBackColor = true;
            buttonAgregarVenta.Click += buttonAgregarVenta_Click;
            // 
            // textBoxSubVenta
            // 
            textBoxSubVenta.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSubVenta.Location = new Point(1126, 429);
            textBoxSubVenta.Name = "textBoxSubVenta";
            textBoxSubVenta.Size = new Size(137, 36);
            textBoxSubVenta.TabIndex = 11;
            textBoxSubVenta.TextAlign = HorizontalAlignment.Right;
            // 
            // textBoxTotalVenta
            // 
            textBoxTotalVenta.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTotalVenta.Location = new Point(1126, 515);
            textBoxTotalVenta.Name = "textBoxTotalVenta";
            textBoxTotalVenta.Size = new Size(137, 36);
            textBoxTotalVenta.TabIndex = 12;
            textBoxTotalVenta.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(1058, 518);
            label6.Name = "label6";
            label6.Size = new Size(64, 28);
            label6.TabIndex = 13;
            label6.Text = "Total";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(1013, 432);
            label7.Name = "label7";
            label7.Size = new Size(109, 28);
            label7.TabIndex = 14;
            label7.Text = "SubTotal";
            // 
            // buttonPagarVenta
            // 
            buttonPagarVenta.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPagarVenta.Location = new Point(1143, 567);
            buttonPagarVenta.Name = "buttonPagarVenta";
            buttonPagarVenta.Size = new Size(120, 37);
            buttonPagarVenta.TabIndex = 15;
            buttonPagarVenta.Text = "Pagar";
            buttonPagarVenta.UseVisualStyleBackColor = true;
            buttonPagarVenta.Click += buttonPagarVenta_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(717, 441);
            label8.Name = "label8";
            label8.Size = new Size(101, 28);
            label8.TabIndex = 16;
            label8.Text = "Efectivo";
            // 
            // textBoxEfectivoVenta
            // 
            textBoxEfectivoVenta.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEfectivoVenta.Location = new Point(717, 472);
            textBoxEfectivoVenta.Name = "textBoxEfectivoVenta";
            textBoxEfectivoVenta.Size = new Size(137, 36);
            textBoxEfectivoVenta.TabIndex = 17;
            textBoxEfectivoVenta.TextAlign = HorizontalAlignment.Right;
            // 
            // productoBindingSource
            // 
            productoBindingSource.DataSource = typeof(Middle_Abarrotes_PDV.Producto);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(232, 28);
            label3.Name = "label3";
            label3.Size = new Size(0, 28);
            label3.TabIndex = 2;
            // 
            // numericCantVentas
            // 
            numericCantVentas.Font = new Font("Arial Narrow", 15F, FontStyle.Regular, GraphicsUnit.Point);
            numericCantVentas.Location = new Point(414, 520);
            numericCantVentas.Margin = new Padding(3, 4, 3, 4);
            numericCantVentas.Name = "numericCantVentas";
            numericCantVentas.Size = new Size(121, 36);
            numericCantVentas.TabIndex = 22;
            numericCantVentas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(349, 523);
            label2.Name = "label2";
            label2.Size = new Size(65, 28);
            label2.TabIndex = 23;
            label2.Text = "Cant";
            // 
            // buttonBuscVenta
            // 
            buttonBuscVenta.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBuscVenta.Location = new Point(415, 91);
            buttonBuscVenta.Name = "buttonBuscVenta";
            buttonBuscVenta.Size = new Size(120, 37);
            buttonBuscVenta.TabIndex = 24;
            buttonBuscVenta.Text = "Buscar";
            buttonBuscVenta.UseVisualStyleBackColor = true;
            buttonBuscVenta.Click += buttonBuscVenta_Click;
            // 
            // buttonSalirVenta
            // 
            buttonSalirVenta.BackColor = Color.IndianRed;
            buttonSalirVenta.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSalirVenta.Location = new Point(1193, 669);
            buttonSalirVenta.Name = "buttonSalirVenta";
            buttonSalirVenta.Size = new Size(71, 37);
            buttonSalirVenta.TabIndex = 25;
            buttonSalirVenta.Text = "Salir";
            buttonSalirVenta.UseVisualStyleBackColor = false;
            buttonSalirVenta.Click += buttonSalirVenta_Click;
            // 
            // textBoxIVA
            // 
            textBoxIVA.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxIVA.Location = new Point(1126, 471);
            textBoxIVA.Name = "textBoxIVA";
            textBoxIVA.Size = new Size(137, 36);
            textBoxIVA.TabIndex = 26;
            textBoxIVA.TextAlign = HorizontalAlignment.Right;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(1072, 474);
            label9.Name = "label9";
            label9.Size = new Size(50, 28);
            label9.TabIndex = 27;
            label9.Text = "IVA";
            // 
            // Venta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1275, 721);
            Controls.Add(label9);
            Controls.Add(textBoxIVA);
            Controls.Add(buttonSalirVenta);
            Controls.Add(buttonBuscVenta);
            Controls.Add(label2);
            Controls.Add(numericCantVentas);
            Controls.Add(textBoxEfectivoVenta);
            Controls.Add(label8);
            Controls.Add(buttonPagarVenta);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBoxTotalVenta);
            Controls.Add(textBoxSubVenta);
            Controls.Add(buttonAgregarVenta);
            Controls.Add(dataGridVenta);
            Controls.Add(dataGridLista);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBoxTituloVenta);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Venta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Venta";
            ((System.ComponentModel.ISupportInitialize)dataGridLista).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)productoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericCantVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxTituloVenta;
        private Label label4;
        private Label label5;
        private DataGridView dataGridLista;
        private DataGridView dataGridVenta;
        private Button buttonAgregarVenta;
        private TextBox textBoxSubVenta;
        private TextBox textBoxTotalVenta;
        private Label label6;
        private Label label7;
        private Button buttonPagarVenta;
        private Label label8;
        private TextBox textBoxEfectivoVenta;
        private BindingSource productoBindingSource;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Titulo;
        private DataGridViewTextBoxColumn ISSN;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cant;
        private Label label3;
        private NumericUpDown numericCantVentas;
        private Label label2;
        private Button buttonBuscVenta;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Button buttonSalirVenta;
        private TextBox textBoxIVA;
        private Label label9;
    }
}