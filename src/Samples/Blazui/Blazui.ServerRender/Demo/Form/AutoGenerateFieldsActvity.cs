﻿


using Blazui.Component;
using Blazui.Component.ControlConfigs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blazui.ServerRender.Demo.Form
{
    public class AutoGenerateFieldsActvity
    {
        [EditorGenerator(Label = "名称")]
        public string Name { get; set; }
        [EditorGenerator(Label = "区域")]
        public Area Area { get; set; }
        [EditorGenerator(Label = "日期")]
        public DateTime? Time { get; set; }
        [EditorGenerator(Label = "即时配送")]
        public bool Delivery { get; set; }
        [EditorGenerator(Label = "特殊资源")]
        public string Resource { get; set; }
        [EditorGenerator(Label = "活动形式")]
        public string Description { get; set; }

        [EditorGenerator(Label = "附件")]
        [Upload(Url = "/api/test/upload", Tip = "请传附件")]
        public IFileModel[] Files { get; set; }

        [EditorGenerator(Label = "密码")]
        [Input(Type = InputType.Password)]
        public string Password { get; set; } = "123456";
        public override string ToString()
        {
            return $"名称：{Name},区域：{Area},日期：{Time?.ToString()}，即时配送：{Delivery}，特殊资源：{Resource}，活动形式：{Description}，附件：{string.Join("-", Files.Select(x => x.FileName))},密码：{Password})";
        }
    }
}
