﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Diagnostics;

namespace EComm.Web.Controllers
{
    public class ErrorController : Controller
    {
        [Route("clienterror")]
        public IActionResult ClientError(int statusCode)
        {
            ViewBag.Message = statusCode switch {
                400 => "Bad Request (400)",
                404 => "Not Found (404)",
                418 => "I'm a teapot (418)",
                _ => $"Other ({statusCode})"
            };
            return View("Index");
        }

        [Route("servererror")]
        public IActionResult ServerError()
        {
            var exceptionFeature =
              HttpContext.Features.Get<IExceptionHandlerPathFeature>();

            var route = exceptionFeature?.Path;
            var ex = exceptionFeature?.Error;

            // TODO: write the error to a log
            ViewBag.Message = "An unexpected error has occured";

            return View("Index");
        }
    }
}
