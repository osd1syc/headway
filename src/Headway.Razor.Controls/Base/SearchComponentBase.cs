﻿using Headway.Core.Notifications;
using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

namespace Headway.Razor.Controls.Base
{
    public class SearchComponentBase : ComponentBase, IDisposable
    {
        [Inject]
        public IStateNotification StateNotification { get; set; }

        [Parameter]
        public string SearchComonentUniqueId { get; set; }

        public void Dispose()
        {
            StateNotification.Deregister(SearchComonentUniqueId);

            GC.SuppressFinalize(this);
        }

        protected async override Task OnInitializedAsync()
        {
            StateNotification.Register(SearchComonentUniqueId, StateHasChanged);

            await base.OnInitializedAsync().ConfigureAwait(false);
        }
    }
}
