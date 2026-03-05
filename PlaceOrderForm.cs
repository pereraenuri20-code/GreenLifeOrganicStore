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
    public partial class PlaceOrderForm : Form
    {
        public PlaceOrderForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PlaceOrderForm_Load(object sender, EventArgs e)
        {
            cmbProducts.DataSource = DataStore.Products;
            cmbProducts.DisplayMember = "Name";
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Product product = (Product)cmbProducts.SelectedItem;
            int qty = int.Parse(txtQuantity.Text);

            Order order = new Order
            {
                OrderID = DataStore.Orders.Count + 1,
                ProductName = product.Name,
                Quantity = qty,
                TotalPrice = product.Price * qty,
                Status = "Pending",
                OrderDate = DateTime.Now,
            };

            DataStore.Orders.Add(order);
            MessageBox.Show("Order placed successfully");
        }
    }
}
