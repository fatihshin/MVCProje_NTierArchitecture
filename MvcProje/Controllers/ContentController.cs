﻿using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjee.Controllers
{
    public class ContentController : Controller
    {
        // GET: Content
        ContentManager cm = new ContentManager(new EfContentDal());

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAllContent(string p="") 
        {
            var values= cm.GetList(p);
            return View(values);
        }

        public ActionResult ContentByHeading(int id)
        {
            var contentvalues=cm.GetListByHeadingId(id);
            return View(contentvalues);
        }
    }
}