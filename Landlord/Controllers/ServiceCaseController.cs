using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Landlord.Models;

namespace Landlord.Controllers
{
    public class ServiceCaseController : Controller
    {
        // GET: ServiceCase
        [Authorize]
        public ActionResult Index()
        {

            ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();

            var serviceCaseList = new List<ServiceCaseViewModel>();
            foreach (ServiceReference1.ServiceCase caseInstance in service.GetAllCases())
            {
                serviceCaseList.Add(new ServiceCaseViewModel() {
                    CaseNr = caseInstance.CaseNr,
                    Date = caseInstance.Date,
                    FlatNr = caseInstance.FlatNr,
                    Name = caseInstance.Name,
                    ContactEmail = caseInstance.ContactEmail });
            }
            
            return View(serviceCaseList);
        }
    }
}