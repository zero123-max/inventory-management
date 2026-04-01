    public class InventoryView
    {
        private InventoryService service;

        public InventoryView()
        {
            service = new InventoryService();
        }

        public void Run()
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("=== INVENTORY MANAGEMENT SYSTEM ===");
                Console.WriteLine("1. View Inventory");
                Console.WriteLine("2. Update Stock");
                Console.WriteLine("3. Reset Inventory");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ShowInventory();
                        break;

                    case "2":
                        UpdateStock();
                        break;

                    case "3":
                        ResetInventory();
                        break;

                    case "4":
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        Pause();
                        break;
                }
            }
        }

        private void ShowInventory()
        {
            Console.Clear();
            Console.WriteLine("=== INVENTORY LIST ===");

            var products = service.GetProducts();

            for (int i = 0; i < products.GetLength(1); i++)
            {
                Console.WriteLine($"{i + 1}. {products[0, i]} - Stock: {products[1, i]}");
            }

            Pause();
        }

        private void UpdateStock()
        {
            Console.Clear();
            ShowInventory();

            Console.Write("\nSelect product number: ");
            if (int.TryParse(Console.ReadLine(), out int index))
            {
                Console.Write("Enter new stock: ");
                if (int.TryParse(Console.ReadLine(), out int newStock))
                {
                    service.UpdateStock(index - 1, newStock);
                    Console.WriteLine("Stock updated successfully!");
                }
                else
                {
                    Console.WriteLine("Invalid stock input!");
                }
            }
            else
            {
                Console.WriteLine("Invalid product number!");
            }

            Pause();
        }

        private void ResetInventory()
        {
            service.ResetInventory();
            Console.WriteLine("Inventory reset successfully!");
            Pause();
        }

        private void Pause()
        {
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
