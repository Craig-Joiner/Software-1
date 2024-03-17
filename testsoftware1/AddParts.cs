using System.Windows.Forms;

namespace CraigJ_C968_InventoryManagementSystem.model
{
    public partial class AddParts : Form
    {
        public AddParts()
        {
            InitializeComponent();
        }

        private void OutSourced_CheckedChanged(object sender, System.EventArgs e)
        {
            label6.Text = "Company Name"; label6.Refresh();

            textBoxCompanyName.Visible = true;


            textBoxMachineID.Visible = false;

        }

        private void InHouse_CheckedChanged(object sender, System.EventArgs e)
        {
            label6.Text = "Machine ID"; label6.Refresh();


            textBoxCompanyName.Visible = false;


            textBoxMachineID.Visible = true;
        }
        private void SaveParts_Click(object sender, System.EventArgs e)
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

            string name = textBoxName.Text;

            if (InHouse.Checked)
            {
                int machineID;
                if (!int.TryParse(textBoxMachineID.Text, out machineID))
                {
                    MessageBox.Show("Error: Machine ID must be a numeric value.");
                    return;
                }

                Inhouse inPart = new Inhouse(Inventory.parts.Count + 1, name, price, InStock, min, max, int.Parse(textBoxMachineID.Text));
                Inventory.AddPart(inPart);

            }
            else
            {

                string companyName = textBoxCompanyName.Text;

                Outsourced outPart = new Outsourced(Inventory.parts.Count + 1, name, price, InStock, min, max, textBoxCompanyName.Text);
                Inventory.AddPart(outPart);

            }
            Close();

        }
        private void CancelParts_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
