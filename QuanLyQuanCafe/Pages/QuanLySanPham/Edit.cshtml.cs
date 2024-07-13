﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QuanLyQuanCafe.Data;
using QuanLyQuanCafe.Models;

namespace QuanLyQuanCafe.Pages.QuanLySanPham
{
    public class EditModel : PageModel
    {
        private readonly QuanLyQuanCafe.Data.QuanLyQuanCafeContext _context;

        public EditModel(QuanLyQuanCafe.Data.QuanLyQuanCafeContext context)
        {
            _context = context;
        }

        [BindProperty]
        public SanPham SanPham { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sanpham =  await _context.SanPham.FirstOrDefaultAsync(m => m.MaSanPham == id);
            if (sanpham == null)
            {
                return NotFound();
            }
            SanPham = sanpham;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(SanPham).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SanPhamExists(SanPham.MaSanPham))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool SanPhamExists(int id)
        {
            return _context.SanPham.Any(e => e.MaSanPham == id);
        }
    }
}