﻿
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Element;

namespace Element.Demo.MessageBox
{
    public partial class ConfirmMessageBox : ComponentBase
    {
        [Inject]
        MessageService MessageService { get; set; }
        [Inject]
        Element.MessageBox MessageBox { get; set; }
        public async Task ShowMessageAsync()
        {
            var result = await MessageBox.ConfirmAsync("测试消息");
            MessageService.Show(result.ToString());
        }
    }
}
