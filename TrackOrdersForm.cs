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
    public partial class TrackOrdersForm : Form
    {
        public TrackOrdersForm()
        {
            InitializeComponent();
        }

        private void dgvMyOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TrackOrdersForm_Load(object sender, EventArgs e)
        {
            dgvMyOrders.DataSource = DataStore.Orders;
        }
    }
}
