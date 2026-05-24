using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace IT_Assesment_Start
{
    public partial class OrderForm : Form
    {
        BindingList<Order> cart = new BindingList<Order>();
        BindingList<Book> inventory;

        private HomeForm home;

        public OrderForm(BindingList<Book> inventoryList, HomeForm homeform)
        {   
            InitializeComponent();

            inventory = inventoryList;
            home = homeform;

            dgvInventory.DataSource = inventory;
            dgvCart.DataSource = cart;

            UpdateTotal();

            this.WindowState = FormWindowState.Maximized;
        }
        private void OrderForm_Load(object sender, EventArgs e)
        { 
        
        }

        private void GenerateReceipt()
        {
            List<string> receipt = new List<string>();

            receipt.Add("Receipt:");
            receipt.Add("");

            foreach (Order order in cart)
            {
                receipt.Add($"{order.Book.Title}x{order.Quantity}: {order.Total:0.00}");
            }

            receipt.Add("");
            receipt.Add($"Total: ${cart.Sum(item => item.Total):0.00}");
            receipt.Add($"Date: {DateTime.Now}");
            string fileName = $"Receipt_{DateTime.Now:yyyyMMdd_HHmmss}.txt";
            File.WriteAllLines(fileName, receipt);
        }

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
            selected.Book.Stock += selected.Quantity;

            UpdateTotal();
            dgvInventory.Refresh();
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

            double saleTotal = cart.Sum(i => i.Total);            
            
            home.Revenue += saleTotal;
            home.UpdateRevenueLabel();
            home.SaveInventory();

            GenerateReceipt();
            cart.Clear();
            UpdateTotal();
            dgvInventory.Refresh();

            MessageBox.Show("Order successful!");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            home.Show();
            Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();

            var filtered = inventory.Where(o => o.Title.ToLower().Contains(searchText) || o.Author.ToLower().Contains(searchText) || o.Genre.ToLower().Contains(searchText)).ToList();

            dgvInventory.DataSource = new BindingList<Book>(filtered);
        }
    }
}