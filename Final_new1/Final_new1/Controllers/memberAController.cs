using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using PagedList;
using System.Web.Security;
using System.Net;
using System.Data.Entity;
using Final_new1.Models;

namespace Final_new1.Controllers
{
    public class memberAController : Controller
    {
        memberAEntities dbA = new memberAEntities();
        memberB2Entities dbB = new memberB2Entities();
        memberCEntities dbC = new memberCEntities();
        memberDEntities dbD = new memberDEntities();
        memberEEntities dbE = new memberEEntities();
        loginEntities dbL = new loginEntities();
        // GET: memberA

        int pageSize = 5;
        public ActionResult Index1(int page = 1)
        {
            //var memberA = dbA.TableMemberAs1101605;
            //return View(memberA);
            ViewBag.num1 = dbA.TableMemberAs1101605.Count();
            int currentPage = page < 1 ? 1 : page;
            var lists = dbA.TableMemberAs1101605.OrderBy(m => m.mId).ToList();
            var result = lists.ToPagedList(currentPage, pageSize);
            ViewBag.page1 = currentPage;
            ViewBag.c1 = result.Count();
            return View(result);
        }

        public ActionResult DetailsA(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TableMemberAs1101605 emp = dbA.TableMemberAs1101605.Find(Id);
            if (emp == null)
            {
                return HttpNotFound();
            }
            return View(emp);
        }
        public ActionResult CreateA()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateA([Bind(Include = "mId,mName,age,height,weight,email,ballage,tId")] TableMemberAs1101605 emp)
        {
            if (ModelState.IsValid)
            {
                dbA.TableMemberAs1101605.Add(emp);
                dbA.SaveChanges();
                return RedirectToAction("Index1");
            }
            return View(emp);
        }
        public ActionResult EditA(int? Id)
        {
            if (Id == null)
            {
                return Content("查無此資料，請提供員工編號!");
            }
            TableMemberAs1101605 emp = dbA.TableMemberAs1101605.Find(Id);
            if (emp == null)
            {
                return HttpNotFound();
            }
            return View(emp);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditA([Bind(Include = "mId,mName,age,height,weight,email,ballage,tId")] TableMemberAs1101605 emp)
        {
            if (ModelState.IsValid)
            {
                dbA.Entry(emp).State = EntityState.Modified;
                dbA.SaveChanges();
                return RedirectToAction("Index1");
            }
            return View(emp);
        }
        public ActionResult DeleteA(int? Id)
        {
            if (Id == null)
            {
                return Content("查無此資料，請提供員工編號!");
            }
            TableMemberAs1101605 emp = dbA.TableMemberAs1101605.Find(Id);
            if (emp == null)
            {
                return HttpNotFound();
            }
            return View(emp);
        }
        [HttpPost]
        public ActionResult DeleteA(int Id)
        {
            TableMemberAs1101605 emp = dbA.TableMemberAs1101605.Find(Id);
            dbA.TableMemberAs1101605.Remove(emp);
            dbA.SaveChanges();
            return RedirectToAction("Index1");
        }
        ////////////////////////////////////////////////////////////
        public ActionResult Index2(int page =1)
        {
            ViewBag.num2 = dbB.TableMemberBs1101605.Count();
            int currentPage = page < 1 ? 1 : page;
            var lists = dbB.TableMemberBs1101605.OrderBy(m => m.mId).ToList();
            var result = lists.ToPagedList(currentPage, pageSize);
            ViewBag.page2 = currentPage;
            ViewBag.c2 = result.Count();
            return View(result);
        }
        public ActionResult DetailsB(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TableMemberBs1101605 emp = dbB.TableMemberBs1101605.Find(Id);
            if (emp == null)
            {
                return HttpNotFound();
            }
            return View(emp);
        }
        public ActionResult CreateB()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateB([Bind(Include = "mId,mName,age,height,weight,email,ballage,tId")] TableMemberBs1101605 emp)
        {
            if (ModelState.IsValid)
            {
                dbB.TableMemberBs1101605.Add(emp);
                dbB.SaveChanges();
                return RedirectToAction("Index2");
            }
            return View(emp);
        }
        public ActionResult EditB(int? Id)
        {
            if (Id == null)
            {
                return Content("查無此資料，請提供員工編號!");
            }
            TableMemberBs1101605 emp = dbB.TableMemberBs1101605.Find(Id);
            if (emp == null)
            {
                return HttpNotFound();
            }
            return View(emp);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditB([Bind(Include = "mId,mName,age,height,weight,email,ballage,tId")] TableMemberBs1101605 emp)
        {
            if (ModelState.IsValid)
            {
                dbB.Entry(emp).State = EntityState.Modified;
                dbB.SaveChanges();
                return RedirectToAction("Index2");
            }
            return View(emp);
        }
        public ActionResult DeleteB(int? Id)
        {
            if (Id == null)
            {
                return Content("查無此資料，請提供員工編號!");
            }
            TableMemberBs1101605 emp = dbB.TableMemberBs1101605.Find(Id);
            if (emp == null)
            {
                return HttpNotFound();
            }
            return View(emp);
        }
        [HttpPost]
        public ActionResult DeleteB(int Id)
        {
            TableMemberBs1101605 emp = dbB.TableMemberBs1101605.Find(Id);
            dbB.TableMemberBs1101605.Remove(emp);
            dbB.SaveChanges();
            return RedirectToAction("Index1");
        }
        //////////////////////////
        public ActionResult Index3(int page=1)
        {
            ViewBag.num3 = dbC.TableMemberCs1101605.Count();
            int currentPage = page < 1 ? 1 : page;
            var lists = dbC.TableMemberCs1101605.OrderBy(m => m.mId).ToList();
            var result = lists.ToPagedList(currentPage, pageSize);
            ViewBag.page3 = currentPage;
            ViewBag.c3 = result.Count();
            return View(result);
        }
        public ActionResult DetailsC(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TableMemberCs1101605 emp = dbC.TableMemberCs1101605.Find(Id);
            if (emp == null)
            {
                return HttpNotFound();
            }
            return View(emp);
        }
        public ActionResult CreateC()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateC([Bind(Include = "mId,mName,age,height,weight,email,ballage,tId")] TableMemberCs1101605 emp)
        {
            if (ModelState.IsValid)
            {
                dbC.TableMemberCs1101605.Add(emp);
                dbC.SaveChanges();
                return RedirectToAction("Index3");
            }
            return View(emp);
        }
        public ActionResult EditC(int? Id)
        {
            if (Id == null)
            {
                return Content("查無此資料，請提供員工編號!");
            }
            TableMemberCs1101605 emp = dbC.TableMemberCs1101605.Find(Id);
            if (emp == null)
            {
                return HttpNotFound();
            }
            return View(emp);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditC([Bind(Include = "mId,mName,age,height,weight,email,ballage,tId")] TableMemberCs1101605 emp)
        {
            if (ModelState.IsValid)
            {
                dbC.Entry(emp).State = EntityState.Modified;
                dbC.SaveChanges();
                return RedirectToAction("Index3");
            }
            return View(emp);
        }
        public ActionResult DeleteC(int? Id)
        {
            if (Id == null)
            {
                return Content("查無此資料，請提供員工編號!");
            }
            TableMemberCs1101605 emp = dbC.TableMemberCs1101605.Find(Id);
            if (emp == null)
            {
                return HttpNotFound();
            }
            return View(emp);
        }
        [HttpPost]
        public ActionResult DeleteC(int Id)
        {
            TableMemberCs1101605 emp = dbC.TableMemberCs1101605.Find(Id);
            dbC.TableMemberCs1101605.Remove(emp);
            dbC.SaveChanges();
            return RedirectToAction("Index3");
        }

        ///////////////////////////////////
        public ActionResult Index4(int page = 1)
        {
            ViewBag.num4 = dbD.TablememberDs1101605.Count();
            int currentPage = page < 1 ? 1 : page;
            var lists = dbD.TablememberDs1101605.OrderBy(m => m.mId).ToList();
            var result = lists.ToPagedList(currentPage, pageSize);
            ViewBag.page4 = currentPage;
            ViewBag.c4 = result.Count();
            return View(result);
        }

        public ActionResult DetailsD(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TablememberDs1101605 emp = dbD.TablememberDs1101605.Find(Id);
            if (emp == null)
            {
                return HttpNotFound();
            }
            return View(emp);
        }
        public ActionResult CreateD()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateD([Bind(Include = "mId,mName,age,height,weight,email,ballage,tId")] TablememberDs1101605 emp)
        {
            if (ModelState.IsValid)
            {
                dbD.TablememberDs1101605.Add(emp);
                dbD.SaveChanges();
                return RedirectToAction("Index4");
            }
            return View(emp);
        }
        public ActionResult EditD(int? Id)
        {
            if (Id == null)
            {
                return Content("查無此資料，請提供員工編號!");
            }
            TablememberDs1101605 emp = dbD.TablememberDs1101605.Find(Id);
            if (emp == null)
            {
                return HttpNotFound();
            }
            return View(emp);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditD([Bind(Include = "mId,mName,age,height,weight,email,ballage,tId")] TablememberDs1101605 emp)
        {
            if (ModelState.IsValid)
            {
                dbD.Entry(emp).State = EntityState.Modified;
                dbD.SaveChanges();
                return RedirectToAction("Index4");
            }
            return View(emp);
        }
        public ActionResult DeleteD(int? Id)
        {
            if (Id == null)
            {
                return Content("查無此資料，請提供員工編號!");
            }
            TablememberDs1101605 emp = dbD.TablememberDs1101605.Find(Id);
            if (emp == null)
            {
                return HttpNotFound();
            }
            return View(emp);
        }
        [HttpPost]
        public ActionResult DeleteD(int Id)
        {
            TablememberDs1101605 emp = dbD.TablememberDs1101605.Find(Id);
            dbD.TablememberDs1101605.Remove(emp);
            dbD.SaveChanges();
            return RedirectToAction("Index4");
        }
        ////////////////////////
        public ActionResult Index5(int page = 1)
        {
            ViewBag.num5 = dbE.TablememberEs1101605.Count();
            int currentPage = page < 1 ? 1 : page;
            var lists = dbE.TablememberEs1101605.OrderBy(m => m.mId).ToList();
            var result = lists.ToPagedList(currentPage, pageSize);
            ViewBag.page5 = currentPage;
            ViewBag.c5 = result.Count();
            return View(result);
        }

        public ActionResult DetailsE(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TablememberEs1101605 emp = dbE.TablememberEs1101605.Find(Id);
            if (emp == null)
            {
                return HttpNotFound();
            }
            return View(emp);
        }
        public ActionResult CreateE()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateE([Bind(Include = "mId,mName,age,height,weight,email,ballage,tId")] TablememberEs1101605 emp)
        {
            if (ModelState.IsValid)
            {
                dbE.TablememberEs1101605.Add(emp);
                dbE.SaveChanges();
                return RedirectToAction("Index5");
            }
            return View(emp);
        }
        public ActionResult EditE(int? Id)
        {
            if (Id == null)
            {
                return Content("查無此資料，請提供員工編號!");
            }
            TablememberEs1101605 emp = dbE.TablememberEs1101605.Find(Id);
            if (emp == null)
            {
                return HttpNotFound();
            }
            return View(emp);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditE([Bind(Include = "mId,mName,age,height,weight,email,ballage,tId")] TablememberEs1101605 emp)
        {
            if (ModelState.IsValid)
            {
                dbE.Entry(emp).State = EntityState.Modified;
                dbE.SaveChanges();
                return RedirectToAction("Index5");
            }
            return View(emp);
        }
        public ActionResult DeleteE(int? Id)
        {
            if (Id == null)
            {
                return Content("查無此資料，請提供員工編號!");
            }
            TablememberEs1101605 emp = dbE.TablememberEs1101605.Find(Id);
            if (emp == null)
            {
                return HttpNotFound();
            }
            return View(emp);
        }
        [HttpPost]
        public ActionResult DeleteE(int Id)
        {
            TablememberEs1101605 emp = dbE.TablememberEs1101605.Find(Id);
            dbE.TablememberEs1101605.Remove(emp);
            dbE.SaveChanges();
            return RedirectToAction("Index5");
        }
        ////////////////////
        public ActionResult Querystart()
        {
            return View();
        }
        public ActionResult Query()
        {
            return View();
        }
        [HttpPost]
        public ActionResult MyQuery(int height,int ballage)
        {
            if (height == null && ballage == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var Qresult = dbA.TableMemberAs1101605.Where(m => m.height >= height||m.ballage>=ballage);
            ViewBag.sum1 = Qresult.Count();
            return View(Qresult.ToList());
        }
        public ActionResult QueryB()
        {
            return View();
        }
        [HttpPost]
        public ActionResult MyQueryB(int height, int ballage)
        {
            // var Qresult = from m in dbA.TableMemberAs1101605
            //              select m;
            if (height == null && ballage == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var Qresult = dbB.TableMemberBs1101605.Where(m => m.height >= height || m.ballage >= ballage);
            ViewBag.sum2 = Qresult.Count();
            return View(Qresult.ToList());
        }

        public ActionResult QueryC()
        {
            return View();
        }
        [HttpPost]
        public ActionResult MyQueryC(int height, int ballage)
        {
            // var Qresult = from m in dbA.TableMemberAs1101605
            //              select m;
            if (height == null && ballage == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var Qresult = dbC.TableMemberCs1101605.Where(m => m.height >= height || m.ballage >= ballage);
            ViewBag.sum3 = Qresult.Count();
            return View(Qresult.ToList());
        }

        public ActionResult QueryD()
        {
            return View();
        }
        [HttpPost]
        public ActionResult MyQueryD(int height, int ballage)
        {
            // var Qresult = from m in dbA.TableMemberAs1101605
            //              select m;
            if (height == null && ballage == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var Qresult = dbD.TablememberDs1101605.Where(m => m.height >= height || m.ballage >= ballage);
            return View(Qresult.ToList());
        }

        public ActionResult QueryE()
        {
            return View();
        }
        [HttpPost]
        public ActionResult MyQueryE(int height, int ballage)
        {
            // var Qresult = from m in dbA.TableMemberAs1101605
            //              select m;
            if (height == null && ballage == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var Qresult = dbE.TablememberEs1101605.Where(m => m.height >= height || m.ballage >= ballage);
            ViewBag.sum5 = Qresult.Count();
            return View(Qresult.ToList());
        }

        public ActionResult SelectQuerystart()
        {
            return View();
        }
        public ActionResult SelectQueryA()
        {
            var Qresult = dbA.TableMemberAs1101605.ToList();
            return View(Qresult);
        }
        [HttpPost]
        public ActionResult MySelQueryA(String Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var Qresult = dbA.TableMemberAs1101605.Where(m => m.mId.ToString() == Id);
            return View(Qresult.ToList());
        }
        public ActionResult SelectQueryB()
        {
            var Qresult = dbB.TableMemberBs1101605.ToList();
            return View(Qresult);
        }
        [HttpPost]
        public ActionResult MySelQueryB(String Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var Qresult = dbB.TableMemberBs1101605.Where(m => m.mId.ToString() == Id);
            return View(Qresult.ToList());
        }
        public ActionResult SelectQueryC()
        {
            var Qresult = dbC.TableMemberCs1101605.ToList();
            return View(Qresult);
        }
        [HttpPost]
        public ActionResult MySelQueryC(String Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var Qresult = dbC.TableMemberCs1101605.Where(m => m.mId.ToString() == Id);
            return View(Qresult.ToList());
        }
        public ActionResult SelectQueryD()
        {
            var Qresult = dbD.TablememberDs1101605.ToList();
            return View(Qresult);
        }
        [HttpPost]
        public ActionResult MySelQueryD(String Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var Qresult = dbD.TablememberDs1101605.Where(m => m.mId.ToString() == Id);
            return View(Qresult.ToList());
        }
        public ActionResult SelectQueryE()
        {
            var Qresult = dbE.TablememberEs1101605.ToList();
            return View(Qresult);
        }
        [HttpPost]
        public ActionResult MySelQueryE(String Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var Qresult = dbE.TablememberEs1101605.Where(m => m.mId.ToString() == Id);
            return View(Qresult.ToList());
        }
        //////////////



    }
}