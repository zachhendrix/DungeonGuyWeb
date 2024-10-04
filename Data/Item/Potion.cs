namespace Data.Item
{
    public class Potion : Item
    {
        public string Effect { get; set; } // e.g., "Healing", "Mana Restoration", etc.
        public int Duration { get; set; } // Duration in seconds

        public Potion()
        {
            Type = "Potion"; // Set the Type property to "Potion"
        }
    }
}
