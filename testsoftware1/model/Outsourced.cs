namespace CraigJ_C968_InventoryManagementSystem.model
{
    public class Outsourced : Part
    {
        public string CompanyName { get; set; }
        public Outsourced(int partID, string name, decimal price, int Instock, int min, int max)
        {
            PartID = partID;
            Name = name;
            Price = price;
            this.Instock = Instock;
            Min = min;
            Max = max;
        }
        public Outsourced(int partID, string name, decimal price, int Instock, int min, int max, string companyName)
        {
            PartID = partID;
            Name = name;
            Price = price;
            this.Instock = Instock;
            Min = min;
            Max = max;
            this.CompanyName = companyName;
        }
    }
}
