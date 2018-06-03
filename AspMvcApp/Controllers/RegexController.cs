using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspMvcApp.Models;

namespace AspMvcApp.Controllers
{

    public class RegexController : Controller
    {
        public ActionResult CreateRegex()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateRegex(RegexModel model)
        {
            if (ModelState.IsValid)
            {
                if (ValidateRule(model.Name))
                {
                    string createdRegex = RegexModel.CreateRegexString(model.MinLength, model.ChMinLength, model.MaxLength, model.ChMaxLength, model.MinUpperCase, model.ChUpperCase, model.MinLowerCase, model.ChLowerCase, model.MinSpecialSigns, model.ChSpecialSigns, model.MinDigits, model.ChDigits);

                    AspDatabase db = new AspDatabase();

                    int insertResult = db.InsertRegexIntoDatabase(model, createdRegex);

                    if (insertResult==1)
                        return RedirectToAction("CollectRule", "Regex", new { regex = model.Name + ": " + createdRegex });
                    else if(insertResult==0)
                    {
                        ModelState.AddModelError("", "The rule name provided is already used.");
                    }
                    else if (insertResult == -1)
                    {
                        ModelState.AddModelError("", "The rule with given parameters already exsists.");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Something went wrong with database connection.");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "The rule name provided is incorrect.");
                }
            }
            return View(model);
        }

        public ActionResult CollectRule(string regex)
        {
            ViewData["Message"] = "Created regular expression = " + regex;
            return View();
        }

        private bool ValidateRule(string name)
        {
            if (String.IsNullOrEmpty(name)) throw new ArgumentException("Value cannot be null or empty.", "name");
            
            return true;
        }
    }
}
