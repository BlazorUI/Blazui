﻿
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Element;

namespace Element.Demo.Form
{
    public partial class BasicFormBase : BComponentBase
    {
        internal LabelAlign formAlign;
        [Inject]
        Element.MessageBox MessageBox { get; set; }

        protected BForm demoForm;
        protected void Submit()
        {
            if (!demoForm.IsValid())
            {
                return;
            }

            var activity = demoForm.GetValue<Activity>();
            _ = MessageBox.AlertAsync(activity.ToString());
        }

        

        protected void Reset()
        {
            demoForm.Reset();
        }
    }
}
