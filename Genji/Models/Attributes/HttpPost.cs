﻿using Genji.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Genji.Models.Attributes
{
    public class HttpPost : Attribute, IFilter
    {
        public bool ShouldContinue(HttpContext context)
        {
            return context.Request.Method == "POST";
        }
    }
}
