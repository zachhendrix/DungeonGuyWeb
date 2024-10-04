namespace Data.Itemization
{
    public class Potion(string name, string description, float weight)
               : ItemObject(name, description, weight, ItemType.Armor)
    {
        public string Effect { get; set; } // e.g., "Healing", "Mana Restoration", etc.
        public int Duration { get; set; } // Duration in seconds
    }
}
