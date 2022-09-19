using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Money_Transfer.Database;
using Money_Transfer.Models;

namespace Money_Transfer.Controllers
{
    public class RegisterController : Controller
    {
        private readonly BankContext _context;

        public RegisterController(BankContext context)
        {
            _context = context;
        }

        // GET: User/Create
        public IActionResult Index()
        {
            return View();
        }

        // POST: User/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index([Bind("Id,UserName,Password")] User user)
        {
            user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
            if (ModelState.IsValid)
            {
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}
