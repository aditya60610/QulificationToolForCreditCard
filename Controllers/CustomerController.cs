using System.Diagnostics;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using QulificationToolForCreditCard.Models;
using QulificationToolForCreditCard.Models.BAL.Interface;
using QulificationToolForCreditCard.Repository.Interface;

namespace QulificationToolForCreditCard.Controllers
{
    public class CustomerController : Controller
    {
        private readonly CreditCardContext _context;
        private IWebHostEnvironment _hostingEnvironment;
        private ICalculateCreditCard _calculateCreditCard;
        private ICustomerRepository _customerRepository;
        private ICardDetailsRepository _cardDetailsRepository;

        public CustomerController(CreditCardContext context,
                                          IWebHostEnvironment environment,
                                          ICalculateCreditCard calculateCreditCard,
                                          ICustomerRepository customerRepository,
                                          ICardDetailsRepository cardDetailsRepository
                                          )
        {
            _context = context;
            _hostingEnvironment = environment;
            _calculateCreditCard = calculateCreditCard;
            _customerRepository = customerRepository;
            _cardDetailsRepository = cardDetailsRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer customer)
        {
            if (ModelState.IsValid && customer != null)
            {
                //Check if the customer is already in the system.
                bool result= _customerRepository.Find(customer);
                if (result)
                {
                    return View("CustomerDetails");
                }

                customer.CreditCardId = _calculateCreditCard.CalculateCreditCardDetails(customer.DOB, customer.AnnualIncome);
                _customerRepository.Add(customer);
                _customerRepository.Save();

                TempData["id"] = customer.CreditCardId;
                return Redirect("Result");
            }

            return View("Index");
        }

        public ActionResult Result()
        {
            if (TempData.ContainsKey("id") && TempData["id"] != null)
            {
                int id = (int)TempData["id"];
                CardDetails details =  _cardDetailsRepository.GetByID(id);
                ViewBag.CardDetails = Path.Combine(_hostingEnvironment.WebRootPath, string.Concat("/images/", details.CardName, ".PNG"));
                TempData.Clear();
                return View(details);
            }

            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
