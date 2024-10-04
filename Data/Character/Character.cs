using static Data.Character.Job;
using static Data.Character.Race;

namespace Data.Character
{
    public class Character
    {
        public string Name { get; set; }
        public Job Job { get; set; }
        public Race Race { get; set; }
        public Stats Stats { get; set; }
        public Inventory Inventory { get; set; }

        public Character(string name, Job job, Race race)
        {
            Name = name;
            Job = job;
            Race = race;
            Stats = new Stats();
            Inventory = new Inventory();
        }
    }


    public class Item
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Weight { get; set; }
    }
}