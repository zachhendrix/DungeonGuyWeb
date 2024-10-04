using System.Xml.Linq;

namespace Data.Item
{
    public class Armor(string name, string description, float weight, int defense, float condition, Armor.MaterialTypeEnum material) 
               : Item(name, description, weight, ItemType.Armor)
    {
        public int Defense { get; set; } = defense;
        public float Condition { get; set; } = condition;
        public MaterialTypeEnum Material { get; set; } = material;

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
