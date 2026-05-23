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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVisitInventory_Click(object sender, EventArgs e)
        {
            InventoryForm inventoryform = new InventoryForm();
            inventoryform.Tag = this;
            inventoryform.Show(this);
            Hide();
        }
    }
}
