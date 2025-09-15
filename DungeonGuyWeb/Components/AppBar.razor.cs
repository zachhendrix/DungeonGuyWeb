using Microsoft.AspNetCore.Components;

namespace DungeonGuyWeb.Components
{
    public partial class AppBar : ComponentBase
    {
        public bool Open = false;

        public void ToggleDrawer()
        {
            Open = !Open;
        }
    }
}
