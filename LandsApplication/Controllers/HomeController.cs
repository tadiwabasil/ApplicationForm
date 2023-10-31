using LandsApplication.Data;
using LandsApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace LandsApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

       
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]


        public async Task<IActionResult> Index([Bind("ApplicationNo,Forenames,Surname,SpouseName,DateOfBirth,Employer,LeaseTerms,MaritalStatus,RegistrtationParticulars,BuildingValue, PostalAdrress, PhysicalAddress, PhoneNumber,Occupation,ECNumber,Salary,Nationality,CountryOfResidence,StandAppliedFor,PurposeOfStand,TypeOfBusiness,FinanceSource,OtherStandsOwned,Insolvent,RailSiding")]
        Application appli)
        {
            if (ModelState.IsValid)
            {
                _context.Add(appli);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View("ok");
        }

        public IActionResult Application()
        {
            return View();
        }


        public IActionResult Purchase()
        {
            return View();
        }


        public IActionResult Agreement()
        {
            return View();
        }

        public IActionResult PurchaseForm()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> PurchaseForm(PurchaseOption purchaseOption)
        {
            if (ModelState.IsValid)
            {
                _context.PurchaseOptions.Add(purchaseOption);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View("ok");
        }

        public IActionResult AgreementForm()
        {
            return View();
        }


        [HttpPost]

        public async Task<IActionResult> AgreementForm(AgreementLease agreementlease)
        {
            if (ModelState.IsValid)
            {
                _context.AgreementLeases.Add(agreementlease);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View("ok");
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}