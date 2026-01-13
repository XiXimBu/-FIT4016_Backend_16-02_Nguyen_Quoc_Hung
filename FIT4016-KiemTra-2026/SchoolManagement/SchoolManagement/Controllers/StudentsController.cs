using Microsoft.AspNetCore.Mvc;
using FIT4016_KiemTra_2026.Data;
using FIT4016_KiemTra_2026.Models;

namespace FIT4016_KiemTra_2026.Controllers
{
    public class StudentsController : Controller
    {
        private readonly SchoolDbContext _context;

        public StudentsController(SchoolDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            ViewBag.Schools = _context.Schools.ToList();
            return View(_context.Students.ToList());
        }
    }
}