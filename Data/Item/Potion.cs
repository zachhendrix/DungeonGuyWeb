using System.Xml.Linq;

namespace Data.Item
{
    public class Potion(string name, string description, float weight)
               : Item(name, description, weight, ItemType.Armor)
    {
        public string Effect { get; set; } // e.g., "Healing", "Mana Restoration", etc.
        public int Duration { get; set; } // Duration in seconds
    }
}
