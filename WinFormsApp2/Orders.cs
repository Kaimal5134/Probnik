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
    public partial class Orders : Form
    {
        DemDemContext context;
        public Orders()
        {
            InitializeComponent();
            dataGridView1.DataError += (sender, e) => e.ThrowException = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainform ff = new mainform();
            ff.Show();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            context = new DemDemContext();
            context.Orders.Include(x => x.IdStatusNavigation).Include(x => x.FioNavigation).Include(x => x.OrderItems).Load();
            context.Database.EnsureCreated();
            bindingSource_Order.DataSource = context.Orders.Local.ToBindingList();
            bindingSource_status.DataSource = context.Statuses.Local.ToBindingList();
            bindingSource_user.DataSource = context.Users.Local.ToBindingList();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (bindingSource_Order.Current is not Order o)
            {
                MessageBox.Show("Выберите заказ");
                return;
            }

            if (o.IdStatus != 4)
            {
                MessageBox.Show("Можно удалить только отменённые заказы!\nСначала измените статус на 'Отменён'.", "Ошибка");
                return;
            }

            if (MessageBox.Show($"Удалить заказ №{o.Idzakaz}?\nВсе позиции также будут удалены!", "Подтверждение", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            context.OrderItems.RemoveRange(o.OrderItems);
            context.Orders.Remove(o);
            context.SaveChanges();

            bindingSource_Order.DataSource = context.Orders.Local.ToBindingList();
            dataGridView1.Refresh();
            MessageBox.Show("Заказ удалён", "Успех");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
