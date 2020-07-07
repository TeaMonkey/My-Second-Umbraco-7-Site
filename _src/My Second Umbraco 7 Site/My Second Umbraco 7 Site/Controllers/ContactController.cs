using My_Second_Umbraco_7_Site.Models;
using System;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace My_Second_Umbraco_7_Site.Controllers
{
    public class ContactController : SurfaceController
    {
        private string PartialViewPath(string partialViewName)
        {
            return $"~/Views/Partials/Contact/{partialViewName}.cshtml";
        }

        public ActionResult RenderContactForm()
        {
            return PartialView(PartialViewPath("_ContactForm"), new ContactForm());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitMessage(ContactForm form)
        {
            if (!ModelState.IsValid)
                return CurrentUmbracoPage();

            //Just an example, grab the firstname and return a thank you message
            TempData.Add("Success", $"{form.FirstName}, your form was successfully submitted at {DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss")}");

            return RedirectToCurrentUmbracoPage();
        }
    }
}