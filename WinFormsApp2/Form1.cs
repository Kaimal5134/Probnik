using WinFormsApp2.Models;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           string login = textBox1.Text.Trim();
            string pass = textBox2.Text;
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("заполните все поля");
                return;
            }

            using (var db = new DemDemContext())
            {
                var lib = db.Users
                    .FirstOrDefault(l => l.Login == login && l.Password == pass);
                if (lib == null)
                {
                    MessageBox.Show("не правильно введен логин или пароль");
                    return;
                }
                switch (lib.IdRole)
                {
                    case 1:
                        MessageBox.Show($"Добро пожаловать пользователь {lib.Fio}");
                        this.Hide();
                        mainform ff = new mainform();
                        ff.SetUserFio(lib.Fio);
                        ff.Show();
                        break;
                    case 2:
                        MessageBox.Show($"Добро пожаловать админ {lib.Fio}");
                        this.Hide();
                        mainform dd = new mainform();
                        dd.Show();
                        break;
                    case 3:
                        MessageBox.Show($"Добро пожаловать  менеджер {lib.Fio}");
                        this.Hide();
                        mainform qq = new mainform();
                        qq.Show();
                        break;
                }

            }
                
            
        }
    }
}
