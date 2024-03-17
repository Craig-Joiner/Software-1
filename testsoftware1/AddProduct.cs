using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CraigJ_C968_InventoryManagementSystem.model
{
    public partial class AddProduct : Form
    {
        BindingList<Part> AddedParts = new BindingList<Part>();
        public AddProduct(Product product)
        {
            InitializeComponent();
            AddAllParts();

        }
        private void AddAllParts()
        {
            AllPart.DataSource = Inventory.parts;
            AllPart.ClearSelection();
        }
        private void AddProductButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in AllPart.SelectedRows)
            {
                Part part = (Part)row.DataBoundItem;
                AddedParts.Add(part);
            }

            PartsProducts.DataSource = AddedParts;
        }

        private void SaveAddProduct_Click(object sender, EventArgs e)
        {
            int instock;
            int min;
            int max;
            decimal price;

            string name = textBoxName.Text;

            if (!int.TryParse(textBoxMin.Text, out min) ||
              !int.TryParse(textBoxMax.Text, out max) ||
              !int.TryParse(textBoxInstock.Text, out instock) ||
              !decimal.TryParse(textBoxPrice.Text, out price))
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
            if (string.IsNullOrEmpty(textBoxProductID.Text))
            {

                product = new Product(Inventory.products.Count + 1, name, price, instock, min, max);
                foreach (Part part in AddedParts)
                {
                    product.AddAssociatedPart(part);
                }
                Inventory.AddProduct(product);
            }

            else
            {

                int id = int.Parse(textBoxProductID.Text);

                product = Inventory.LookupProduct(id);
                if (product != null)
                {
                    product.Name = name;
                    product.Price = price;
                    product.InStock = instock;
                    product.Min = min;
                    product.Max = max;
                    product.AssociatedParts.Clear();
                    foreach (Part part in AddedParts)
                    {
                        product.AddAssociatedPart(part);
                    }
                    Inventory.UpdateProduct(id, product);
                }
            }


            Close();
        }
        private void SearchProduct_Click(object sender, EventArgs e)
        {
            {
                int searchValue;
                if (!int.TryParse(textBoxProduct.Text, out searchValue) || searchValue < 1)
                    return;

                Part match = Inventory.LookupPart(searchValue);

                foreach (DataGridViewRow row in AllPart.Rows)
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
        }

        private void textBoxProduct_TextChanged(object sender, EventArgs e)
        {
            SearchProduct.Enabled = !string.IsNullOrWhiteSpace(textBoxProduct.Text);
        }

        private void DeleteProductButton_Click(object sender, EventArgs e)
        {
            {
                DialogResult result = MessageBox.Show("Do you want to delete? This cannot be undone.", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in PartsProducts.SelectedRows)
                    {
                        PartsProducts.Rows.RemoveAt(row.Index);
                    }
                }
                else return;
            }
        }
        private void CancelProduct_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
