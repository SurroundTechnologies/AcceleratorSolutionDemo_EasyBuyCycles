//===============================================================================================
// <A4DN_GeneratedInformation>
// This code was generated using the Accelerator for .Net Code Generator.
// <A4DN_Template Name="MVC.System.Global.asax.t4" Version="8.0.0.75" GeneratedDate="7/21/2023" />
// </A4DN_GeneratedInformation>
//===============================================================================================

using System;
using System.Collections.Generic;
using System.Web.Mvc;
using A4DN.Core.MVC.Shared.Controllers;

namespace MVC.EasyBuyCycles.Controllers
{
    [Authorize]
    public class HomeController : AB_BaseController
    {
        // GET: home/index
        public ActionResult Index()
        {

            return View();
        }

       
    }
}