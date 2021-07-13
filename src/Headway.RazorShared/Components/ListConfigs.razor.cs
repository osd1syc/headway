﻿using Headway.Core.Attributes;
using Headway.Core.Interface;
using Headway.Core.Model;
using Headway.RazorShared.Base;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Headway.RazorShared.Components
{
    [DynamicConfiguration]
    public partial class ListConfigsBase : HeadwayComponentBase
    {
        [Inject]
        public IConfigurationService ConfigurationService { get; set; }

        protected IEnumerable<ListConfig> listConfigs;

        protected override async Task OnInitializedAsync()
        {
            var result = await ConfigurationService.GetListConfigsAsync().ConfigureAwait(false);

            listConfigs = GetResponse(result);

            await base.OnInitializedAsync().ConfigureAwait(false);
        }

        protected void Add()
        {
            //NavigationManager.NavigateTo($"{dynamicList.ListConfig.NavigateTo}/{TypeName}");
        }

        protected void Update(object id)
        {
            //NavigationManager.NavigateTo($"{dynamicList.ListConfig.NavigateTo}/{TypeName}/{id}");
        }
    }
}
