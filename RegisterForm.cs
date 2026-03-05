using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GreenLifeOrganicStore.Models;

namespace GreenLifeOrganicStore
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text == ""|| txtEmail.Text == ""|| txtPassword.Text == "")
            {
                MessageBox.Show("Please fill all field");
                return;
            }

            Customer customer = new Customer
            {
                CustomerID = + 1,
                FullName = txtFullName.Text,
                Email = txtEmail.Text,
                Password = txtPassword.Text
            };

            DataStore.Customers.Add(customer);

            MessageBox.Show("Registration successful");

            txtFullName.Clear();
            txtEmail.Clear();
            txtPassword.Clear();

        }
        
    }
}
