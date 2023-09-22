using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Web.Security;
using Final_new1.Models;
using System.Net;
using System.Data.Entity;

namespace Final_new1.Controllers
{
    [Authorize]
    public class team2Controller : Controller
    {
        team2Entities db = new team2Entities();
        memberAEntities dbA = new memberAEntities();
        memberB2Entities dbB = new memberB2Entities();
        memberCEntities dbC = new memberCEntities();
        memberDEntities dbD = new memberDEntities();
        memberEEntities dbE = new memberEEntities();
        loginEntities dbL = new loginEntities();
        // GET: team
        public ActionResult IndexTEAM()
        {
            var teams = db.TableTEAM2s1101605.ToList();
            ViewBag.num1 = dbA.TableMemberAs1101605.Count();
            ViewBag.num2 = dbB.TableMemberBs1101605.Count();
            ViewBag.num3 = dbC.TableMemberCs1101605.Count();
            ViewBag.num4 = dbD.TablememberDs1101605.Count();
            ViewBag.num5 = dbE.TablememberEs1101605.Count();
            return View(teams);
        }

        
        public ActionResult Edit(int? Id)
        {
            if (Id == null)
            {
                return Content("查無此資料，請提供員工編號!");
            }
            TableTEAM2s1101605 emp = db.TableTEAM2s1101605.Find(Id);
            if (emp == null)
            {
                return HttpNotFound();
            }
            return View(emp);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "tId,tName,eDate,coach,rate")] TableTEAM2s1101605 emp)
        {
            if (ModelState.IsValid)
            {
                db.Entry(emp).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("IndexTEAM");
            }
            return View(emp);
        }

        [AllowAnonymous]
        public ActionResult index()
        {
            FormsAuthentication.SignOut();
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public ActionResult index(string account, string password)
        {
            FormsAuthentication.SignOut();
            //檢查是否有員工Id的判斷，因為資料表沒有帳號跟密碼所以用Id跟Name取代，之後自己改
            if (account == null && password == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var Qresult = dbL.TableLogins1101605.Where(m => m.account == account && m.password == password);
            if (Qresult.Count() == 0)
            {
                ViewBag.Err = "帳密錯誤!";
            }
            else
            {
                FormsAuthentication.RedirectFromLoginPage(password, true);
                return RedirectToAction("IndexTEAM");
            }
            return View();
        }

       
    }
}