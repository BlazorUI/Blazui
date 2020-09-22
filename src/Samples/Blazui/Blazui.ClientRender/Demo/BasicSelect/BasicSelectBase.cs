﻿using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Element.ClientRender.Demo.BasicSelect
{
    public class BasicSelectBase : ComponentBase
    {
        protected int Value;

        protected Option Option;
        protected Option? NullableOption;
    }
}
