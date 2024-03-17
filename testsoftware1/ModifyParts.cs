using System;
using System.Windows.Forms;

namespace CraigJ_C968_InventoryManagementSystem.model
{
    public partial class ModifyParts : Form
    {
        private Inventory inventory;
        private Part dataBoundItem;
        public ModifyParts(Inventory inventory, Part dataBoundItem)
        {
            InitializeComponent();
            this.inventory = inventory;
            this.dataBoundItem = dataBoundItem;


            textBoxName.Text = dataBoundItem.Name;
            textBoxInstock.Text = dataBoundItem.Instock.ToString();
            textBoxMin.Text = dataBoundItem.Min.ToString();
            textBoxMax.Text = dataBoundItem.Max.ToString();
            textBoxPrice.Text = dataBoundItem.Price.ToString();

            if (dataBoundItem is Inhouse)
            {
                InHouse.Checked = true;
                textBoxMachineID.Text = ((Inhouse)dataBoundItem).MachineID.ToString();
            }
            else if (dataBoundItem is Outsourced)
            {
                OutSourced.Checked = true;
                textBoxCompanyName.Text = ((Outsourced)dataBoundItem).CompanyName;
            }

        }

        private void SaveModifyParts_Click(object sender, EventArgs e)
        {
            int min;
            int max;
            int InStock;
            decimal price;

            if (!int.TryParse(textBoxMin.Text, out min) ||
                !int.TryParse(textBoxMax.Text, out max) ||
                !int.TryParse(textBoxInstock.Text, out InStock) ||
                !decimal.TryParse(textBoxPrice.Text, out price))
            {
                MessageBox.Show("Error: Instock, Price, Max, and Min text fields must be numeric values.");
                return;
            }


            InStock = int.Parse(textBoxInstock.Text);
            min = int.Parse(textBoxMin.Text);
            max = int.Parse(textBoxMax.Text);
            price = decimal.Parse(textBoxPrice.Text);
            string name = textBoxName.Text;

            //exception handling
            if (min > max)
            {
                MessageBox.Show("Error: The min value can not be greater than max value.");
                return;
            }

            if (InStock > max || InStock < min)
            {
                MessageBox.Show("Error: Instock must be between max and min.");
                return;
            }

            if (InHouse.Checked)
            {
                int machineID;
                if (!int.TryParse(textBoxMachineID.Text, out machineID))
                {
                    MessageBox.Show("Error: Machine ID must be a numeric value.");
                    return;
                }

                Inhouse inPart = new Inhouse(Inventory.parts.Count + 1, name, price, InStock, min, max, int.Parse(textBoxMachineID.Text));
                Inventory.UpdatePart(dataBoundItem.PartID, inPart);
                InHouse.Checked = true;

            }
            else
            {

                string companyName = textBoxCompanyName.Text;

                Outsourced outPart = new Outsourced(Inventory.parts.Count + 1, name, price, InStock, min, max, textBoxCompanyName.Text);
                Inventory.UpdatePart(dataBoundItem.PartID, outPart);
                OutSourced.Checked = true;

            }
            Close();

        }

        private void InHouse_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = "Machine ID"; label6.Refresh();


            textBoxCompanyName.Visible = false;


            textBoxMachineID.Visible = true;
        }

        private void OutSourced_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = "Company Name"; label6.Refresh();

            textBoxCompanyName.Visible = true;


            textBoxMachineID.Visible = false;
        }
        private void CancelModifyParts_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
