﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Html.Model
{
    public class button
    {
        public string name { get; set; }
        public string key { get; set; }
        public string url { get; set; }
        public buttonType type { get; set; }
        public List<subButton> subButtons { get; set; }
    }
}