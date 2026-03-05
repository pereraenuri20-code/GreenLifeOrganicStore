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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnManageProducts_Click(object sender, EventArgs e)
        {
            ProductManagementForm pm = new ProductManagementForm();
            pm.Show();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            lblProducts.Text = "Total Products;" + DataStore.Products.Count;
            lblOrders.Text = "Total Orders;" + DataStore.Orders.Count;

        }
    }
}
