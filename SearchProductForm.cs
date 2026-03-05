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
    public partial class SearchProductForm : Form
    {
        public SearchProductForm()
        {
            InitializeComponent();
        }

        private void SearchProductForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var results = DataStore.Products
                .FindAll(p => p.Name.ToLower().Contains(txtSearch.Text.ToLower()));

            dgvProducts.DataSource = null;
            dgvProducts.DataSource = results;
        }
    }
}
