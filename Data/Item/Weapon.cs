namespace Data.Item
{
    public class Weapon : Item
    {
        public int damage { get; set; }
        public string damageType { get; set; } // e.g., "Slashing", "Piercing", etc.

        public Weapon()
        {
            type = "Weapon"; // Set the Type property to "Weapon"
        }

        private enum DamageType
        {
            Slashing,
            Piercing,
            Blunt
        }
    }
}
