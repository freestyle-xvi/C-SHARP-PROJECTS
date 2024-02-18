using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsignmentShopLibrary;

namespace ConsignmentShop
{
    public partial class Form1 : Form
    {
        private Store store = new Store();
        private List<Item> shoppingCartData = new List<Item>();
        BindingSource itemsBinding = new BindingSource();
        BindingSource cartBinding = new BindingSource();
        BindingSource vendorsBinding = new BindingSource();
        private decimal storeProfit = 0;


        public Form1()
        {
            InitializeComponent();
            SetupData();

            itemsBinding.DataSource = store.Items.Where(x =>x.Sold == false).ToList();
            itemsListBox.DataSource = itemsBinding;

            itemsListBox.DisplayMember = "Display";
            itemsListBox.ValueMember = "Display";

            cartBinding.DataSource = shoppingCartData;
            shoppingCartListBox.DataSource = cartBinding;

            shoppingCartListBox.DisplayMember = "Display";
            shoppingCartListBox.ValueMember = "Display";

            vendorsBinding.DataSource = store.Vendors;
            vendorsListBox.DataSource = vendorsBinding;

            vendorsListBox.DisplayMember = "Display";
            vendorsListBox.ValueMember = "Display";

        }
        private void SetupData()
        {
            store.Vendors.Add(new Vendor { FirstName = "Phoenix", LastName = "Callahan" });
            store.Vendors.Add(new Vendor { FirstName = "Freestyle", LastName = "XVI" });

            store.Items.Add(new Item
            {
                Title = "Harry Potter and the Sorcerers stone",
                Description = "a book about a wizard",
                Price = 237,
                Owner = store.Vendors[0]
            });

            store.Items.Add(new Item
            {
                Title = "Harry Potter and the Chamber of Secrets",
                Description = "a book about a wizard",
                Price = 175,
                Owner = store.Vendors[1]
            });

            store.Items.Add(new Item
            {
                Title = "Harry Potter and the Prisoner of Azkabaan",
                Description = "a book about a wizard",
                Price = 148,
                Owner = store.Vendors[0]
            });
            

            store.Items.Add(new Item
            {
                Title = "Harry Potter and the Goblet of Fire",
                Description = "a book about a wizard",
                Price = 115,
                Owner = store.Vendors[1]
            });

            store.Items.Add(new Item
            {
                Title = "Harry Potter and the Order of the Phoenix",
                Description = "a book about a wizard",
                Price = 200,
                Owner = store.Vendors[0]
            });

            store.Items.Add(new Item
            {
                Title = "Harry Potter and the Half Blood Prince",
                Description = "a book about a wizard",
                Price = 150,
                Owner = store.Vendors[1]
            });

            store.Items.Add(new Item
            {
                Title = "Harry Potter and the Deathly Hallows",
                Description = "a book about a wizard",
                Price = 195,
                Owner = store.Vendors[0]
            });


            store.Items.Add(new Item
            {
                Title = "Percy Jackson : The Lightning Thief",
                Description = " a book about a half boy half god, son of of Poseidon",
                Price = 120,
                Owner = store.Vendors[1]
            });

            store.Items.Add(new Item
            {
                Title = "Percy Jackson : The Sea of Monsters",
                Description = " a book about a half boy half god, son of of Poseidon",
                Price = 90,
                Owner = store.Vendors[0]
            });

            store.Items.Add(new Item
            {
                Title = "Percy Jackson : The Titans curse",
                Description = " a book about a half boy half god, son of of Poseidon",
                Price = 105,
                Owner = store.Vendors[1]
            });

            store.Items.Add(new Item
            {
                Title = "Percy Jackson : The Battle of the labyrinth",
                Description = " a book about a half boy half god, son of of Poseidon",
                Price = 135,
                Owner = store.Vendors[0]
            });

            store.Items.Add(new Item
            {
                Title = "Percy Jackson : The Last olympian",
                Description = " a book about a half boy half god, son of of Poseidon",
                Price = 110,
                Owner = store.Vendors[1]
            });

            
            store.Name = "XVI Books ";

        }

        private void addToCart_Click(object sender, EventArgs e)
        {
            Item selectedItem = (Item) itemsListBox.SelectedItem;

            shoppingCartData.Add(selectedItem);
            cartBinding.ResetBindings(false);
        }

        private void makePurchase_Click(object sender, EventArgs e)
        {
            foreach (Item item in shoppingCartData)
            {
                item.Sold = true;
                item.Owner.PaymentDue += (decimal)item.Owner.Commission * item.Price;
                storeProfit += (1 - (decimal)item.Owner.Commission) * item.Price;
            }
            shoppingCartData.Clear();

            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();

            storeProfitValue.Text = string.Format("R{0}", storeProfit);

            cartBinding.ResetBindings(false);
            itemsBinding.ResetBindings(false);
            vendorsBinding.ResetBindings(false);

        }

        private void storeProfitValue_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
