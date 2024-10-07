using Character.Equipment;

namespace Data.Itemization
{
    public class Armor(string name, string description, float weight, int defense, float condition, Armor.MaterialTypeEnum material, Equipment.Slot slot) 
               : ItemObject(name, description, weight, ItemType.Armor)
    {
        public int Defense { get; set; } = defense;
        public float Condition { get; set; } = condition;
        public MaterialTypeEnum Material { get; set; } = material;
        public Equipment.Slot Slot { get; set; } = slot;

        // Enum for Material Types
        public enum MaterialTypeEnum
        {
            Bronze,
            Iron,
            Steel,
            Adamantium,
            Mithril
        }
    }
}
