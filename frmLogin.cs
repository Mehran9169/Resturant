using System;
using System.Windows.Forms;

namespace Resturant
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAccess.UsersRepository usersRepository = new DataAccess.UsersRepository();  
            bool exist = usersRepository.login(txtUserName.Text, txtPassword.Text);
            if (exist)
            {
                frmEmployee frm = new frmEmployee();
                frm.Show();
            }
            else
            {
                MessageBox.Show("نام کاربری یا کلمه عبور اشتباه است");
            }
        }
    }
}
