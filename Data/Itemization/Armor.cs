using Character.Equipment;

namespace Data.Itemization
{
    public class Armor : ItemObject
    {
        public int Defense { get; set; }
        public float Condition { get; set; }
        public MaterialTypeEnum Material { get; set; }
        public Equipment.Slot Slot { get; set; }

        public enum MaterialTypeEnum
        {
            Bronze,
            Iron,
            Steel,
            Adamantium,
            Mithril
        }

        public Armor(string name,
            string description,
            float weight, int defense,
            float condition,
            MaterialTypeEnum material,
            Equipment.Slot slot)
          : base(name, description, weight, ItemType.Armor)
        {
            Defense = defense;
            Condition = condition;
            Material = material;
            Slot = slot;
        }
    }
}
