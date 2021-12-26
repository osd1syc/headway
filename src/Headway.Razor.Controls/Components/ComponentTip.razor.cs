﻿using Microsoft.AspNetCore.Components;

namespace Headway.Razor.Controls.Components
{
    public abstract class ComponentTipBase : ComponentBase
    {
        [Parameter] 
        public string Text { get; set; }

        [Parameter]
        public string Class { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }
    }
}
