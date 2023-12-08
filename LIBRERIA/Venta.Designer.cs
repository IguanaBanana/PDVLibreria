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
            textBoxNombreVenta = new TextBox();
            label4 = new Label();
            label5 = new Label();
            dataGridLista = new DataGridView();
            dataGridVenta = new DataGridView();
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
            ID = new DataGridViewTextBoxColumn();
            Titulo = new DataGridViewTextBoxColumn();
            ISSN = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cant = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            QinS = new DataGridViewTextBoxColumn();
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
            label1.Location = new Point(38, 9);
            label1.Name = "label1";
            label1.Size = new Size(79, 23);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // textBoxNombreVenta
            // 
            textBoxNombreVenta.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNombreVenta.Location = new Point(38, 34);
            textBoxNombreVenta.Margin = new Padding(3, 2, 3, 2);
            textBoxNombreVenta.Name = "textBoxNombreVenta";
            textBoxNombreVenta.Size = new Size(430, 30);
            textBoxNombreVenta.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(522, 28);
            label4.Name = "label4";
            label4.Size = new Size(60, 23);
            label4.TabIndex = 6;
            label4.Text = "Venta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(38, 86);
            label5.Name = "label5";
            label5.Size = new Size(140, 23);
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
            dataGridLista.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, QinS });
            dataGridLista.Location = new Point(38, 110);
            dataGridLista.Margin = new Padding(3, 2, 3, 2);
            dataGridLista.Name = "dataGridLista";
            dataGridLista.ReadOnly = true;
            dataGridLista.RowHeadersWidth = 51;
            dataGridLista.RowTemplate.Height = 29;
            dataGridLista.Size = new Size(430, 274);
            dataGridLista.TabIndex = 8;
            // 
            // dataGridVenta
            // 
            dataGridVenta.AllowUserToDeleteRows = false;
            dataGridVenta.AllowUserToOrderColumns = true;
            dataGridVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridVenta.Columns.AddRange(new DataGridViewColumn[] { ID, Titulo, ISSN, Precio, Cant });
            dataGridVenta.Location = new Point(522, 53);
            dataGridVenta.Margin = new Padding(3, 2, 3, 2);
            dataGridVenta.Name = "dataGridVenta";
            dataGridVenta.ReadOnly = true;
            dataGridVenta.RowHeadersWidth = 51;
            dataGridVenta.RowTemplate.Height = 29;
            dataGridVenta.Size = new Size(583, 249);
            dataGridVenta.TabIndex = 9;
            // 
            // buttonAgregarVenta
            // 
            buttonAgregarVenta.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAgregarVenta.Location = new Point(363, 425);
            buttonAgregarVenta.Margin = new Padding(3, 2, 3, 2);
            buttonAgregarVenta.Name = "buttonAgregarVenta";
            buttonAgregarVenta.Size = new Size(105, 28);
            buttonAgregarVenta.TabIndex = 10;
            buttonAgregarVenta.Text = "Agregar";
            buttonAgregarVenta.UseVisualStyleBackColor = true;
            buttonAgregarVenta.Click += buttonAgregarVenta_Click;
            // 
            // textBoxSubVenta
            // 
            textBoxSubVenta.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSubVenta.Location = new Point(985, 322);
            textBoxSubVenta.Margin = new Padding(3, 2, 3, 2);
            textBoxSubVenta.Name = "textBoxSubVenta";
            textBoxSubVenta.Size = new Size(120, 30);
            textBoxSubVenta.TabIndex = 11;
            textBoxSubVenta.TextAlign = HorizontalAlignment.Right;
            // 
            // textBoxTotalVenta
            // 
            textBoxTotalVenta.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTotalVenta.Location = new Point(985, 386);
            textBoxTotalVenta.Margin = new Padding(3, 2, 3, 2);
            textBoxTotalVenta.Name = "textBoxTotalVenta";
            textBoxTotalVenta.Size = new Size(120, 30);
            textBoxTotalVenta.TabIndex = 12;
            textBoxTotalVenta.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(926, 388);
            label6.Name = "label6";
            label6.Size = new Size(52, 23);
            label6.TabIndex = 13;
            label6.Text = "Total";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(886, 324);
            label7.Name = "label7";
            label7.Size = new Size(86, 23);
            label7.TabIndex = 14;
            label7.Text = "SubTotal";
            // 
            // buttonPagarVenta
            // 
            buttonPagarVenta.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPagarVenta.Location = new Point(1000, 425);
            buttonPagarVenta.Margin = new Padding(3, 2, 3, 2);
            buttonPagarVenta.Name = "buttonPagarVenta";
            buttonPagarVenta.Size = new Size(105, 28);
            buttonPagarVenta.TabIndex = 15;
            buttonPagarVenta.Text = "Pagar";
            buttonPagarVenta.UseVisualStyleBackColor = true;
            buttonPagarVenta.Click += buttonPagarVenta_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(627, 331);
            label8.Name = "label8";
            label8.Size = new Size(80, 23);
            label8.TabIndex = 16;
            label8.Text = "Efectivo";
            // 
            // textBoxEfectivoVenta
            // 
            textBoxEfectivoVenta.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEfectivoVenta.Location = new Point(627, 354);
            textBoxEfectivoVenta.Margin = new Padding(3, 2, 3, 2);
            textBoxEfectivoVenta.Name = "textBoxEfectivoVenta";
            textBoxEfectivoVenta.Size = new Size(120, 30);
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
            label3.Location = new Point(203, 21);
            label3.Name = "label3";
            label3.Size = new Size(0, 23);
            label3.TabIndex = 2;
            // 
            // numericCantVentas
            // 
            numericCantVentas.Font = new Font("Arial Narrow", 15F, FontStyle.Regular, GraphicsUnit.Point);
            numericCantVentas.Location = new Point(362, 390);
            numericCantVentas.Name = "numericCantVentas";
            numericCantVentas.Size = new Size(106, 30);
            numericCantVentas.TabIndex = 22;
            numericCantVentas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(305, 392);
            label2.Name = "label2";
            label2.Size = new Size(51, 23);
            label2.TabIndex = 23;
            label2.Text = "Cant";
            // 
            // buttonBuscVenta
            // 
            buttonBuscVenta.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBuscVenta.Location = new Point(363, 68);
            buttonBuscVenta.Margin = new Padding(3, 2, 3, 2);
            buttonBuscVenta.Name = "buttonBuscVenta";
            buttonBuscVenta.Size = new Size(105, 28);
            buttonBuscVenta.TabIndex = 24;
            buttonBuscVenta.Text = "Buscar";
            buttonBuscVenta.UseVisualStyleBackColor = true;
            buttonBuscVenta.Click += buttonBuscVenta_Click;
            // 
            // buttonSalirVenta
            // 
            buttonSalirVenta.BackColor = Color.IndianRed;
            buttonSalirVenta.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSalirVenta.Location = new Point(1044, 502);
            buttonSalirVenta.Margin = new Padding(3, 2, 3, 2);
            buttonSalirVenta.Name = "buttonSalirVenta";
            buttonSalirVenta.Size = new Size(62, 28);
            buttonSalirVenta.TabIndex = 25;
            buttonSalirVenta.Text = "Salir";
            buttonSalirVenta.UseVisualStyleBackColor = false;
            buttonSalirVenta.Click += buttonSalirVenta_Click;
            // 
            // textBoxIVA
            // 
            textBoxIVA.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxIVA.Location = new Point(985, 353);
            textBoxIVA.Margin = new Padding(3, 2, 3, 2);
            textBoxIVA.Name = "textBoxIVA";
            textBoxIVA.Size = new Size(120, 30);
            textBoxIVA.TabIndex = 26;
            textBoxIVA.TextAlign = HorizontalAlignment.Right;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(938, 356);
            label9.Name = "label9";
            label9.Size = new Size(41, 23);
            label9.TabIndex = 27;
            label9.Text = "IVA";
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
            Titulo.HeaderText = "Nombre";
            Titulo.MinimumWidth = 6;
            Titulo.Name = "Titulo";
            Titulo.ReadOnly = true;
            // 
            // ISSN
            // 
            ISSN.HeaderText = "Descripcion";
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
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Descripcion";
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
            // QinS
            // 
            QinS.HeaderText = "Q. in S.";
            QinS.Name = "QinS";
            QinS.ReadOnly = true;
            // 
            // Venta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1116, 541);
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
            Controls.Add(textBoxNombreVenta);
            Controls.Add(label3);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
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
        private TextBox textBoxNombreVenta;
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
        private Label label3;
        private NumericUpDown numericCantVentas;
        private Label label2;
        private Button buttonBuscVenta;
        private Button buttonSalirVenta;
        private TextBox textBoxIVA;
        private Label label9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn QinS;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Titulo;
        private DataGridViewTextBoxColumn ISSN;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cant;
    }
}