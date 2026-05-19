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
    public partial class InventoryForm : Form
    {
        List<Book> inventory = new List<Book>();

        public InventoryForm()
        {

            InitializeComponent();

            inventory.Add(new Book("To Kill a Mockingbird", "Lee, Harper", 1960, "Gothic", 19.99, 10, 0));
            inventory.Add(new Book("Frankenstein", "Shelley, Mary", 1818, "Gothic", 24.99, 5, 0));
            inventory.Add(new Book("Dracula", "Stoker, Bram", 1897, "Gothic", 24.99, 5, 0));
            inventory.Add(new Book("The Raven", "Poe, Edgar Allan", 1845, "Gothic", 24.99, 5, 0));
            inventory.Add(new Book("Wuthering Heights", "Bronte, Emily", 1847, "Gothic", 50.00, 1, 0));

            dgvInventory.DataSource = null;
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

            dgvInventory.DataSource = null;
            dgvInventory.DataSource = inventory;

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

            dgvInventory.DataSource = null;
            dgvInventory.DataSource = inventory;
        }

        private void dgvInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvInventory.CurrentRow != null)
            {
                Book selectedBook = (Book)dgvInventory.CurrentRow.DataBoundItem;

                txtTitle.Text = selectedBook.Title;
                txtAuthor.Text = selectedBook.Author;
                txtReleaseDate.Text = selectedBook.ReleaseDate.ToString();
                txtGenre.Text = selectedBook.Genre;
                txtPrice.Text = selectedBook.Price.ToString();
                txtStock.Text = selectedBook.Stock.ToString();
            }
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            if (dgvInventory.CurrentRow == null)
            {
                MessageBox.Show("Select a book first");
                return;
            }

            Book selectedBook = (Book)dgvInventory.CurrentRow.DataBoundItem;

            selectedBook.Title = txtTitle.Text;
            selectedBook.Author = txtAuthor.Text;
            selectedBook.ReleaseDate = Convert.ToInt32(txtReleaseDate.Text);
            selectedBook.Genre = txtGenre.Text;
            selectedBook.Price = Convert.ToInt32(txtPrice);
            selectedBook.Stock = Convert.ToInt32(txtStock);

            if (txtTitle.Text == "" || txtAuthor.Text == "" || txtGenre.Text == "")
            {
                MessageBox.Show("No empty boxes!");
                return;
            }

            dgvInventory.DataSource = null;
            dgvInventory.DataSource = inventory;
        }
    }
}
