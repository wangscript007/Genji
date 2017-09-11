﻿using Mercy.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mercy.Models.Attributes
{
    public class HttpGet : Attribute, IAuthorizeFilter
    {
        public bool ShouldContinue(HttpContext context)
        {
            return context.Request.Method == "GET";
        }
    }
}