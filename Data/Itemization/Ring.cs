using Data.Character;

namespace Data.Itemization
{
    public class Ring(string name, string description, float weight, int baseValue, Equipment.Slot slot)
               : ItemObject(name, description, weight, baseValue, ItemType.Ring)
    {
        public string Effect { get; set; } // e.g., "Healing", "Mana Restoration", etc.
        public int Duration { get; set; } // Duration in seconds
        public Equipment.Slot Slot { get; set; } = slot;
    }
}
