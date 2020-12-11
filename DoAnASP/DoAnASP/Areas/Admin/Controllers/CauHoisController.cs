using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DoAnASP.Areas.Admin.Models;
using DoAnASP.Areas.User.Data;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace DoAnASP.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CauHoisController : Controller
    {
        private readonly DpContext _context;

        public CauHoisController(DpContext context)
        {
            _context = context;
        }

        // GET: Admin/CauHois
        public async Task<IActionResult> Index()
        {
            var dpContext = _context.CauHois.Include(c => c.loai);
            return View(await dpContext.ToListAsync());
        }

        // GET: Admin/CauHois/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cauHoi = await _context.CauHois
                .Include(c => c.loai)
                .FirstOrDefaultAsync(m => m.IDBlog == id);
            if (cauHoi == null)
            {
                return NotFound();
            }

            return View(cauHoi);
        }

        // GET: Admin/CauHois/Create
        public IActionResult Create()
        {
            ViewData["IDLoai"] = new SelectList(_context.Loais, "IDLoai", "IDLoai");
            return View();
        }

        // POST: Admin/CauHois/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDBlog,TieuDe,HinhAnh,TomTat,NoiDung,IDLoai,IDNguoiTao,NgayTao,NgayDuyet,View,IDNguoiDuyet,TrangThai")] CauHoi cauHoi , IFormFile ful)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cauHoi);
                await _context.SaveChangesAsync();
                var parth = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Admin/images", cauHoi.IDBlog + "." +
                ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1]);
                using (var stream = new FileStream(parth, FileMode.Create))
                {
                    await ful.CopyToAsync(stream);
                }
                cauHoi.HinhAnh = cauHoi.IDBlog + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1];
                _context.Update(cauHoi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IDLoai"] = new SelectList(_context.Loais, "IDLoai", "IDLoai", cauHoi.IDLoai);
            return View(cauHoi);
        }

        // GET: Admin/CauHois/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cauHoi = await _context.CauHois.FindAsync(id);
            if (cauHoi == null)
            {
                return NotFound();
            }
            ViewData["IDLoai"] = new SelectList(_context.Loais, "IDLoai", "IDLoai", cauHoi.IDLoai);
            return View(cauHoi);
        }

        // POST: Admin/CauHois/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDBlog,TieuDe,HinhAnh,TomTat,NoiDung,IDLoai,IDNguoiTao,NgayTao,NgayDuyet,View,IDNguoiDuyet,TrangThai")] CauHoi cauHoi)
        {
            if (id != cauHoi.IDBlog)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cauHoi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CauHoiExists(cauHoi.IDBlog))
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
            ViewData["IDLoai"] = new SelectList(_context.Loais, "IDLoai", "IDLoai", cauHoi.IDLoai);
            return View(cauHoi);
        }

        // GET: Admin/CauHois/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cauHoi = await _context.CauHois
                .Include(c => c.loai)
                .FirstOrDefaultAsync(m => m.IDBlog == id);
            if (cauHoi == null)
            {
                return NotFound();
            }

            return View(cauHoi);
        }

        // POST: Admin/CauHois/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cauHoi = await _context.CauHois.FindAsync(id);
            _context.CauHois.Remove(cauHoi);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CauHoiExists(int id)
        {
            return _context.CauHois.Any(e => e.IDBlog == id);
        }
    }
}
