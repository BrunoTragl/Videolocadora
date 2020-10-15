using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrunoTragl.Inovation.Videolocadora.Services.WebApi.Filters
{
    public class InternalServerError : IActionResult
    {
        public Task ExecuteResultAsync(ActionContext context)
        {
            context.HttpContext.Response.StatusCode = 500;
            context.HttpContext.Response.StatusCode = 500;
            throw new NotImplementedException();
        }
    }
}
