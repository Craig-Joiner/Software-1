using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace CraigJ_C968_InventoryManagementSystem.model
{
    public class Inventory
    {
        public static BindingList<Product> products = new BindingList<Product>();
        public static BindingList<Part> parts = new BindingList<Part>();

        public static void AddPart(Part part)
        {
            parts.Add(part);
        }

        public static bool DeletePart(int part)
        {
            Part partToDelete = LookupPart(part);
            if (partToDelete == null)
            {
                return false;
            }
            else
            {
                parts.Remove(partToDelete);
                return true;
            }
        }
        public static Part LookupPart(int partID)
        {
            foreach (Part part in parts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            Part emptyPart = new Inhouse();
            return emptyPart;
        }

        public static void UpdatePart(int partID, Part part)
        {
            DeletePart(partID);
            AddPart(part);
        }

        public static void AddProduct(Product product)
        {
            products.Add(product);
        }

        public static bool DeleteProduct(int ProductID)
        {
            bool result = false;

            Product productToRemove = products.FirstOrDefault(product => product.ProductID == ProductID);

            if (productToRemove != null)
            {
                int index = products.IndexOf(productToRemove);
                if (index != -1)
                {
                    products.RemoveAt(index);
                    result = true;
                }
                else
                {
                    MessageBox.Show("Error: Removal failed!");
                }
            }
            else
            {
                MessageBox.Show("Error: Product not found!");
            }

            return result;
        }

        public static Product LookupProduct(int ProductID)
        {
            foreach (Product product in products)
            {
                if (product.ProductID == ProductID)
                {
                    return product;
                }
            }
            Product emptyProduct = new Product();
            return emptyProduct;
        }

        public static void UpdateProduct(int productID, Product updatedProduct)
        {
            foreach (Product currentProduct in products)
            {
                if (currentProduct.ProductID == productID)
                {
                    currentProduct.Name = updatedProduct.Name;
                    currentProduct.InStock = updatedProduct.InStock;
                    currentProduct.Price = updatedProduct.Price;
                    currentProduct.Max = updatedProduct.Max;
                    currentProduct.Min = updatedProduct.Min;
                    currentProduct.AssociatedParts = updatedProduct.AssociatedParts;
                    return;
                }
            }
        }

    }
}


