using System;

namespace InventoryApp
{
    // SERVICE CLASS
    public class InventoryService
    {
        private string[,] products =
        {
            { "Laptop", "Mouse", "Keyboard", "Monitor" },
            { "10", "25", "15", "8" }
        };

        private string[,] originalProducts;

        public InventoryService()
        {
            originalProducts = (string[,])products.Clone();
        }

        public string[,] GetInventory()
        {
            return products;
        }

        public void UpdateStock(int index, int newStock)
        {
            if (index >= 0 && index < products.GetLength(1))
            {
                products[1, index] = newStock.ToString();
            }
        }

        public void ResetInventory()
        {
            products = (string[,])originalProducts.Clone();
        }
    }
