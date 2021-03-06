﻿using Genji.Models.Abstract;
using Genji.Models.Middlewares;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Genji.Models
{
    public class App : Middleware, IMiddleware
    {
        protected override void Mix(HttpContext context) { }
        protected async override Task<bool> Excutable(HttpContext context)
        {
            await Task.Delay(0);
            return false;
        }

        protected async override Task Excute(HttpContext context)
        {
            await Task.Delay(0);
            throw new NotImplementedException();
        }
    }
}
