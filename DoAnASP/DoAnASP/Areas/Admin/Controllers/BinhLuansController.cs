using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DoAnASP.Areas.Admin.Models;
using DoAnASP.Areas.User.Data;

namespace DoAnASP.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BinhLuansController : Controller
    {
        private readonly DpContext _context;

        public BinhLuansController(DpContext context)
        {
            _context = context;
        }

        // GET: Admin/BinhLuans
        public async Task<IActionResult> Index()
        {
            var dpContext = _context.BinhLuans.Include(b => b.taiKhoans);
            return View(await dpContext.ToListAsync());
        }

        // GET: Admin/BinhLuans/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var binhLuan = await _context.BinhLuans
                .Include(b => b.taiKhoans)
                .FirstOrDefaultAsync(m => m.IDBL == id);
            if (binhLuan == null)
            {
                return NotFound();
            }

            return View(binhLuan);
        }

        // GET: Admin/BinhLuans/Create
        public IActionResult Create()
        {
            ViewData["IDTK"] = new SelectList(_context.TaiKhoans, "IDTK", "IDTK");
            return View();
        }

        // POST: Admin/BinhLuans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDBL,IDTK,IDBV,IDCH,NgayTao,NoiDung,TrangThai")] BinhLuan binhLuan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(binhLuan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IDTK"] = new SelectList(_context.TaiKhoans, "IDTK", "IDTK", binhLuan.IDTK);
            return View(binhLuan);
        }

        // GET: Admin/BinhLuans/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var binhLuan = await _context.BinhLuans.FindAsync(id);
            if (binhLuan == null)
            {
                return NotFound();
            }
            ViewData["IDTK"] = new SelectList(_context.TaiKhoans, "IDTK", "IDTK", binhLuan.IDTK);
            return View(binhLuan);
        }

        // POST: Admin/BinhLuans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDBL,IDTK,IDBV,IDCH,NgayTao,NoiDung,TrangThai")] BinhLuan binhLuan)
        {
            if (id != binhLuan.IDBL)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(binhLuan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BinhLuanExists(binhLuan.IDBL))
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
            ViewData["IDTK"] = new SelectList(_context.TaiKhoans, "IDTK", "IDTK", binhLuan.IDTK);
            return View(binhLuan);
        }

        // GET: Admin/BinhLuans/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var binhLuan = await _context.BinhLuans
                .Include(b => b.taiKhoans)
                .FirstOrDefaultAsync(m => m.IDBL == id);
            if (binhLuan == null)
            {
                return NotFound();
            }

            return View(binhLuan);
        }

        // POST: Admin/BinhLuans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var binhLuan = await _context.BinhLuans.FindAsync(id);
            _context.BinhLuans.Remove(binhLuan);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BinhLuanExists(int id)
        {
            return _context.BinhLuans.Any(e => e.IDBL == id);
        }
    }
}
