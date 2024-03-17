using System.Windows.Forms;
namespace CraigJ_C968_InventoryManagementSystem.model
{
    public partial class Main : Form
    {
        private Inventory inventoryInstance;
        public Main()
        {
            InitializeComponent();

            inventoryInstance = new Inventory();

            BindingSource bindingPart = new BindingSource();
            bindingPart.DataSource = Inventory.parts;
            dgvParts.DataSource = bindingPart;

            BindingSource bindingProduct = new BindingSource();
            bindingProduct.DataSource = Inventory.products;
            dgvProducts.DataSource = bindingProduct;

        }

        private void AddParts_Click(object sender, System.EventArgs e)
        {
            new AddParts().ShowDialog();
        }

        private void DeleteParts_Click(object sender, System.EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete? This cannot be undone.", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvParts.SelectedRows)
                {
                    dgvParts.Rows.RemoveAt(row.Index);
                }
            }
            else return;
        }
        private void textBoxParts_TextChanged(object sender, System.EventArgs e)
        {
            SearchParts.Enabled = !string.IsNullOrWhiteSpace(textBoxParts.Text);
        }
        private void SearchParts_Click(object sender, System.EventArgs e)
        {
            int searchValue;
            if (!int.TryParse(textBoxParts.Text, out searchValue) || searchValue < 1)
                return;

            Part match = Inventory.LookupPart(searchValue);

            foreach (DataGridViewRow row in dgvParts.Rows)
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

        private void ModifyParts_Click(object sender, System.EventArgs e)
        {
            if (dgvParts.SelectedRows.Count > 0)
            {
                var modifyPart = new ModifyParts(inventoryInstance, (Part)dgvParts.SelectedRows[0].DataBoundItem);
                modifyPart.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Select A Row To Modify", "Error");
            }

        }

        private void ModifyProducts_Click(object sender, System.EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select A Product To Modify", "Error");
                return;
            }

            Product selectedProduct = (Product)dgvProducts.SelectedRows[0].DataBoundItem;

            ModifyProduct ModifyProductForm = new ModifyProduct(selectedProduct);
            ModifyProductForm.ShowDialog();
        }

        private void AddProducts_Click(object sender, System.EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to Add.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Product selectedProduct = (Product)dgvProducts.SelectedRows[0].DataBoundItem;


            AddProduct addProductForm = new AddProduct(selectedProduct);
            addProductForm.ShowDialog();
        }

        private void SearchProducts_Click(object sender, System.EventArgs e)
        {
            {
                int searchValue;
                if (!int.TryParse(textBoxProducts.Text, out searchValue) || searchValue < 1)
                    return;

                Product match = Inventory.LookupProduct(searchValue);

                foreach (DataGridViewRow row in dgvProducts.Rows)
                {
                    Product products = (Product)row.DataBoundItem;
                    row.Selected = (products.ProductID == match.ProductID);

                    if (products.ProductID == match.ProductID)
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

        private void textBoxProducts_TextChanged(object sender, System.EventArgs e)
        {
            SearchProducts.Enabled = !string.IsNullOrWhiteSpace(textBoxProducts.Text);
        }
        private void DeleteProducts_Click(object sender, System.EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete? This cannot be undone.", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Product product = (Product)dgvProducts.CurrentRow.DataBoundItem;
                if (product.AssociatedParts.Count > 0)
                {
                    MessageBox.Show("Cannot delete product with associated parts. Please remove parts associated to this product.");
                    return;
                }
                foreach (DataGridViewRow row in dgvProducts.SelectedRows)
                {
                    dgvProducts.Rows.RemoveAt(row.Index);
                }
            }
            else return;
        }
        private void Exit_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}