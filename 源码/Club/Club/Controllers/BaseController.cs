﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Club.Controllers
{
    public class BaseController : Controller
    {
        /// <summary>
        /// 消息提示
        /// </summary>
        /// <param name="message"></param>
        public void ShowMassage(string message)
        {
            TempData["Msg"] = message;
        }
    }
}