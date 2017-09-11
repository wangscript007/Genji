﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mercy.Models.Abstract
{
    public interface IActionResult
    {
        short StatusCode { get; }
        string Messsage { get; }
        string ContentType { get; }
        Task<byte[]> Render();
    }
}
