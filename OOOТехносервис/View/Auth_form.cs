using OOOТехносервис.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOOТехносервис
{
    public partial class Auth_Form : Form
    {
        public Auth_Form()
        {
            InitializeComponent();

            //Установка связи с БД
            try
            {
                Helper.DB = new Model.DExamDBTestEntities();
                label4.Text = "Связь с БД успешно установлена";
            }
            catch (Exception ex)
            {
                label4.Text = "Связь с БД НЕ установлена";
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void auth_button_Click(object sender, EventArgs e)
        {
            string login, password;

            List<Model.User> users = Helper.DB.User.ToList();

            login = login_TB.Text;
            password = password_TB.Text;

            users = users.Where(u => u.UserLogin == login && u.UserPassword == password).ToList();
            Helper.user = users.FirstOrDefault();

            if (Helper.user != null)
            {
                MessageBox.Show("Вы вошли с ролью " + Helper.user.Role.RoleName);
                View.ListRequests listRequests = new View.ListRequests();
                this.Hide();
                listRequests.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Не удалось найти пользователя в БД", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void test_btn_Click(object sender, EventArgs e)
        {
            login_TB.Text = "loginDElqb2018";
            password_TB.Text = "RNynil";
        }
    }
}
