using System;

namespace InventoryManagementApp
{
    // ================= SERVICE (LOGIC) =================
    public class InventoryService
    {
        private string[,] products;
        private int[] initialStock;

        public InventoryService()
        {
            products = new string[2, 3]
            {
                { "Apples", "Milk", "Bread" },
                { "10", "5", "20" }
            };

            initialStock = new int[] { 10, 5, 20 };
        }

        public string[,] GetProducts()
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
            for (int i = 0; i < initialStock.Length; i++)
            {
                products[1, i] = initialStock[i].ToString();
            }
        }
    }
