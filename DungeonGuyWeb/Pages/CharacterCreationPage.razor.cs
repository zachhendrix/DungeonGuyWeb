using Data.Character;
using Data.Character.Utility;
using Microsoft.AspNetCore.Components;
namespace DungeonGuyWeb.Pages
{
    public partial class CharacterCreationPage : ComponentBase
    {
        public Race SelectedRace { get; set; }
        public Job SelectedJob { get; set; }

        protected int NameLength => Character.Instance.Name?.Length ?? 0;
        protected bool IsCreateDisabled => string.IsNullOrWhiteSpace(Character.Instance.Name);

        protected bool PreviewEnabled { get; set; }
        protected string PreviewSummary => $"{Character.Instance.Name} — {SelectedRace} — {SelectedJob}";

        protected override void OnInitialized()
        {
        }
        protected void OnRaceChanged(Race race)
        {
            SelectedRace = race;
            Character.Instance.Race = race;
            StatPreview();
        }

        protected void OnJobChanged(Job job)
        {
            SelectedJob = job;
            Character.Instance.Job = job;
            StatPreview();
        }

        protected void StatPreview()
        {
            StatUtility.InitializeStats();
        }

        protected void CreateCharacter()
        {
        }
    }
}
