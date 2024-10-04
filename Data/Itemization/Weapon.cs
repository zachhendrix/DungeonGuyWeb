namespace Data.Itemization
{
    public class Weapon : ItemObject
    {
        public int Damage { get; }
        public float Condition { get; }
        public DamageTypeEnum DamageType { get; }
        public PhysicalDamageType? PhysicalType { get; }
        public MagicalDamageType? MagicalType { get; }

        public Weapon(string name, string description, float weight, int damage, float condition, DamageTypeEnum damageType, PhysicalDamageType? physicalType = null, MagicalDamageType? magicalType = null)
            : base(name, description, weight, ItemType.Weapon)
        {
            Damage = damage;
            Condition = condition;
            DamageType = damageType;

            PhysicalType = damageType == DamageTypeEnum.Physical ? physicalType : null;
            MagicalType = damageType == DamageTypeEnum.Magical ? magicalType : null;
        }

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
