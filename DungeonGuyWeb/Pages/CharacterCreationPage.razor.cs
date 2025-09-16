using Data.Character;
using Data.Character.Utility;
using Microsoft.AspNetCore.Components;
using static Data.Character.Stats;
namespace DungeonGuyWeb.Pages
{
    public partial class CharacterCreationPage : ComponentBase
    {
        public Race SelectedRace { get; set; }
        public Job SelectedJob { get; set; }

        protected int NameLength => Character.Instance.Name?.Length ?? 0;
        protected bool IsCreateDisabled => 
            string.IsNullOrWhiteSpace(Character.Instance.Name) ||
            SelectedRace == Race.None ||
            SelectedJob == Job.None;
        protected StatsView PreviewStats { get; set; } = new StatsView(0, 0, 0, 0, 0, 0, 0, 0, 0);
        protected string PreviewSummary => $"{Character.Instance.Name} — {SelectedRace} — {SelectedJob}";

        protected override void OnInitialized()
        {
        }
        protected void OnRaceChanged(Race race)
        {
            SelectedRace = race;
            Character.Instance.Race = race;
            UpdateStatsPreview();
        }

        protected void OnJobChanged(Job job)
        {
            SelectedJob = job;
            Character.Instance.Job = job;
            UpdateStatsPreview();
        }

        protected void UpdateStatsPreview()
        {
            StatUtility.InitializeStats();
            PreviewStats = StatUtility.GetStatsView();
        }

        protected void CreateCharacter()
        {
        }
    }
}
