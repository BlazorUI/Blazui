﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Blazui.Component.Test
{
    public class TestNameAttribute : Attribute
    {
        public string MenuName { get; }
        public string Name { get; }
        public TestNameAttribute(string menuName, string name)
        {
            MenuName = menuName;
            Name = name;
        }
    }
}
