using GreenLifeOrganicStore.Models;
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
    public partial class ManageOrdersForm : Form
    {
        public ManageOrdersForm()
        {
            InitializeComponent();
        }

        private void ManageOrdersForm_Load(object sender, EventArgs e)
        {
            dgvOrders.DataSource = DataStore.Orders;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(dgvOrders.CurrentRow != null)
            {
                int id = (int)dgvOrders.CurrentRow.Cells[0].Value;
                Order order = DataStore.Orders.Find(o => o.OrderID == id);
                order.Status = cmbStatus.Text;

                dgvOrders.Refresh();

            }
        }
    }
}
