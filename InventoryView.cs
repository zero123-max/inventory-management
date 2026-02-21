        private void ViewInventory()
        {
            Console.Clear();
            Console.WriteLine("=== CURRENT INVENTORY ===");

            string[,] products = inventoryService.GetInventory();

            for (int i = 0; i < products.GetLength(1); i++)
            {
                Console.WriteLine($"{i + 1}. {products[0, i]} - Stock: {products[1, i]}");
            }

            Pause();
        }

        private void UpdateStock()
        {
            Console.Clear();
            ViewInventoryWithoutPause();

            Console.Write("Select product number to update: ");
            if (int.TryParse(Console.ReadLine(), out int productNumber))
            {
                Console.Write("Enter new stock quantity: ");
                if (int.TryParse(Console.ReadLine(), out int newStock))
                {
                    inventoryService.UpdateStock(productNumber - 1, newStock);
                    Console.WriteLine("Stock updated successfully.");
                }
                else
                {
                    Console.WriteLine("Invalid stock input.");
                }
            }
            else
            {
                Console.WriteLine("Invalid product selection.");
            }

            Pause();
        }

        private void ViewInventoryWithoutPause()
        {
            Console.WriteLine("=== CURRENT INVENTORY ===");

            string[,] products = inventoryService.GetInventory();

            for (int i = 0; i < products.GetLength(1); i++)
            {
                Console.WriteLine($"{i + 1}. {products[0, i]} - Stock: {products[1, i]}");
            }
        }
