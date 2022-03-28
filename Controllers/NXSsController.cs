#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NguyenXuanSon2022537.Models;

namespace NguyenXuanSon2022537.Controllers
{
    public class NXSsController : Controller
    {
        private readonly ApplicationDBContext _context;

        public NXSsController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: NXSs
        public async Task<IActionResult> Index()
        {
            return View(await _context.NXS537.ToListAsync());
        }

        // GET: NXSs/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nXS537 = await _context.NXS537
                .FirstOrDefaultAsync(m => m.NXSID == id);
            if (nXS537 == null)
            {
                return NotFound();
            }

            return View(nXS537);
        }

        // GET: NXSs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NXSs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NXSID,NXSName,NXSGender")] NXS537 nXS537)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nXS537);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nXS537);
        }

        // GET: NXSs/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nXS537 = await _context.NXS537.FindAsync(id);
            if (nXS537 == null)
            {
                return NotFound();
            }
            return View(nXS537);
        }

        // POST: NXSs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("NXSID,NXSName,NXSGender")] NXS537 nXS537)
        {
            if (id != nXS537.NXSID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nXS537);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NXS537Exists(nXS537.NXSID))
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
            return View(nXS537);
        }

        // GET: NXSs/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nXS537 = await _context.NXS537
                .FirstOrDefaultAsync(m => m.NXSID == id);
            if (nXS537 == null)
            {
                return NotFound();
            }

            return View(nXS537);
        }

        // POST: NXSs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var nXS537 = await _context.NXS537.FindAsync(id);
            _context.NXS537.Remove(nXS537);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NXS537Exists(string id)
        {
            return _context.NXS537.Any(e => e.NXSID == id);
        }
    }
}
