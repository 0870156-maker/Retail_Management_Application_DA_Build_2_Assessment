using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace IT_Assesment_Start
{
    public partial class InventoryForm : Form
    {
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

        private void SaveInventory()
        {
            List<string> lines = new List<string>();

            foreach (Book book in inventory)
            {
                lines.Add($"{book.Title}," + $"{book.Author}," + $"{book.ReleaseDate}," + $"{book.Genre}," + $"{book.Price}," + $"{book.Stock}," + $"{book.CopiesSold}");
            }

            File.WriteAllLines("inventory.csv", lines);
        }

        BindingList<Book> inventory = new BindingList<Book>();

        public InventoryForm()
        {
            InitializeComponent();

            LoadInventory();

            dgvInventory.DataSource = inventory;
        }

        private void btnAddBook_Click(object sender, EventArgs e)   
        {
            string title = txtTitle.Text;
            string author = txtAuthor.Text;
            string genre = txtGenre.Text;

            int releaseDate;
            double price;
            int stock;

            if (title == "" || author == "" || genre == "")
            {
                MessageBox.Show("No empty boxes!");
                return;
            }

            if (!int.TryParse(txtReleaseDate.Text, out releaseDate)) 
            {
                MessageBox.Show("Invalid release date!");
                return;
            }

            if (!double.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("Invalid price!");
                return;
            }

            if (!int.TryParse(txtStock.Text, out stock))
            {
                MessageBox.Show("Invalid stock!");
                return;
            }

            if (price < 0 || stock < 0)
            {
                MessageBox.Show("No negative values!");
                return;
            }

            Book newBook = new Book(title, author, releaseDate, genre, price, stock, 0);

            inventory.Add(newBook);

            SaveInventory();

            txtTitle.Clear();
            txtAuthor.Clear();
            txtReleaseDate.Clear();
            txtGenre.Clear();
            txtPrice.Clear();
            txtStock.Clear();            
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (dgvInventory.CurrentRow == null) 
            {
                MessageBox.Show("Nothing selected");
                return;
            }

            Book selectedBook = (Book)dgvInventory.CurrentRow.DataBoundItem;

            inventory.Remove(selectedBook);

            SaveInventory();
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            if (dgvInventory.CurrentRow == null)
            {
                MessageBox.Show("Nothing selected!");
                return;
            }

            Book selectedBook = (Book)dgvInventory.CurrentRow.DataBoundItem;

            selectedBook.Title = txtTitle.Text;
            selectedBook.Author = txtAuthor.Text;
            selectedBook.ReleaseDate = Convert.ToInt32(txtReleaseDate.Text);
            selectedBook.Genre = txtGenre.Text;
            selectedBook.Price = Convert.ToDouble(txtPrice.Text);
            selectedBook.Stock = Convert.ToInt32(txtStock.Text);

            SaveInventory();
            dgvInventory.Refresh();
        }

        private void dgvInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {              
            if (e.RowIndex < 0)
            {
                return;
            }
            Book selectedBook = (Book)dgvInventory.CurrentRow.DataBoundItem;

            txtTitle.Text = selectedBook.Title;
            txtAuthor.Text = selectedBook.Author;
            txtReleaseDate.Text = selectedBook.ReleaseDate.ToString();
            txtGenre.Text = selectedBook.Genre;
            txtPrice.Text = selectedBook.Price.ToString();
            txtStock.Text = selectedBook.Stock.ToString();
        }
    }   
}