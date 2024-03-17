using System.ComponentModel;
using System.Linq;

namespace CraigJ_C968_InventoryManagementSystem.model
{
    public class Product
    {

        public BindingList<Part> AssociatedParts = new BindingList<Part>();
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public Product()
        {

        }
        public Product(int productID, string name, decimal price, int instock, int min, int max)
        {
            ProductID = productID;
            Name = name;
            Price = price;
            InStock = instock;
            Min = min;
            Max = max;
        }
        public void AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public bool RemoveAssociatedPart(int PartID)
        {
            Part partToRemove = AssociatedParts.FirstOrDefault(part => part.PartID == PartID);
            if (partToRemove != null)
            {
                AssociatedParts.Remove(partToRemove);
                return true;
            }

            return false;
        }
        public Part LookupAssociatedPart(int partID)
        {
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            Inhouse emptyInhouse = new Inhouse();
            return emptyInhouse;
        }
    }
}
