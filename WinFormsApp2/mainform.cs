using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2.Models;

namespace WinFormsApp2
{
    public partial class mainform : Form
    {
        DemDemContext context;

        public mainform()
        {
            InitializeComponent();
            dataGridView1.DataError += (sender, e) => e.ThrowException = false;

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            context = new DemDemContext();
            context.Products.Include(x => x.IdTipeProductNavigation).Include(x => x.IdManufacturNavigation).Include(x => x.IdSuplierNavigation).Include(x => x.IdEdNavigation).Load();
            context.Database.EnsureCreated();
            bindingSource_product.DataSource = context.Products.Local.ToBindingList();
            bindingSource_manufactur.DataSource = context.Manufacts.Local.ToBindingList();
            bindingSource_ed.DataSource = context.Eds.Local.ToBindingList();
            bindingSource_suplier.DataSource = context.Supliers.Local.ToBindingList();
            bindingSource_tipe_product.DataSource = context.TipeProducts.Local.ToBindingList();

            comboBox1.Items.AddRange(new string[]
            {
                "a-z",
                "z-a",
                "aaa"
            });
            comboBox1.SelectedIndex = 0;

        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ff = new Form1();
            ff.Show();
        }

        private void mainform_Load(object sender, EventArgs e)
        {

        }
        public void SetUserFio(string fio)
        {
            label_fio.Text = fio;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string qwery = textBox1.Text.Trim();
            if (string.IsNullOrEmpty(qwery))
            {
                bindingSource_product.DataSource = context.Products.Local.ToBindingList();
            }

            var result = context.Products.Local
                .Where(x => x.Name.IndexOf(qwery, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();
            bindingSource_product.DataSource = result;


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var data = context.Products.Local.AsQueryable();
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    data = data.OrderBy(x => x.Name);
                    break;

                case 1:
                    data = data.OrderByDescending(x => x.Name);
                    break;
                case 2:
                    data = data.OrderBy(x => x.IdTipeProductNavigation.Name);
                    break;
            }
            bindingSource_product.DataSource = data.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bindingSource_product.RemoveCurrent();
            context.SaveChanges();
            dataGridView1.Refresh();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new form_Add();
            form.bindingSource_manufactur.DataSource = bindingSource_manufactur.DataSource;
            form.bindingSource_suplier.DataSource = bindingSource_suplier.DataSource;
            form.bindingSource_tipe_product.DataSource = bindingSource_tipe_product.DataSource;
            form.bindingSource_ed.DataSource = bindingSource_ed.DataSource;
            var newProduct = new Product();
            context.Products.Add(newProduct);
            form.bindingSource_product.DataSource = newProduct;

            form.button_photo.Click += (s, args) =>
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    form.pictureBox1.Image = Image.FromFile(openFileDialog.FileName);

                    var tovar = (Product)form.bindingSource_product.Current;
                    tovar.IdPhoto = File.ReadAllBytes(openFileDialog.FileName);
                }
            };
            form.Save.Click += Save;
            form.Show();

        }

        private void Save(object? sender, EventArgs e)
        {
            bindingSource_product.EndEdit();
            var tovar = (Product)bindingSource_product.Current;
            if (tovar.IdTipeProduct == 0)
            {
                MessageBox.Show("введите тип продукта ");
                return;
            }
            context.SaveChanges();
            dataGridView1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form = new form_Add();
            form.bindingSource_manufactur.DataSource = bindingSource_manufactur.DataSource;
            form.bindingSource_suplier.DataSource = bindingSource_suplier.DataSource;
            form.bindingSource_tipe_product.DataSource = bindingSource_tipe_product.DataSource;
            form.bindingSource_ed.DataSource = bindingSource_ed.DataSource;
            form.bindingSource_product.DataSource = bindingSource_product.Current;
            form.button_photo.Click += (s, args) =>
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    form.pictureBox1.Image = Image.FromFile(openFileDialog.FileName);

                    var tovar = (Product)form.bindingSource_product.Current;
                    tovar.IdPhoto = File.ReadAllBytes(openFileDialog.FileName);
                }
            };
            form.Save.Click += Save;
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Orders ff = new Orders();
            ff.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is Product product)
            {
                ShowProductCard(product);
            }
        }

        private void ShowProductCard(Product p)
        {
            label1.Text = p.Name ?? "—";
            label2.Text = p.Articl ?? "—";
            label3.Text = $"{p.PriceProduct:N2} ₽";
            label4.Text = p.IdManufacturNavigation?.Name ?? "—";
            label5.Text = p.IdSuplierNavigation?.Name ?? "—";
            label6.Text = p.IdTipeProductNavigation?.Name ?? "—";
            label7.Text = p.ProductContent ?? "—";
            label8.Text = p.KolVo?.ToString() ?? "0";

            // Скидка
            label9.Text = p.Sale > 0 ? $"-{p.Sale}%" : "";

            // Фото
            try { pictureBox1.Image = p.IdPhoto != null ? Image.FromStream(new MemoryStream(p.IdPhoto)) : null; } catch { pictureBox1.Image = null; }
        }
    }
}
