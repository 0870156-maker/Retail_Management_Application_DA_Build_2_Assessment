using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_Assesment_Start
{
    public partial class OrderForm : Form
    {
        BindingList<Order> cart = new BindingList<Order>();
        BindingList<Book> inventory;

        public OrderForm(BindingList<Book> inventoryList)
        {   
            InitializeComponent();

            inventory = inventoryList;

            dgvInventory.DataSource = inventory;
            dgvCart.DataSource = cart;
        }
        private void OrderForm_Load(object sender, EventArgs e)
        { 
        
        }

        private void UpdateTotal()
        {
            lblTotal.Text = cart.Sum(cart => cart.Total).ToString("0.00");
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (dgvInventory.CurrentRow == null)
            {
                MessageBox.Show("Nothing selected!");
                return;
            }

            Book selectedBook = (Book)dgvInventory.CurrentRow.DataBoundItem;

            int quantity;
            if (!int.TryParse(txtQuantity.Text, out quantity) || quantity <= 0)
            {
                MessageBox.Show("Invalid quantity!");
                return;
            }

            if (quantity > selectedBook.Stock)
            {
                MessageBox.Show("Not enough stock!");
                return;
            }

            selectedBook.Stock -= quantity;
            cart.Add(new Order(selectedBook, quantity));

            dgvInventory.Refresh();

            UpdateTotal();
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (dgvCart.CurrentRow == null)
                return;

            Order selected = (Order)dgvCart.CurrentRow.DataBoundItem;

            cart.Remove(selected);

            UpdateTotal();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (cart.Count == 0)
            {
                MessageBox.Show("Cart is empty!");
                return;
            }

            cart.Clear();
            UpdateTotal();

            MessageBox.Show("Order successful!");
        }
    }
}
