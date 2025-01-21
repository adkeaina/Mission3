namespace Mission3
{
    public class FoodItem
    {
        private string name;
        private string category;
        private int quantity;
        private string expDate;
        
        public FoodItem(string inputName, string inputCategory, int inputQuantity, string inputExpDate)
        {
            name = inputName;
            category = inputCategory;
            quantity = inputQuantity;
            expDate = inputExpDate;
        }

        public string GetName()
        {
            return name;
        }

        public string PrintFoodItem()
        {
            string output = name + "\n";
            output += "Category: " + category + "\n";
            output += "Quantity: " + quantity + "\n";
            output += "Expiration Date: " + expDate + "\n";
            return output;
        }
    }
}