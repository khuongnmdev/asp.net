using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using QuanLyQuanCafe.Data;
using QuanLyQuanCafe.Models;

namespace QuanLyQuanCafe.Pages.QuanLySanPham
{
    public class DeleteModel : PageModel
    {
        private readonly QuanLyQuanCafe.Data.QuanLyQuanCafeContext _context;

        public DeleteModel(QuanLyQuanCafe.Data.QuanLyQuanCafeContext context)
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

            var sanpham = await _context.SanPham.FirstOrDefaultAsync(m => m.MaSanPham == id);

            if (sanpham == null)
            {
                return NotFound();
            }
            else
            {
                SanPham = sanpham;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sanpham = await _context.SanPham.FindAsync(id);
            if (sanpham != null)
            {
                SanPham = sanpham;
                _context.SanPham.Remove(SanPham);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
