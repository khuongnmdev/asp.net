using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using QuanLyQuanCafe.Data;
using QuanLyQuanCafe.Models;

namespace QuanLyQuanCafe.Pages.QuanLyKhachHang
{
    public class DeleteModel : PageModel
    {
        private readonly QuanLyQuanCafe.Data.QuanLyQuanCafeContext _context;

        public DeleteModel(QuanLyQuanCafe.Data.QuanLyQuanCafeContext context)
        {
            _context = context;
        }

        [BindProperty]
        public KhachHang KhachHang { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khachhang = await _context.KhachHang.FirstOrDefaultAsync(m => m.MaKhachHang == id);

            if (khachhang == null)
            {
                return NotFound();
            }
            else
            {
                KhachHang = khachhang;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khachhang = await _context.KhachHang.FindAsync(id);
            if (khachhang != null)
            {
                KhachHang = khachhang;
                _context.KhachHang.Remove(KhachHang);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
