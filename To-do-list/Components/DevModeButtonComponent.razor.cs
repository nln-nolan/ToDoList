using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ToDoList.Components
{
    public partial class DevModeButtonComponent
    {
        [Parameter, EditorRequired]
        public string Title { get; set; }

        [Parameter, EditorRequired]
        public Action ClickAction { get; set; }
    }
}
