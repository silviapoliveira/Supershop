﻿using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Supershop.Helpers
{
    public class NotFoundViewResult : ViewResult
    {
        public NotFoundViewResult(string viewName)
        {
            ViewName = viewName;
            StatusCode = (int)HttpStatusCode.NotFound;
        }
    }
}
