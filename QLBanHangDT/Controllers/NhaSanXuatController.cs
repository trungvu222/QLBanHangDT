using PagedList;
using QLBanHangDT.Models.BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLBanHangDT.Controllers
{
    public class NhaSanXuatController : Controller
    {
        // GET: NhaSanXuat
        public ActionResult Index(String id, int page = 1, int pagesize = 3)
        {
            var ds = NhaSanXuatBUS.ChiTiet(id).ToPagedList(page, pagesize);
            return View(ds);
        }
    }
}