using Microsoft.AspNetCore.Components.Web;
using Models;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public static class ToDoOptions
    {
        private static bool _isDarkTheme = true;

        private static bool _isDevModeActive = false;
        public static bool IsDarkTheme
        {
            get => _isDarkTheme;
            set
            {
                if (_isDarkTheme != value)
                {
                    _isDarkTheme = value;
                    OnThemeChanged?.Invoke();
                }
            }
        }

        public static bool IsDevModeActive
        {
            get => _isDevModeActive;
            set
            {
                if (_isDevModeActive != value)
                {
                    _isDevModeActive = value;
                    OnDevModeChanged?.Invoke();
                }
            }
        }

        public static Action? OnThemeChanged { get; set; }

        public static Action? OnDevModeChanged { get; set; }
    }
}