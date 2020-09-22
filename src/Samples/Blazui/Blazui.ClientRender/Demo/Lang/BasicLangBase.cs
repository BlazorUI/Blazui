﻿using Element.ClientRender.Pages;
using Element;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Element.ClientRender.Demo.Lang
{
    public class BasicLangBase : ElementComponentBase
    {
        [Inject]
        public Element.Lang.BLang Lang { get; set; }
        public async Task SetEnLang(MouseEventArgs eventArgs)
        {
            await Lang.SetLangAsync("en-US");
            MarkAsRequireRender();
        }

        public async Task SetCnLang(MouseEventArgs eventArgs)
        {
          
            await Lang.SetLangAsync("zh-CN");
            MarkAsRequireRender();
        }
    }
}
