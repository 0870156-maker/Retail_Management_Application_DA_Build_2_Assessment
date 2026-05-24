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

            UpdateTotal();
        }
        private void OrderForm_Load(object sender, EventArgs e)
        { }

        private void UpdateTotal()
        {
            lblTotal.Text = $"Total: {cart.Sum(item => item.Total):0.00}";
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

            txtQuantity.Clear();
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

            foreach (Order order in cart)
            {
                order.Book.CopiesSold += order.Quantity;
            }
                
            HomeForm home = (HomeForm)this.Tag;
            home.SaveInventory();
            
            cart.Clear();
            UpdateTotal();

            MessageBox.Show("Order successful!");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = (HomeForm)this.Tag;
            homeForm.Show();
            Close();
        }
    }
}
