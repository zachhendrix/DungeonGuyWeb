using static Data.Character.Character;
using static Data.Character.Stats;

namespace Data.Character.Utility
{
    public static class StatUtility
    {
        public static void InitializeStats()
        {
            var race = RaceDatabase.Get(Instance.Race).Stats;
            var job = JobDatabase.Get(Instance.Job).Stats;

            // Build a new combined stats object and assign it ONCE
            Instance.Stats = new Stats(
                race.Health + job.Health,
                race.Mana + job.Mana,
                race.Stamina + job.Stamina,
                race.Strength + job.Strength,
                race.Dexterity + job.Dexterity,
                race.Constitution + job.Constitution,
                race.Intelligence + job.Intelligence,
                race.Wisdom + job.Wisdom,
                race.Charisma + job.Charisma
            );
        }

        public static void ClearStats()
        {
            Instance.Stats = new Stats(0,0,0,0,0,0,0,0,0);
        }

        public static void SetStats(Stats baseStats, Stats modStats)
        {
            baseStats = modStats;
        }

        public static void ModStats(Stats baseStats, Stats modStats)
        {
            baseStats.Health += modStats.Health;
            baseStats.Mana += modStats.Mana;
            baseStats.Stamina += modStats.Stamina;
            baseStats.Strength += modStats.Strength;
            baseStats.Dexterity += modStats.Dexterity;
            baseStats.Constitution += modStats.Constitution;
            baseStats.Intelligence += modStats.Intelligence;
            baseStats.Wisdom += modStats.Wisdom;
            baseStats.Charisma += modStats.Charisma;
        }

        public static StatsView GetStatsView()
        {
            var s = Instance.Stats;
            return new StatsView(
                s.Health,
                s.Mana,
                s.Stamina,
                s.Strength,
                s.Dexterity,
                s.Constitution,
                s.Intelligence,
                s.Wisdom,
                s.Charisma
            );
        }
    }
}
