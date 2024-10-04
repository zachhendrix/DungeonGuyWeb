namespace Data.Item
{
    public class Potion : Item
    {
        public string effect { get; set; } // e.g., "Healing", "Mana Restoration", etc.
        public int duration { get; set; } // Duration in seconds

        public Potion()
        {
            type = "Potion"; // Set the Type property to "Potion"
        }
    }
}
