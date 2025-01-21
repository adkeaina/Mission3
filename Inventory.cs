namespace Mission3;

public class Inventory
{
    private List<FoodItem> foodList = new();

    public void AddFoodItems()
    {
        // intake params
        Console.Write("\nName of the food items to add: ");
        string inputName = Console.ReadLine();
        Console.Write($"Category of {inputName}: ");
        string inputCategory = Console.ReadLine();
        int inputQuantity;
        while (true) // verifies input is a positive integer
        {
            Console.Write($"Quantity of {inputName}: ");
            string quantity = Console.ReadLine();
            if (int.TryParse(quantity, out inputQuantity) && inputQuantity > 0) break;
            Console.WriteLine("Please enter a valid positive integer.");
        }
        Console.Write($"Expiration Date of {inputName}: ");
        string inputExpDate = Console.ReadLine();
        
        // create new foodItem
        FoodItem foodItem = new FoodItem(inputName, inputCategory, inputQuantity, inputExpDate);
        
        // add it to list
        foodList.Add(foodItem);
        Console.WriteLine($"\n{foodItem} was added to the inventory.\n");
    }
    public void DeleteFoodItems()
    {
        if (foodList.Count == 0)
        {
            Console.WriteLine("\nThere is no inventory available to delete.\n");
            return;
        }
        
        Console.Write("\nName of the food items to delete: ");
        string foodName = Console.ReadLine();
        for (int i = 0; i < foodList.Count; i++)
        {
            string name = foodList[i].GetName();
            if (name.ToLower() == foodName.ToLower())
            {
                foodList.RemoveAt(i);
                Console.WriteLine($"\n{foodName} was removed from the inventory.\n");
                return;
            }
        }
        Console.WriteLine($"\nNo food with name '{foodName}' exists.\n");
    }

    public void PrintFoodList()
    {
        if (foodList.Count == 0)
        {
            Console.WriteLine("\nThere is no inventory available.\n");
            return;
        }
        Console.WriteLine("\nInventory:\n");
        foreach (var foodItem in foodList)
        {
            Console.WriteLine( foodItem.PrintFoodItem() + '\n');
        }
        Console.Write("[Press Enter to continue]:");
        Console.ReadLine();
        Console.WriteLine();
    }

}