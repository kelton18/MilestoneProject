using System.Text;

namespace InventoryManager.Library
{
    public class InventoryManager
    {
        private List<CoffeeItem> inventoryList = new List<CoffeeItem>();
        public List<CoffeeItem> GetInventory()
        {
            return inventoryList;
        }


        public void ReadInventory(string filePath)
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                inventoryList.Clear();

                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 3 && int.TryParse(parts[2], out int qty))
                    {
                        inventoryList.Add(new CoffeeItem
                        {
                            Name = parts[0].Trim(),
                            Category = parts[1].Trim(),
                            Qty = qty
                        }); 
                    }
                }

            }
            else
            {
                throw new FileNotFoundException("The specified inventory file could not be found", filePath);
            }

        }

        public void IncrementItemQty(string itemName)
        {
            var item = inventoryList.FirstOrDefault(i => i.Name.Equals(itemName, StringComparison.OrdinalIgnoreCase));

            if (item != null)
            {
                item.Qty++; 
            }
            else
            {
                throw new ArgumentException("Item not found in Inventory");
            }

        }


        //private void SaveInventoryToFile(string filePath)
        //{
        //    var lines = inventoryList.Select(i => $"{i.Name},{i.Category},{i.Qty}");
        //    File.WriteAllLines(filePath, lines);
        //}
    }
}
