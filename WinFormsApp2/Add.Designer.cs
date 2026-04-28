namespace WinFormsApp2
{
    partial class form_Add
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
            textBox1 = new TextBox();
            bindingSource_product = new BindingSource(components);
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            comboBox1 = new ComboBox();
            bindingSource_tipe_product = new BindingSource(components);
            comboBox2 = new ComboBox();
            bindingSource_manufactur = new BindingSource(components);
            comboBox3 = new ComboBox();
            bindingSource_ed = new BindingSource(components);
            comboBox4 = new ComboBox();
            bindingSource_suplier = new BindingSource(components);
            button1 = new Button();
            Save = new Button();
            button_photo = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSource_product).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource_tipe_product).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource_manufactur).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource_ed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource_suplier).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(133, 242, 189);
            textBox1.DataBindings.Add(new Binding("DataContext", bindingSource_product, "Name", true));
            textBox1.DataBindings.Add(new Binding("Text", bindingSource_product, "Name", true));
            textBox1.Font = new Font("Comic Sans MS", 9F);
            textBox1.Location = new Point(52, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(173, 28);
            textBox1.TabIndex = 0;
            // 
            // bindingSource_product
            // 
            bindingSource_product.DataSource = typeof(Models.Product);
            bindingSource_product.CurrentChanged += bindingSource_product_CurrentChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(133, 242, 189);
            textBox2.DataBindings.Add(new Binding("DataContext", bindingSource_product, "Articl", true));
            textBox2.DataBindings.Add(new Binding("Text", bindingSource_product, "Articl", true));
            textBox2.Font = new Font("Comic Sans MS", 9F);
            textBox2.Location = new Point(52, 120);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(173, 28);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(133, 242, 189);
            textBox3.DataBindings.Add(new Binding("DataContext", bindingSource_product, "ProductContent", true));
            textBox3.DataBindings.Add(new Binding("Text", bindingSource_product, "ProductContent", true));
            textBox3.Font = new Font("Comic Sans MS", 9F);
            textBox3.Location = new Point(52, 189);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(173, 28);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(133, 242, 189);
            textBox4.DataBindings.Add(new Binding("DataContext", bindingSource_product, "PriceProduct", true));
            textBox4.DataBindings.Add(new Binding("Text", bindingSource_product, "PriceProduct", true));
            textBox4.Font = new Font("Comic Sans MS", 9F);
            textBox4.Location = new Point(52, 262);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(173, 28);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.DataBindings.Add(new Binding("DataContext", bindingSource_product, "KolVo", true));
            textBox5.DataBindings.Add(new Binding("Text", bindingSource_product, "KolVo", true));
            textBox5.Location = new Point(52, 403);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(173, 27);
            textBox5.TabIndex = 5;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.FromArgb(133, 242, 189);
            textBox6.DataBindings.Add(new Binding("DataContext", bindingSource_product, "Sale", true));
            textBox6.DataBindings.Add(new Binding("Text", bindingSource_product, "Sale", true));
            textBox6.Font = new Font("Comic Sans MS", 9F);
            textBox6.Location = new Point(52, 330);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(173, 28);
            textBox6.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(133, 242, 189);
            comboBox1.DataBindings.Add(new Binding("SelectedValue", bindingSource_product, "IdTipeProduct", true));
            comboBox1.DataSource = bindingSource_tipe_product;
            comboBox1.DisplayMember = "Name";
            comboBox1.Font = new Font("Comic Sans MS", 9F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(273, 56);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 6;
            comboBox1.ValueMember = "IdtipeProduct";
            // 
            // bindingSource_tipe_product
            // 
            bindingSource_tipe_product.DataSource = typeof(Models.TipeProduct);
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.FromArgb(133, 242, 189);
            comboBox2.DataBindings.Add(new Binding("SelectedValue", bindingSource_product, "IdManufactur", true));
            comboBox2.DataSource = bindingSource_manufactur;
            comboBox2.DisplayMember = "Name";
            comboBox2.Font = new Font("Comic Sans MS", 9F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(273, 119);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 7;
            comboBox2.ValueMember = "Idmanufact";
            // 
            // bindingSource_manufactur
            // 
            bindingSource_manufactur.DataSource = typeof(Models.Manufact);
            // 
            // comboBox3
            // 
            comboBox3.BackColor = Color.FromArgb(133, 242, 189);
            comboBox3.DataBindings.Add(new Binding("SelectedValue", bindingSource_product, "IdEd", true));
            comboBox3.DataSource = bindingSource_ed;
            comboBox3.DisplayMember = "Name";
            comboBox3.Font = new Font("Comic Sans MS", 9F);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(273, 252);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 28);
            comboBox3.TabIndex = 9;
            comboBox3.ValueMember = "Ided";
            // 
            // bindingSource_ed
            // 
            bindingSource_ed.DataSource = typeof(Models.Ed);
            // 
            // comboBox4
            // 
            comboBox4.BackColor = Color.FromArgb(133, 242, 189);
            comboBox4.DataBindings.Add(new Binding("SelectedValue", bindingSource_product, "IdSuplier", true));
            comboBox4.DataSource = bindingSource_suplier;
            comboBox4.DisplayMember = "Name";
            comboBox4.Font = new Font("Comic Sans MS", 9F);
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(273, 189);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(151, 28);
            comboBox4.TabIndex = 8;
            comboBox4.ValueMember = "Idsuplier";
            // 
            // bindingSource_suplier
            // 
            bindingSource_suplier.DataSource = typeof(Models.Suplier);
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Location = new Point(356, 439);
            button1.Name = "button1";
            button1.Size = new Size(128, 52);
            button1.TabIndex = 10;
            button1.Text = "Отмена";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Save
            // 
            Save.BackColor = Color.Red;
            Save.Location = new Point(68, 451);
            Save.Name = "Save";
            Save.Size = new Size(116, 29);
            Save.TabIndex = 11;
            Save.Text = "сохранить";
            Save.UseVisualStyleBackColor = false;
            // 
            // button_photo
            // 
            button_photo.BackColor = Color.Red;
            button_photo.Location = new Point(248, 402);
            button_photo.Name = "button_photo";
            button_photo.Size = new Size(207, 29);
            button_photo.TabIndex = 12;
            button_photo.Text = "Добавить фотографию";
            button_photo.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.DataBindings.Add(new Binding("DataContext", bindingSource_product, "IdPhoto", true));
            pictureBox1.DataBindings.Add(new Binding("Image", bindingSource_product, "IdPhoto", true));
            pictureBox1.Location = new Point(285, 300);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 9F);
            label1.Location = new Point(52, 30);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 14;
            label1.Text = "Название";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 9F);
            label2.Location = new Point(52, 93);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 15;
            label2.Text = "Артикл";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 9F);
            label3.Location = new Point(52, 166);
            label3.Name = "label3";
            label3.Size = new Size(150, 20);
            label3.TabIndex = 16;
            label3.Text = "описание продукта";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 9F);
            label4.Location = new Point(273, 225);
            label4.Name = "label4";
            label4.Size = new Size(153, 20);
            label4.TabIndex = 17;
            label4.Text = "единица измерения";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 9F);
            label5.Location = new Point(52, 300);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 18;
            label5.Text = "скидка";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(52, 380);
            label6.Name = "label6";
            label6.Size = new Size(140, 20);
            label6.TabIndex = 19;
            label6.Text = "количество товара";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 9F);
            label7.Location = new Point(273, 30);
            label7.Name = "label7";
            label7.Size = new Size(109, 20);
            label7.TabIndex = 20;
            label7.Text = "Тип продукта";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Comic Sans MS", 9F);
            label8.Location = new Point(273, 93);
            label8.Name = "label8";
            label8.Size = new Size(121, 20);
            label8.TabIndex = 21;
            label8.Text = "производитель";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Comic Sans MS", 9F);
            label9.Location = new Point(273, 166);
            label9.Name = "label9";
            label9.Size = new Size(88, 20);
            label9.TabIndex = 22;
            label9.Text = "поставщик";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Comic Sans MS", 9F);
            label10.Location = new Point(52, 239);
            label10.Name = "label10";
            label10.Size = new Size(112, 20);
            label10.TabIndex = 23;
            label10.Text = "цена продукта";
            // 
            // form_Add
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 237, 215);
            ClientSize = new Size(508, 503);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button_photo);
            Controls.Add(Save);
            Controls.Add(button1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox4);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox5);
            Controls.Add(textBox6);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "form_Add";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add";
            Load += form_Add_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource_product).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource_tipe_product).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource_manufactur).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource_ed).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource_suplier).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private Button button1;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        public Button Save;
        public Button button_photo;
        public BindingSource bindingSource_product;
        public BindingSource bindingSource_tipe_product;
        public BindingSource bindingSource_manufactur;
        public BindingSource bindingSource_suplier;
        public BindingSource bindingSource_ed;
        public PictureBox pictureBox1;
    }
}