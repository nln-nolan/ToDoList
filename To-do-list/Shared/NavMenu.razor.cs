using ToDoList.Models;

namespace ToDoList.Shared
{
    public partial class NavMenu
    {
        private bool collapseNavMenu = true;

        private string? NavMenuCssClass => collapseNavMenu ? "collapse" : null;

        private void ToggleNavMenu()
        {
            collapseNavMenu = !collapseNavMenu;
        }

        public void ToggleDarkTheme()
        {
            ToDoOptions.IsDarkTheme = !ToDoOptions.IsDarkTheme;
        }
    }
}
