using My_Second_Umbraco_7_Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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

        public ActionResult SubmitMessage(ContactForm form)
        {
            if (!ModelState.IsValid)
                return CurrentUmbracoPage();

            //Just an example, grab the firstname and redirect to a thank you page that makes use of it
            //Add the thank you page to umbraco as a config that can be controlled in the back office

            //Todo: Fix validaiton
            //Add antiforgerytoken
            //https://our.umbraco.com/documentation/Reference/Templating/Mvc/forms/

            return RedirectToCurrentUmbracoPage();
        }
    }
}