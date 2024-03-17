using System;
using System.Windows.Forms;

namespace CraigJ_C968_InventoryManagementSystem.model
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Inventory inventoryInstance = new Inventory();

            Inhouse partInstance = new Inhouse(1, "Brake Caliper", 5.00m, 5, 1, 10);
            Inventory.AddPart(partInstance);

            Inhouse partInstance1 = new Inhouse(2, "Brake Rotor", 5.00m, 5, 1, 10);
            Inventory.AddPart(partInstance1);

            Outsourced partInstance2 = new Outsourced(3, "Front Brake Pads", 5.00m, 5, 1, 10);
            Inventory.AddPart(partInstance2);

            Outsourced partInstance3 = new Outsourced(4, "Rear Brake Pads", 5.00m, 5, 1, 10);
            Inventory.AddPart(partInstance3);

            Product product = new Product(1, "Car", 5.00m, 5, 1, 10);
            Inventory.AddProduct(product);

            Product product1 = new Product(2, "Truck", 5.00m, 5, 1, 10);
            Inventory.AddProduct(product1);

            Product product2 = new Product(3, "Motorcycle", 5.00m, 5, 1, 10);
            Inventory.AddProduct(product2);

            Product product3 = new Product(4, "Sand Rail", 5.00m, 5, 1, 10);
            Inventory.AddProduct(product3);

            product.AddAssociatedPart(partInstance);
            product1.AddAssociatedPart(partInstance1);
            product2.AddAssociatedPart(partInstance2);
            product3.AddAssociatedPart(partInstance3);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
