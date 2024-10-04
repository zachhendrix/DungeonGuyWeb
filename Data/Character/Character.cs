using static Data.Character.CharacterJob;
using static Data.Character.CharacterRace;

namespace Data.Character
{
    public class Character
    {
        public string Name { get; set; }
        public Job Job { get; set; }
        public Race Race { get; set; }
        public Stats Stats { get; set; }
        public List<Item> Inventory { get; set; }

        public Character(string name, Job job, Race race)
        {
            Name = name;
            Job = job;
            Race = race;
            Stats = new Stats();
            Inventory = new List<Item>();
        }
    }

    public class Stats
    {
        private int health { get; set; }
        private int mana { get; set; }
        private int stamina { get; set; }
        private int strength { get; set; }
        private int dexterity { get; set; }
        private int constitution { get; set; }
        private int intelligence { get; set; }
        private int wisdom { get; set; }
        private int charisma { get; set; }
    }

    public class Item
    {
        public string? name { get; set; }
        public string? description { get; set; }
        public decimal weight { get; set; }
    }
}