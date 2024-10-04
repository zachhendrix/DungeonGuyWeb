namespace Data.Item
{
    public class Armor : Item
    {
        public int Defense { get; set; }
        public string Material { get; set; } // e.g., "Leather", "Steel", etc.

        public Armor()
        {
            Type = "Armor"; // Set the Type property to "Armor"
        }
    }
}
