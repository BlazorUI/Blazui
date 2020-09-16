﻿
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using Blazui.Component;
using System.Threading.Tasks;

namespace Blazui.ClientRenderWithSeo.Client.Demo.MessageBox
{
    public class BasicMessageBoxBase : ComponentBase
    {
        [Inject]
        MessageService MessageService { get; set; }
        [Inject]
        Component.MessageBox MessageBox { get; set; }
        public async Task ShowMessageAsync()
        {
            var result = await MessageBox.AlertAsync("测试消息");
            MessageService.Show(result.ToString());
        }
    }
}
