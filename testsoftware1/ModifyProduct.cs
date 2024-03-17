using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CraigJ_C968_InventoryManagementSystem.model
{
    public partial class ModifyProduct : Form
    {
        BindingList<Part> AddParts = new BindingList<Part>();

        public ModifyProduct(Product product)
        {
            InitializeComponent();

            ProductIDtextbox.Text = product.ProductID.ToString();
            ProductNametextbox.Text = product.Name;
            ProductInstocktextbox.Text = product.InStock.ToString();
            ProductPricetextbox.Text = product.Price.ToString();
            ProductMintextbox.Text = product.Min.ToString();
            ProductMaxtextbox.Text = product.Max.ToString();


            AddAllPart();
            AddParts.Clear();



            foreach (Part part in product.AssociatedParts)
            {
                AddParts.Add(part);
            }

            var AssociatedTable = new BindingSource();
            AssociatedTable.DataSource = AddParts;
            Parts_Products.DataSource = AssociatedTable;
        }

        private void AddAllPart()
        {
            AllParts.DataSource = Inventory.parts;
            AllParts.ClearSelection();
        }
        private void Save1_Click(object sender, EventArgs e)
        {

            int instock;
            int min;
            int max;
            decimal price;

            int id = int.Parse(ProductIDtextbox.Text);
            string name = ProductNametextbox.Text;

            if (!int.TryParse(ProductMintextbox.Text, out min) ||
               !int.TryParse(ProductMaxtextbox.Text, out max) ||
               !int.TryParse(ProductInstocktextbox.Text, out instock) ||
               !decimal.TryParse(ProductPricetextbox.Text, out price))
            {
                MessageBox.Show("Error: Instock, Price, Max, and Min text fields must be numeric values.");
                return;
            }
            if (min > max)
            {
                MessageBox.Show("Error: The min value can not be greater than max value.");
                return;
            }

            if (instock < min || instock > max)
            {
                MessageBox.Show("Error: Instock must be between max and min.");
                return;
            }

            Product product;
            if (id == 0)
            {
                product = new Product(Inventory.products.Count + 1, name, price, instock, min, max);
                foreach (Part part in AddParts)
                {
                    product.AddAssociatedPart(part);
                }
                Inventory.AddProduct(product);
            }
            else
            {

                product = Inventory.LookupProduct(id);
                if (product != null)
                {
                    product.Name = name;
                    product.Price = price;
                    product.InStock = instock;
                    product.Min = min;
                    product.Max = max;
                    product.AssociatedParts.Clear();
                    foreach (Part part in AddParts)
                    {
                        product.AddAssociatedPart(part);
                    }
                    Inventory.UpdateProduct(id, product);
                }
            }

            Close();
        }
        private void AddAllParts_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in AllParts.SelectedRows)
            {
                Part part = (Part)row.DataBoundItem;
                AddParts.Add(part);
            }
        }
        private void SearchAllParts_Click(object sender, EventArgs e)
        {
            int searchValue;
            if (!int.TryParse(textBoxProduct1.Text, out searchValue) || searchValue < 1)
                return;

            Part match = Inventory.LookupPart(searchValue);

            foreach (DataGridViewRow row in AllParts.Rows)
            {
                Part part = (Part)row.DataBoundItem;
                row.Selected = (part.PartID == match.PartID);

                if (part.PartID == match.PartID)
                {
                    row.Selected = true;
                    break;
                }
                else
                {
                    row.Selected = false;
                }
            }
        }
        private void textBoxProduct1_TextChanged(object sender, EventArgs e)
        {
            SearchAllParts.Enabled = !string.IsNullOrWhiteSpace(textBoxProduct1.Text);
        }

        private void DeletePartsProducts_Click(object sender, EventArgs e) // might want to see about making a change here
        {
            DialogResult result = MessageBox.Show("Do you want to delete? This cannot be undone.", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Part part = (Part)Parts_Products.CurrentRow?.DataBoundItem; // Null conditional operator added here

                if (part != null)
                {
                    int productId = int.Parse(ProductIDtextbox.Text);
                    Product product = Inventory.LookupProduct(productId);
                    product.RemoveAssociatedPart(part.PartID);

                    AddParts.Remove(part);

                    // Check if a row is selected before attempting to remove it
                    if (Parts_Products.CurrentRow != null)
                    {
                        Parts_Products.Rows.RemoveAt(Parts_Products.CurrentRow.Index);
                    }
                }
            }
        }
        private void Cancel1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
