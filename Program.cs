// See https://aka.ms/new-console-template for more information

using Mission3;

Console.WriteLine("Welcome to your local food bank delivery system!\n");
Inventory inventory = new Inventory();
while (true)
{
    Console.WriteLine("Menu: ");
    Console.WriteLine("1. Add Food Items");
    Console.WriteLine("2. Delete Food Items");
    Console.WriteLine("3. Print List of Current Food Items");
    Console.WriteLine("4. Exit the Program\n");
    Console.Write("Pick your choice: ");
    string choice = Console.ReadLine();
    if (choice == "1") inventory.AddFoodItems();
    else if (choice == "2") inventory.DeleteFoodItems();
    else if (choice == "3") inventory.PrintFoodList();
    else if (choice == "4") break;
    else Console.WriteLine("Invalid choice, please try again!");
}

Console.WriteLine("Thank you for using this application!");