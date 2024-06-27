namespace Assignment2;

public class Shopping
{
    public void ShopList()
    {
        List<string> items = new List<string>();
        while (true)
        {
            Console.WriteLine("Enter command (+ item, - item, or -- to clear):");
            string input = Console.ReadLine();
            if (input.StartsWith("+"))
            {
                items.Add(input.Substring(1).Trim());
            }
            else if (input.StartsWith("-"))
            {
                string itemToRemove = input.Substring(2).Trim();
                if (items.Contains(itemToRemove))
                {
                    items.Remove(itemToRemove);
                }
                else
                {
                    Console.WriteLine("Item not found.");
                }
            }
            else if (input == "--")
            {
                items.Clear();
            }
            
            else
            {
                Console.WriteLine("Invalid command. Please use + or - followed by an item, or -- to clear the list.");
                continue;
            }
            Console.WriteLine("Current list contents:");
            foreach (string item in items)
            {
                Console.WriteLine(item);
            }
        }

        }
    }
