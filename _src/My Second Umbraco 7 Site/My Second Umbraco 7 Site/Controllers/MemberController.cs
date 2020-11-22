using System.Web.Mvc;
using System.Web.Security;
using Umbraco.Web.Mvc;
using My_Second_Umbraco_7_Site.Models;

namespace My_Second_Umbraco_7_Site.Controllers
{
    public class MemberController : SurfaceController
    {
        private string PartialViewPath(string name)
        {
            return $"~/Views/Partials/Member/{name}.cshtml";
        }

        public ActionResult RenderLogin()
        {
            return PartialView(PartialViewPath("_Login"), new LoginModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitLogin(LoginModel model, string returnUrl)
        {
            //TODO: Add MFA support here
            //1. Keep track of login step
            //2. display the correct step and validate
            //3. Overrise ValidateUser from MembersMembershipProvider


            if (ModelState.IsValid)
            {
                if (Membership.ValidateUser(model.Username, model.Password))
                {
                    FormsAuthentication.SetAuthCookie(model.Username, false);
                    UrlHelper myHelper = new UrlHelper(HttpContext.Request.RequestContext);

                    if (myHelper.IsLocalUrl(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return Redirect("/login/");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "The username or password provided is incorrect.");
                }
            }
            return CurrentUmbracoPage();
        }

        public ActionResult RenderLogout()
        {
            return PartialView(PartialViewPath("_Logout"), null);
        }

        public ActionResult SubmitLogout()
        {
            TempData.Clear();
            Session.Clear();
            FormsAuthentication.SignOut();

            return RedirectToCurrentUmbracoPage();
        }
    }
}