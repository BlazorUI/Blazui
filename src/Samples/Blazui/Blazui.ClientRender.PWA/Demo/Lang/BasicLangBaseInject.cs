﻿using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System.Threading.Tasks;

namespace Element.ClientRender.PWA.Demo.Lang
{
    public class BasicLangBaseInject : ComponentBase
    {
        [Inject]
        public Element.Lang.BLang Lang { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await Lang.SetLangAsync("en-US");
        }

        public async Task SetEnLang(MouseEventArgs eventArgs)
        {
            await Lang.SetLangAsync("en-US");
        }

        public async Task SetCnLang(MouseEventArgs eventArgs)
        {
            await Lang.SetLangAsync("zh-CN");
        }
    }
}
