using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Landlord.Models;

namespace Landlord.Controllers
{
    public class ServiceCasePostController : Controller
    {
        //Shows a service case with all connected posts
        [Authorize]
        public ActionResult Index(int caseNr)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();

            var postList = new List<ServiceCasePostViewModel>();
            ServiceCasePostViewModel serviceCasePost = new ServiceCasePostViewModel();

            foreach (ServiceReference1.ServiceCasePost post in client.GetCase(caseNr).Posts)
            {
                serviceCasePost.CaseNr = caseNr;
                serviceCasePost.CaseMessage = post.Message;
                //serviceCasePost.CaseMessage = post.UserDisplayName;
                //serviceCasePost.CaseMessage = post.UserEmail;
                //serviceCasePost.CaseMessage = post.Private;

                postList.Add(serviceCasePost);
            }
            return View(postList);
        }
    }
}