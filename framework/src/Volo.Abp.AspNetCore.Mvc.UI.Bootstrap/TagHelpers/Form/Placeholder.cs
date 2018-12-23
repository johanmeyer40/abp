﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form
{
    [AttributeUsage(AttributeTargets.Property)]
    public class Placeholder : Attribute
    {
        public string Value { get; set; }

        public Placeholder(string value)
        {
            Value = value;
        }
    }
}
