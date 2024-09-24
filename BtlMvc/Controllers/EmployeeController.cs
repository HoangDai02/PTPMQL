using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BtlMvc.Models;
using DemoMvc.Data;
using Microsoft.Identity.Client;

namespace BtlMvc.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }

        
        public async Task<IActionResult> Index()
        {
            return View(await _context.Employee.ToListAsync());
        }

        
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Employee
                .FirstOrDefaultAsync(m => m.FullName == id);
            if (student == null)
            {
                return NotFound();
            }

            return View();
        }

        // GET: Student/Create
        public IActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmployeeID,FullName,address")] Employee Employee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(Employee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Employee);
        }

    
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Employee = await _context.Employee.FindAsync(id);
            if (Employee == null)
            {
                return NotFound();
            }
            return View(Employee);
            
            
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("EmployeeID FullName,address")] Employee Employee)
        {
            if (id != Employee.FullName)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(Employee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(Employee.FullName))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(Employee);
        }

        private bool EmployeeExists(string fullName)
        {
            throw new NotImplementedException();
        }
    }
}