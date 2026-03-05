using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenLifeOrganicStore
{
    public partial class AdminDashbord : Form
    {
        public AdminDashbord()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if(txtUsername.Text==""|| txtPassword.Text==""|| cmbRole.Text=="")
            {
                MessageBox.Show("Please fill all fields");
                return;
            }
            
            if (cmbRole.Text == "Admin")
            {
                if (txtUsername.Text == "admin" && txtPassword.Text == "2468")
                {
                    MessageBox.Show("Admin Login Successful");
                    AdminDashboard admin = new AdminDashboard();
                    admin.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Admin Credentials");
                }

            }

            else if (cmbRole.Text == "Customer")
            {
                var customer = DataStore.Customers
                    .Find(c => c.Email == txtUsername.Text && c.Password == txtPassword.Text);

                if(customer != null)
                {
                 MessageBox.Show("Customer Login Successful");
                 CustomerDashboard cd = new CustomerDashboard();
                 cd.Show();
                 this.Hide();

                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.Show();
            this.Hide();
        }
    }
}
