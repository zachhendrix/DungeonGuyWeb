namespace Data.Item
{
    public class Item
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public float? Weight { get; set; }
        public ItemType? Type { get; set; }

        public Item() { }

        public Item(string name, string description, float? weight, ItemType type)
        {
            Name = name;
            Description = description;
            Weight = weight;
            Type = type;
        }

        public enum ItemType
        {
            Weapon,
            Armor,
            Potion
        }
    }
}
