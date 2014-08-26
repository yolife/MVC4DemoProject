using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc4Demo.Models;

namespace Mvc4Demo.Controllers
{
    public class TreeController : Controller
    {
        public ActionResult tree(string id)
        {
            ViewBag.TreeData = TreeModel.GetHardCodedData(); 
            ViewBag.TreeDepth = Convert.ToInt32(id);
            return View("TreeView");
        }
    }
}
