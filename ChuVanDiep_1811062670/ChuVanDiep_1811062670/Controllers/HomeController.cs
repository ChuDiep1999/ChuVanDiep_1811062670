using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ChuVanDiep_1811062670.Models;
using PagedList;

namespace ChuVanDiep_1811062670.Controllers
{
    public class HomeController : Controller
    {
        ExamsEntities db = new ExamsEntities();
        public ActionResult Index(int? page)
        {
            if (page == null) page = 1;


            var listbaihat = (from l in db.baihats
                         select l).OrderBy(x => x.mabaihat);


            int pageSize = 5;


            int pageNumber = (page ?? 1);


            return View(listbaihat.ToPagedList(pageNumber, pageSize));
        }

        public ActionResult Index2( int? page)
        {

            

        
            if (page == null) page = 1;


            var links = (from l in db.baihats
                         select l).OrderBy(x => x.mabaihat);

           
            int pageSize = 3;

          
            int pageNumber = (page ?? 1);


            return View(links.ToPagedList(pageNumber, pageSize));
        }

       public ActionResult HienThiTheoTheLoai()
        {
            var list = db.baihats;
            return View(list);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}