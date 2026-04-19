namespace WinFormsApp2
{
    partial class mainform
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
            bindingSource_product = new BindingSource(components);
            button1 = new Button();
            bindingSource_tipe_product = new BindingSource(components);
            bindingSource_manufactur = new BindingSource(components);
            bindingSource_suplier = new BindingSource(components);
            bindingSource_ed = new BindingSource(components);
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            articlDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idTipeProductNavigationDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            productContentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idManufacturDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            idSuplierDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            priceProductDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            saleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kolVoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idEdDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            idPhotoDataGridViewImageColumn = new DataGridViewImageColumn();
            button5 = new Button();
            label_fio = new Label();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource_product).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource_tipe_product).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource_manufactur).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource_suplier).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource_ed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // bindingSource_product
            // 
            bindingSource_product.DataSource = typeof(Models.Product);
            // 
            // button1
            // 
            button1.Location = new Point(493, 316);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // bindingSource_tipe_product
            // 
            bindingSource_tipe_product.DataSource = typeof(Models.TipeProduct);
            // 
            // bindingSource_manufactur
            // 
            bindingSource_manufactur.DataSource = typeof(Models.Manufact);
            // 
            // bindingSource_suplier
            // 
            bindingSource_suplier.DataSource = typeof(Models.Suplier);
            // 
            // bindingSource_ed
            // 
            bindingSource_ed.DataSource = typeof(Models.Ed);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(24, 16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(245, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(385, 16);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(24, 316);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(175, 316);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 5;
            button3.Text = "Redact";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(330, 316);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 6;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { articlDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, idTipeProductNavigationDataGridViewTextBoxColumn, productContentDataGridViewTextBoxColumn, idManufacturDataGridViewTextBoxColumn, idSuplierDataGridViewTextBoxColumn, priceProductDataGridViewTextBoxColumn, saleDataGridViewTextBoxColumn, kolVoDataGridViewTextBoxColumn, idEdDataGridViewTextBoxColumn, idPhotoDataGridViewImageColumn });
            dataGridView1.DataSource = bindingSource_product;
            dataGridView1.Location = new Point(24, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(447, 186);
            dataGridView1.TabIndex = 7;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // articlDataGridViewTextBoxColumn
            // 
            articlDataGridViewTextBoxColumn.DataPropertyName = "Articl";
            articlDataGridViewTextBoxColumn.HeaderText = "Артикал";
            articlDataGridViewTextBoxColumn.MinimumWidth = 6;
            articlDataGridViewTextBoxColumn.Name = "articlDataGridViewTextBoxColumn";
            articlDataGridViewTextBoxColumn.ReadOnly = true;
            articlDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Название";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // idTipeProductNavigationDataGridViewTextBoxColumn
            // 
            idTipeProductNavigationDataGridViewTextBoxColumn.DataPropertyName = "IdTipeProduct";
            idTipeProductNavigationDataGridViewTextBoxColumn.DataSource = bindingSource_tipe_product;
            idTipeProductNavigationDataGridViewTextBoxColumn.DisplayMember = "Name";
            idTipeProductNavigationDataGridViewTextBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            idTipeProductNavigationDataGridViewTextBoxColumn.HeaderText = "Тип продукта ";
            idTipeProductNavigationDataGridViewTextBoxColumn.MinimumWidth = 6;
            idTipeProductNavigationDataGridViewTextBoxColumn.Name = "idTipeProductNavigationDataGridViewTextBoxColumn";
            idTipeProductNavigationDataGridViewTextBoxColumn.ReadOnly = true;
            idTipeProductNavigationDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            idTipeProductNavigationDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            idTipeProductNavigationDataGridViewTextBoxColumn.ValueMember = "IdtipeProduct";
            idTipeProductNavigationDataGridViewTextBoxColumn.Width = 125;
            // 
            // productContentDataGridViewTextBoxColumn
            // 
            productContentDataGridViewTextBoxColumn.DataPropertyName = "ProductContent";
            productContentDataGridViewTextBoxColumn.HeaderText = "описание";
            productContentDataGridViewTextBoxColumn.MinimumWidth = 6;
            productContentDataGridViewTextBoxColumn.Name = "productContentDataGridViewTextBoxColumn";
            productContentDataGridViewTextBoxColumn.ReadOnly = true;
            productContentDataGridViewTextBoxColumn.Width = 125;
            // 
            // idManufacturDataGridViewTextBoxColumn
            // 
            idManufacturDataGridViewTextBoxColumn.DataPropertyName = "IdManufactur";
            idManufacturDataGridViewTextBoxColumn.DataSource = bindingSource_manufactur;
            idManufacturDataGridViewTextBoxColumn.DisplayMember = "Name";
            idManufacturDataGridViewTextBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            idManufacturDataGridViewTextBoxColumn.HeaderText = "производитель";
            idManufacturDataGridViewTextBoxColumn.MinimumWidth = 6;
            idManufacturDataGridViewTextBoxColumn.Name = "idManufacturDataGridViewTextBoxColumn";
            idManufacturDataGridViewTextBoxColumn.ReadOnly = true;
            idManufacturDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            idManufacturDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            idManufacturDataGridViewTextBoxColumn.ValueMember = "Idmanufact";
            idManufacturDataGridViewTextBoxColumn.Width = 125;
            // 
            // idSuplierDataGridViewTextBoxColumn
            // 
            idSuplierDataGridViewTextBoxColumn.DataPropertyName = "IdSuplier";
            idSuplierDataGridViewTextBoxColumn.DataSource = bindingSource_suplier;
            idSuplierDataGridViewTextBoxColumn.DisplayMember = "Name";
            idSuplierDataGridViewTextBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            idSuplierDataGridViewTextBoxColumn.HeaderText = "поставщик";
            idSuplierDataGridViewTextBoxColumn.MinimumWidth = 6;
            idSuplierDataGridViewTextBoxColumn.Name = "idSuplierDataGridViewTextBoxColumn";
            idSuplierDataGridViewTextBoxColumn.ReadOnly = true;
            idSuplierDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            idSuplierDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            idSuplierDataGridViewTextBoxColumn.ValueMember = "Idsuplier";
            idSuplierDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceProductDataGridViewTextBoxColumn
            // 
            priceProductDataGridViewTextBoxColumn.DataPropertyName = "PriceProduct";
            priceProductDataGridViewTextBoxColumn.HeaderText = "цена";
            priceProductDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceProductDataGridViewTextBoxColumn.Name = "priceProductDataGridViewTextBoxColumn";
            priceProductDataGridViewTextBoxColumn.ReadOnly = true;
            priceProductDataGridViewTextBoxColumn.Width = 125;
            // 
            // saleDataGridViewTextBoxColumn
            // 
            saleDataGridViewTextBoxColumn.DataPropertyName = "Sale";
            saleDataGridViewTextBoxColumn.HeaderText = "скидка";
            saleDataGridViewTextBoxColumn.MinimumWidth = 6;
            saleDataGridViewTextBoxColumn.Name = "saleDataGridViewTextBoxColumn";
            saleDataGridViewTextBoxColumn.ReadOnly = true;
            saleDataGridViewTextBoxColumn.Width = 125;
            // 
            // kolVoDataGridViewTextBoxColumn
            // 
            kolVoDataGridViewTextBoxColumn.DataPropertyName = "KolVo";
            kolVoDataGridViewTextBoxColumn.HeaderText = "количество";
            kolVoDataGridViewTextBoxColumn.MinimumWidth = 6;
            kolVoDataGridViewTextBoxColumn.Name = "kolVoDataGridViewTextBoxColumn";
            kolVoDataGridViewTextBoxColumn.ReadOnly = true;
            kolVoDataGridViewTextBoxColumn.Width = 125;
            // 
            // idEdDataGridViewTextBoxColumn
            // 
            idEdDataGridViewTextBoxColumn.DataPropertyName = "IdEd";
            idEdDataGridViewTextBoxColumn.DataSource = bindingSource_ed;
            idEdDataGridViewTextBoxColumn.DisplayMember = "Name";
            idEdDataGridViewTextBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            idEdDataGridViewTextBoxColumn.HeaderText = "единица измерения";
            idEdDataGridViewTextBoxColumn.MinimumWidth = 6;
            idEdDataGridViewTextBoxColumn.Name = "idEdDataGridViewTextBoxColumn";
            idEdDataGridViewTextBoxColumn.ReadOnly = true;
            idEdDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            idEdDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            idEdDataGridViewTextBoxColumn.ValueMember = "Ided";
            idEdDataGridViewTextBoxColumn.Width = 125;
            // 
            // idPhotoDataGridViewImageColumn
            // 
            idPhotoDataGridViewImageColumn.DataPropertyName = "IdPhoto";
            idPhotoDataGridViewImageColumn.HeaderText = "фото";
            idPhotoDataGridViewImageColumn.MinimumWidth = 6;
            idPhotoDataGridViewImageColumn.Name = "idPhotoDataGridViewImageColumn";
            idPhotoDataGridViewImageColumn.ReadOnly = true;
            idPhotoDataGridViewImageColumn.Width = 125;
            // 
            // button5
            // 
            button5.Location = new Point(540, 116);
            button5.Name = "button5";
            button5.Size = new Size(97, 45);
            button5.TabIndex = 8;
            button5.Text = "Order";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label_fio
            // 
            label_fio.AutoSize = true;
            label_fio.Location = new Point(587, 16);
            label_fio.Name = "label_fio";
            label_fio.Size = new Size(0, 20);
            label_fio.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(643, 115);
            panel1.Name = "panel1";
            panel1.Size = new Size(413, 261);
            panel1.TabIndex = 10;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 22);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 65);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 111);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(166, 22);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 3;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(166, 65);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 4;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(166, 114);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 5;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(287, 21);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 6;
            label7.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(285, 69);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 7;
            label8.Text = "label8";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(289, 109);
            label9.Name = "label9";
            label9.Size = new Size(50, 20);
            label9.TabIndex = 8;
            label9.Text = "label9";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(130, 163);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 76);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // mainform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 416);
            Controls.Add(panel1);
            Controls.Add(label_fio);
            Controls.Add(button5);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "mainform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "mainform";
            Load += mainform_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource_product).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource_tipe_product).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource_manufactur).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource_suplier).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource_ed).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        public BindingSource bindingSource_product;
        public BindingSource bindingSource_tipe_product;
        public BindingSource bindingSource_manufactur;
        public BindingSource bindingSource_suplier;
        public BindingSource bindingSource_ed;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn articlDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn idTipeProductNavigationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productContentDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn idManufacturDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn idSuplierDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceProductDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn saleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kolVoDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn idEdDataGridViewTextBoxColumn;
        private DataGridViewImageColumn idPhotoDataGridViewImageColumn;
        private Button button5;
        public Label label_fio;
        private Panel panel1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}