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
    public partial class HomeForm : Form
    {
        BindingList<Book> inventory = new BindingList<Book>();

        public HomeForm()
        {
            InitializeComponent();
            LoadInventory();           
        }

        private void LoadInventory()
        {
            if (File.Exists("inventory.csv"))
            {
                string[] lines = File.ReadAllLines("inventory.csv");

                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');

                    Book book = new Book(parts[0], parts[1], int.Parse(parts[2]), parts[3], double.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]));

                    inventory.Add(book);
                }
            }
        }

        public void SaveInventory()
        {
            List<string> lines = new List<string>();

            foreach (Book book in inventory)
            {
                lines.Add($"{book.Title},{book.Author},{book.ReleaseDate},{book.Genre},{book.Price},{book.Stock},{book.CopiesSold}");
            }

            File.WriteAllLines("inventory.csv", lines);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void btnVisitInventory_Click(object sender, EventArgs e)
        {
            InventoryForm inventoryForm = new InventoryForm(inventory);
            inventoryForm.Tag = this;
            inventoryForm.Show();
            Hide();
        }

        private void btnBuildOrder_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm(inventory);
            orderForm.Tag = this;
            orderForm.Show();
            Hide();
        }
    }
}
