using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using WebApplicationExercises.Models;

namespace WebApplicationExercises.Controllers
{
    public class MemoController : Controller
    {
        private static List<Memo> memos = new List<Memo>();
        // GET: Memo
        public ActionResult Index()
        {
            Memo tempMemo = new Memo { Title = "titleee", Contant = "<h1>Memo Test</h1>", Id = 1 };
            memos.Add(tempMemo);
            return View();
        }

        public ActionResult Create()
        {
            Memo tempMemo = new Memo { Title = "titleee", Contant = "<h1>Memo Test</h1>", Id = 1 };
            memos.Add(tempMemo);
            return View();
        }

        [HttpPost]
        public ActionResult Create(Memo memo)
        {
            memos.Add(memo);
            return RedirectToAction("Index");
        }
    }
}