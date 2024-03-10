using Microsoft.AspNetCore.Mvc;
using WebApplicationSunday.Data;
using WebApplicationSunday.Models;

namespace WebApplicationSunday.Controllers
{
    public class InformationController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InformationController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult AddInformation(InformationModel model)
        {
            if (ModelState.IsValid)
            { 
                _context.InformationModel.Add(model);
                _context.SaveChanges();
                
                return RedirectToAction("Index", "Home"); // main page
            }           
            return RedirectToAction("Error", "Home"); //error page 
        }
    }
}
