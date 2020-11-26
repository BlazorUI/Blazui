﻿
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Element;

namespace Element.Demo.Message
{
    public partial class MultiMessage : ComponentBase
    {
        [Inject]
        public MessageService Message { get; set; }
        
        public void ShowMessage()
        {
            Message.Show("消息1");
            Message.Show("消息2");
            Message.Show("消息3");
            Message.Show("消息4");
        }

    }
}
