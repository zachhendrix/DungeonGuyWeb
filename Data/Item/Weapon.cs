using static Data.Item.Weapon;

namespace Data.Item
{
    public class Weapon(string name, string description, float weight, int damage, float condition, DamageTypeEnum damageType, PhysicalDamageType? physicalType = null, MagicalDamageType? magicalType = null)
               : Item(name, description, weight, ItemType.Weapon)  // Call the base class constructor
    {
        public int Damage { get; } = damage;  // Read-only property initialized in primary constructor
        public float Condition { get; } = condition;
        public DamageTypeEnum DamageType { get; } = damageType;
        public PhysicalDamageType? PhysicalType { get; } = damageType == DamageTypeEnum.Physical ? physicalType : null;
        public MagicalDamageType? MagicalType { get; } = damageType == DamageTypeEnum.Magical ? magicalType : null;

        // Enums defined as before
        public enum DamageTypeEnum
        {
            Physical,
            Magical
        }

        public enum PhysicalDamageType
        {
            Bludgeoning,
            Slashing,
            Piercing
        }

        public enum MagicalDamageType
        {
            Fire,
            Ice,
            Lightning
        }
    }
}
