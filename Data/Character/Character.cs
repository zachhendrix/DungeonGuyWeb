using static Data.Character.CharacterClass;
using static Data.Character.CharacterRace;

namespace Data.Character
{
    public class Character
    {
        public string name { get; set; }
        public Job job { get; set; }
        public Race race { get; set; }
        public Stats stats { get; set; }
        public List<Item> inventory { get; set; }

        public Character()
        {
            name = name;
            job = new Job();
            race = new Race();
            stats = new Stats();
            inventory = new List<Item>();
        }
    }

    public class Stats
    {
        public int health { get; set; }
        public int mana { get; set; }
        public int stamina { get; set; }
        public int strength { get; set; }
        public int dexterity { get; set; }
        public int constitution { get; set; }
        public int intelligence { get; set; }
        public int wisdom { get; set; }
        public int charisma { get; set; }
    }

    public class Item
    {
        public string? name { get; set; }
        public string? description { get; set; }
        public decimal weight { get; set; }
    }
}