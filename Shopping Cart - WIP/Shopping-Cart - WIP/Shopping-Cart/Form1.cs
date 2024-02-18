using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_Cart
{
    public partial class frmShoppingCart : Form
    {
        public frmShoppingCart()
        {
            InitializeComponent();
        }

        int itemsOrdered;
        const int numberOfProducts = 10;
        Product[] products = new Product[numberOfProducts];



        private void Form1_Load(object sender, EventArgs e)
        {
            products[0] = new Product("Gaming PC (Pre-Built)", 18500);
            products[1] = new Product("Monitor", 3500);
            products[2] = new Product("Mechanical Keyboard", 850);
            products[3] = new Product("Logitech G-Pro Wireless", 2872);
            products[4] = new Product("Logitech G-502", 1900);
            products[5] = new Product("Steelseries Arctis headset", 2000);
            products[6] = new Product("SkypadGaming Mousepad", 1912);
            products[7] = new Product("Blue Yeti mic", 7400);
            products[8] = new Product("Headphone stand", 450);
            products[9] = new Product("Logitech Z207 Speakers", 1200);

            for (int i = 0; i < numberOfProducts; i++)
            {
                dudProducts.Items.Add(products[i].Description);
            }
            dudProducts.SelectedIndex = 0;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            txtOrderAddress.Text = "";
            itemsOrdered = 0;
            lblItemsOrdered.Text = "Items ordered : 0";

            for (int i = 0; i < numberOfProducts; i++)
            {
                products[i].NumberOrdered = 0;
            }
            dudProducts.SelectedIndex = 0;
            lstProducts.Items.Clear();
            lblTotalCost.Text = "Total Cost";
            txtMailingLabel.Text = "";
        }

         private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            products[dudProducts.SelectedIndex].NumberOrdered++;
            itemsOrdered++;
            lblItemsOrdered.Text = "Items ordered : " + itemsOrdered.ToString();
        }

        private void tabShoppingCart_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(tabOrderForm.SelectedIndex)
            {
                case 1:
                    if(itemsOrdered == 0)
                    {
                        MessageBox.Show("No items ordered","Invalid order", MessageBoxButtons.OK, MessageBoxIcon.Error );
                        tabOrderForm.SelectedIndex = 0;
                    }
                      
            }
        }
    }  

}
        
    

