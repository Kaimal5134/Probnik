namespace WinFormsApp2
{
    partial class Orders
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
            dataGridView1 = new DataGridView();
            articleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fioDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            bindingSource_user = new BindingSource(components);
            idStatusDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            bindingSource_status = new BindingSource(components);
            adrecDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataStartDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateEndDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bindingSource_Order = new BindingSource(components);
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource_user).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource_status).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource_Order).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { articleDataGridViewTextBoxColumn, fioDataGridViewTextBoxColumn, idStatusDataGridViewTextBoxColumn, adrecDataGridViewTextBoxColumn, dataStartDataGridViewTextBoxColumn, dateEndDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bindingSource_Order;
            dataGridView1.Location = new Point(60, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(646, 253);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // articleDataGridViewTextBoxColumn
            // 
            articleDataGridViewTextBoxColumn.DataPropertyName = "Article";
            articleDataGridViewTextBoxColumn.HeaderText = "Article";
            articleDataGridViewTextBoxColumn.MinimumWidth = 6;
            articleDataGridViewTextBoxColumn.Name = "articleDataGridViewTextBoxColumn";
            articleDataGridViewTextBoxColumn.ReadOnly = true;
            articleDataGridViewTextBoxColumn.Width = 125;
            // 
            // fioDataGridViewTextBoxColumn
            // 
            fioDataGridViewTextBoxColumn.DataPropertyName = "Fio";
            fioDataGridViewTextBoxColumn.DataSource = bindingSource_user;
            fioDataGridViewTextBoxColumn.DisplayMember = "Fio";
            fioDataGridViewTextBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            fioDataGridViewTextBoxColumn.HeaderText = "Fio";
            fioDataGridViewTextBoxColumn.MinimumWidth = 6;
            fioDataGridViewTextBoxColumn.Name = "fioDataGridViewTextBoxColumn";
            fioDataGridViewTextBoxColumn.ReadOnly = true;
            fioDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            fioDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            fioDataGridViewTextBoxColumn.ValueMember = "Iduser";
            fioDataGridViewTextBoxColumn.Width = 125;
            // 
            // bindingSource_user
            // 
            bindingSource_user.DataSource = typeof(Models.User);
            // 
            // idStatusDataGridViewTextBoxColumn
            // 
            idStatusDataGridViewTextBoxColumn.DataPropertyName = "IdStatus";
            idStatusDataGridViewTextBoxColumn.DataSource = bindingSource_status;
            idStatusDataGridViewTextBoxColumn.DisplayMember = "Name";
            idStatusDataGridViewTextBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            idStatusDataGridViewTextBoxColumn.HeaderText = "IdStatus";
            idStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            idStatusDataGridViewTextBoxColumn.Name = "idStatusDataGridViewTextBoxColumn";
            idStatusDataGridViewTextBoxColumn.ReadOnly = true;
            idStatusDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            idStatusDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            idStatusDataGridViewTextBoxColumn.ValueMember = "IdStatus";
            idStatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // bindingSource_status
            // 
            bindingSource_status.DataSource = typeof(Models.Status);
            // 
            // adrecDataGridViewTextBoxColumn
            // 
            adrecDataGridViewTextBoxColumn.DataPropertyName = "Adrec";
            adrecDataGridViewTextBoxColumn.HeaderText = "Adrec";
            adrecDataGridViewTextBoxColumn.MinimumWidth = 6;
            adrecDataGridViewTextBoxColumn.Name = "adrecDataGridViewTextBoxColumn";
            adrecDataGridViewTextBoxColumn.ReadOnly = true;
            adrecDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataStartDataGridViewTextBoxColumn
            // 
            dataStartDataGridViewTextBoxColumn.DataPropertyName = "DataStart";
            dataStartDataGridViewTextBoxColumn.HeaderText = "DataStart";
            dataStartDataGridViewTextBoxColumn.MinimumWidth = 6;
            dataStartDataGridViewTextBoxColumn.Name = "dataStartDataGridViewTextBoxColumn";
            dataStartDataGridViewTextBoxColumn.ReadOnly = true;
            dataStartDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateEndDataGridViewTextBoxColumn
            // 
            dateEndDataGridViewTextBoxColumn.DataPropertyName = "DateEnd";
            dateEndDataGridViewTextBoxColumn.HeaderText = "DateEnd";
            dateEndDataGridViewTextBoxColumn.MinimumWidth = 6;
            dateEndDataGridViewTextBoxColumn.Name = "dateEndDataGridViewTextBoxColumn";
            dateEndDataGridViewTextBoxColumn.ReadOnly = true;
            dateEndDataGridViewTextBoxColumn.Width = 125;
            // 
            // bindingSource_Order
            // 
            bindingSource_Order.DataSource = typeof(Models.Order);
            // 
            // button1
            // 
            button1.Location = new Point(612, 354);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(53, 320);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(210, 320);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 3;
            button3.Text = "red";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(382, 320);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 4;
            button4.Text = "del";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Orders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Orders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Orders";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource_user).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource_status).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource_Order).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        public BindingSource bindingSource_user;
        public BindingSource bindingSource_status;
        public BindingSource bindingSource_Order;
        private DataGridViewTextBoxColumn articleDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn fioDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn idStatusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adrecDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataStartDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateEndDataGridViewTextBoxColumn;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}