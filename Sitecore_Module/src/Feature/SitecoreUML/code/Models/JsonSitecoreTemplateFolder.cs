﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZacharyKniebel.Feature.SitecoreUML.Models
{
    [Serializable]
    public class JsonSitecoreTemplateFolder : IJsonSitecoreItem
    {
        public string ReferenceID { get; set; }

        public string Name { get; set; }

        public string Path { get; set; }

        public bool IsTemplate { get; } = false;

        public IJsonSitecoreItem[] Children { get; set; }
    }
}