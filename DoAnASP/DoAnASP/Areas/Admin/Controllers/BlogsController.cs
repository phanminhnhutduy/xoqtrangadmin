using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DoAnASP.Areas.Admin.Models;
using DoAnASP.Areas.User.Data;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace DoAnASP.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogsController : Controller
    {
        private readonly DpContext _context;

        public BlogsController(DpContext context)
        {
            _context = context;
        }

        // GET: Admin/Blogs
        public async Task<IActionResult> Index()
        {
            var dpContext = _context.Blogs.Include(b => b.loai);
            return View(await dpContext.ToListAsync());
        }

        // GET: Admin/Blogs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blog = await _context.Blogs
                .Include(b => b.loai)
                .FirstOrDefaultAsync(m => m.IDBlog == id);
            if (blog == null)
            {
                return NotFound();
            }

            return View(blog);
        }

        // GET: Admin/Blogs/Create
        public IActionResult Create()
        {
            ViewData["IDLoai"] = new SelectList(_context.Loais, "IDLoai", "IDLoai");
            return View();
        }

        // POST: Admin/Blogs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDBlog,TieuDe,HinhAnh,TomTat,NoiDung,IDLoai,IDNguoiTao,NgayTao,NgayDuyet,View,IDNguoiDuyet,TrangThai")] Blog blog, IFormFile ful)
        {
            if (ModelState.IsValid)
            {
                _context.Add(blog);
                await _context.SaveChangesAsync();
                var parth = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/blog", blog.IDBlog + "." +
                ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1]);
                using (var stream = new FileStream(parth, FileMode.Create))
                {
                    await ful.CopyToAsync(stream);
                }
                blog.HinhAnh = blog.IDBlog + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1];
                _context.Update(blog);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IDLoai"] = new SelectList(_context.Loais, "IDLoai", "IDLoai", blog.IDLoai);
            return View(blog);
        }

        // GET: Admin/Blogs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blog = await _context.Blogs.FindAsync(id);
            if (blog == null)
            {
                return NotFound();
            }
            ViewData["IDLoai"] = new SelectList(_context.Loais, "IDLoai", "IDLoai", blog.IDLoai);
            return View(blog);
        }

        // POST: Admin/Blogs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDBlog,TieuDe,HinhAnh,TomTat,NoiDung,IDLoai,IDNguoiTao,NgayTao,NgayDuyet,View,IDNguoiDuyet,TrangThai")] Blog blog)
        {
            if (id != blog.IDBlog)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(blog);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BlogExists(blog.IDBlog))
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
            ViewData["IDLoai"] = new SelectList(_context.Loais, "IDLoai", "IDLoai", blog.IDLoai);
            return View(blog);
        }

        // GET: Admin/Blogs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blog = await _context.Blogs
                .Include(b => b.loai)
                .FirstOrDefaultAsync(m => m.IDBlog == id);
            if (blog == null)
            {
                return NotFound();
            }

            return View(blog);
        }

        // POST: Admin/Blogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var blog = await _context.Blogs.FindAsync(id);
            _context.Blogs.Remove(blog);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BlogExists(int id)
        {
            return _context.Blogs.Any(e => e.IDBlog == id);
        }
    }
}
