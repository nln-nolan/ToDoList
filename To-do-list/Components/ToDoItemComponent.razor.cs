#nullable enable
using Microsoft.AspNetCore.Components;
using Models;
using ToDoList.Pages;

namespace ToDoList.Components
{
    public partial class ToDoItemComponent
    {
        [CascadingParameter]
        public ToDoPage ToDoPage { get; set; } = default!;

        [Parameter, EditorRequired]
        public ToDoItem Item { get; set; } = default!;

        [Parameter]
        public bool IsDarkTheme { get; set; }

        public void ToggleIsDone ()
        {
            Item.IsDone = !Item.IsDone;
            ToDoPage.Update();
        }
    }

}
