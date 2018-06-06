using MVCEncryptDecrypt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEncryptDecrypt.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Encrypt(string stringtoEncrypt, string Password)
        {
            string EncryptResult = Security.EncryptText(stringtoEncrypt, Password);

            return Json(new { Data = EncryptResult }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Decrypt(string encryptedText, string encryptPassword)
        {
            string Decryptresult = Security.DecryptText(encryptedText, encryptPassword);
            return Json(new { Data = Decryptresult }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Farzad(Fred) Seifi";

            return View();
        }
    }
}