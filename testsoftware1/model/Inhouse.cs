namespace CraigJ_C968_InventoryManagementSystem.model
{
    public class Inhouse : Part
    {
        public int MachineID { get; set; }
        public Inhouse() { }
        public Inhouse(int partID, string name, decimal price, int InStock, int min, int max)
        {
            PartID = partID;
            Name = name;
            Price = price;
            this.Instock = InStock;
            Min = min;
            Max = max;
        }
        public Inhouse(int partID, string name, decimal price, int instock, int min, int max, int MachineID) // need to change all instences of instock to Inventory also change dgvs
        {
            PartID = partID;
            Name = name;
            Price = price;
            this.Instock = instock;
            Min = min;
            Max = max;
            this.MachineID = MachineID;
        }
    }
}
