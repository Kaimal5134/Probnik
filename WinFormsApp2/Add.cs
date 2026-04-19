using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class form_Add : Form
    {
        public form_Add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainform ff = new mainform();


        }

        private void form_Add_Load(object sender, EventArgs e)
        {

        }

        private void bindingSource_product_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
