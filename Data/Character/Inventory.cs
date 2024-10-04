namespace Data.Character
{
    public class Inventory
    {
        public List<Item>? Items { get; set; }

        public void AddItem(Item item) => Items?.Add(item);
        public void RemoveItem(Item item) => Items?.Remove(item);
    }
}
