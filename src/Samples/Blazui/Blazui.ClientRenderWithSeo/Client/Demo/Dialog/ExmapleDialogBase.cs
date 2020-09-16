﻿
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazui.Component;

namespace Blazui.ClientRenderWithSeo.Client.Demo.Dialog
{
    public class ExmapleDialogBase : BDialogBase
    {
        [Inject]
        Component.MessageBox MessageService { get; set; }
        public async Task ShowDialog(MouseEventArgs eventArgs)
        {
            var result = await DialogService.ShowDialogAsync<ExampleDialog>("测试窗口");
        }

        public async Task ShowMessage(MouseEventArgs eventArgs)
        {
            await MessageService.AlertAsync("消息");
        }
    }
}
